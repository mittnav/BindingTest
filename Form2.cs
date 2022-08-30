using System.ComponentModel;
using System.Data;
using System.Text;

namespace BindingTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        readonly BindingSource bsA = new(); // Airplanes
        readonly BindingSource bsP = new(); // Passengers

        private void Form2_Load(object sender, EventArgs e)
        {
            bsP.ListChanged += new ListChangedEventHandler(bsP_ListChanged);

            // Create DataSet and connect it to the BindingSources
            DataSet ds = CreateAirplaneSchema();
            DataTable? airplanes = ds.Tables["Airplane"];
            DataTable? passengers = ds.Tables["Passenger"];
            bsA.DataSource = ds;
            bsP.DataSource = ds;
            bsA.DataMember = airplanes?.TableName;
            bsP.DataMember = passengers?.TableName;

            if (airplanes is null || passengers is null) return; // Hmm...

            // Create some example data.
            DataRow a1, a2, a3;
            a1 = airplanes.Rows.Add(null, "Boeing 747", 800);
            a2 = airplanes.Rows.Add(null, "Airbus A380", 1023);
            a3 = airplanes.Rows.Add(null, "Cessna 162", 67);
            passengers.Rows.Add(null, a1["ID"], "Joe Shmuck");
            passengers.Rows.Add(null, a1["ID"], "Jack B. Nimble");
            passengers.Rows.Add(null, a1["ID"], "Jib Jab");
            passengers.Rows.Add(null, a2["ID"], "Jackie Tyler");
            passengers.Rows.Add(null, a2["ID"], "Jane Doe");
            passengers.Rows.Add(null, a3["ID"], "John Smith");

            // Set up data binding for the parent Airplanes
            grid.DataSource = bsA;
            grid.AutoGenerateColumns = true;
            txtModel.DataBindings.Add("Text", bsA, "Model");

            // Set up data binding for the child Passengers
            bsP.DataSource = bsA; // connect the two sources
            bsP.DataMember = "Airplane_Passengers";
            lstPassengers.DataSource = bsP;
            lstPassengers.DisplayMember = "Name";
            txtName.DataBindings.Add("Text", bsP, "Name");
        }

        void bsP_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset)
                txtName.Enabled = bsP.Current != null;
        }

        static DataSet CreateAirplaneSchema()
        {
            var ds = new DataSet();

            // Create Airplane table
            DataTable airplanes = ds.Tables.Add("Airplane");
            DataColumn a_id = airplanes.Columns.Add("ID", typeof(int));
            airplanes.Columns.Add("Model", typeof(string));
            airplanes.Columns.Add("FuelLeftKg", typeof(int));
            a_id.AutoIncrement = true;
            a_id.AutoIncrementSeed = 1;
            a_id.AutoIncrementStep = 1;

            // Create Passengers table
            DataTable passengers = ds.Tables.Add("Passenger");
            DataColumn p_id = passengers.Columns.Add("ID", typeof(int));
            passengers.Columns.Add("AirplaneID", typeof(int));
            passengers.Columns.Add("Name", typeof(string));
            p_id.AutoIncrement = true;
            p_id.AutoIncrementSeed = 1;
            p_id.AutoIncrementStep = 1;

            // Create parent-child relationship
            DataRelation relation = ds.Relations.Add("Airplane_Passengers",
                airplanes.Columns["ID"] ?? new(), passengers.Columns["AirplaneID"] ?? new(), true);

            return ds;
        }

        // This method from the article is not in use, but is 
        // provided in case YOU want to use it.
        static string EscapeSqlLike(string s_)
        {
            var s = new StringBuilder(s_);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\'')
                {
                    s.Insert(i++, '\'');
                    continue;
                }
                if (s[i] == '[' || s[i] == '*' || s[i] == '?')
                {
                    s.Insert(i++, '[');
                    s.Insert(++i, ']');
                }
            }
            return s.ToString();
        }

        void txtAirplaneFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsA.Filter = txtAirplaneFilter.Text;
                txtAirplaneFilter.BackColor = SystemColors.Window;
            }
            catch (InvalidExpressionException)
            {
                txtAirplaneFilter.BackColor = Color.Pink;
            }
        }

        private void txtPassengerFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsP.Filter = txtPassengerFilter.Text;
                txtPassengerFilter.BackColor = SystemColors.Window;
            }
            catch (InvalidExpressionException)
            {
                txtPassengerFilter.BackColor = Color.Pink;
            }
        }
    }
}
