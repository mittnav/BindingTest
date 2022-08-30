#pragma warning disable IDE1006 // Naming Styles.
#pragma warning disable SA1116  // Split parameters should start on line after declaration.
#pragma warning disable SA1117  // Parameters should be on same line or separate lines.
#pragma warning disable SA1204  // Static elements should appear before instance elements.
#pragma warning disable SA1300  // Element should begin with upper-case letter.
#pragma warning disable SA1601  // Partial elements should be documented.

using System.ComponentModel;
using System.Data;
using System.Text;

namespace BindingTest;

public partial class Form2 : Form
{
    public Form2() => InitializeComponent();

    private readonly BindingSource bsA = new(); // Airplanes
    private readonly BindingSource bsP = new(); // Passengers

    private void Form2_Load(object sender, EventArgs e)
    {
        bsP.ListChanged += bsP_ListChanged;

        // Create DataSet and connect it to the BindingSources
        var ds = CreateAirplaneSchema();
        var airplanes = ds.Tables["Airplane"];
        var passengers = ds.Tables["Passenger"];
        bsA.DataSource = ds;
        bsP.DataSource = ds;
        bsA.DataMember = airplanes?.TableName;
        bsP.DataMember = passengers?.TableName;

        if (airplanes is null || passengers is null) throw new NotSupportedException("This is really unexpected..."); // Hmm...

        DataRow a1, a2, a3; // Create some example data.
        a1 = airplanes.Rows.Add(null, "Boeing 747", 800);
        a2 = airplanes.Rows.Add(null, "Airbus A380", 1023);
        a3 = airplanes.Rows.Add(null, "Cessna 162", 67);
        passengers.Rows.Add(null, a1["ID"], "Joe Shmuck");
        passengers.Rows.Add(null, a1["ID"], "Jack B. Nimble");
        passengers.Rows.Add(null, a1["ID"], "Jib Jab");
        passengers.Rows.Add(null, a2["ID"], "Jackie Tyler");
        passengers.Rows.Add(null, a2["ID"], "Jane Doe");
        passengers.Rows.Add(null, a3["ID"], "John Smith");

        // Set up data binding for the parent Airplanes.
        grid.DataSource = bsA;
        grid.AutoGenerateColumns = true;
        txtModel.DataBindings.Add("Text", bsA, "Model");

        // Set up data binding for the child Passengers.
        bsP.DataSource = bsA; // Connect the two sources.
        bsP.DataMember = "Airplane_Passengers";
        lstPassengers.DataSource = bsP;
        lstPassengers.DisplayMember = "Name";
        txtName.DataBindings.Add("Text", bsP, "Name");
    }

    private void bsP_ListChanged(object? sender, ListChangedEventArgs e)
    {
        if (e.ListChangedType == ListChangedType.Reset)
            txtName.Enabled = bsP.Current is not null;
    }

    private static DataSet CreateAirplaneSchema()
    {
        var ds = new DataSet();

        // Create Airplane table.
        var airplanes = ds.Tables.Add("Airplane");
        var a_id = airplanes.Columns.Add("ID", typeof(int));
        _ = airplanes.Columns.Add("Model", typeof(string));
        _ = airplanes.Columns.Add("FuelLeftKg", typeof(int));
        a_id.AutoIncrement = true;
        a_id.AutoIncrementSeed = 1;
        a_id.AutoIncrementStep = 1;

        // Create Passengers table.
        var passengers = ds.Tables.Add("Passenger");
        var p_id = passengers.Columns.Add("ID", typeof(int));
        passengers.Columns.Add("AirplaneID", typeof(int));
        passengers.Columns.Add("Name", typeof(string));
        p_id.AutoIncrement = true;
        p_id.AutoIncrementSeed = 1;
        p_id.AutoIncrementStep = 1;

        // Create parent-child relationship.
        _ = ds.Relations.Add("Airplane_Passengers",
            airplanes.Columns["ID"] ?? new(), passengers.Columns["AirplaneID"] ?? new(), createConstraints: true);

        return ds;
    }

    private void txtAirplaneFilter_TextChanged(object sender, EventArgs e)
    {
        try
        {
            bsA.Filter = string.IsNullOrWhiteSpace(txtAirplaneFilter.Text)
                ? string.Empty
                : $"Model LIKE '%{txtAirplaneFilter.Text}%'";

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
            bsP.Filter = string.IsNullOrWhiteSpace(txtPassengerFilter.Text)
                ? string.Empty
                : $"Name LIKE '%{txtPassengerFilter.Text}%'";

            txtPassengerFilter.BackColor = SystemColors.Window;
        }
        catch (InvalidExpressionException)
        {
            txtPassengerFilter.BackColor = Color.Pink;
        }
    }
#pragma warning disable IDE0051 // Remove unused private members.
#pragma warning disable S1144   // Unused private types or members should be removed.
    // This method from the article is not in use,
    // but is provided in case YOU want to use it.
    private static string EscapeSqlLike(string s_)
    {
        var s = new StringBuilder(s_);
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '\'')
            {
                s.Insert(i++, '\'');
                continue;
            }

            if (s[i] is '[' or '*' or '?')
            {
                s.Insert(i++, '[');
                s.Insert(++i, ']');
            }
        }

        return s.ToString();
    }
}
