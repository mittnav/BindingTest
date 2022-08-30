#pragma warning disable IDE1006 // Naming Styles.
#pragma warning disable MA0016  // Prefer returning collection abstraction instead of implementation.
#pragma warning disable SA1300  // Element should begin with upper-case letter.
#pragma warning disable SA1402  // File may only contain a single type.
#pragma warning disable SA1601  // Partial elements should be documented.

using System.ComponentModel;

namespace BindingTest;

public partial class Form1 : Form
{
    public Form1() => InitializeComponent();

    private readonly BindingSource bsA = new(); // Airplanes
    private readonly BindingSource bsP = new(); // Passengers

    private void Form1_Load(object sender, EventArgs e)
    {
        bsP.ListChanged += bsP_ListChanged;

        Airplane a1, a2, a3; // Create some example data.
        bsA.Add(a1 = new Airplane("Boeing 747", 800));
        bsA.Add(a2 = new Airplane("Airbus A380", 1023));
        bsA.Add(a3 = new Airplane("Cessna 162", 67));
        a1.Passengers.Add(new Passenger("Joe Shmuck"));
        a1.Passengers.Add(new Passenger("Jack B. Nimble"));
        a1.Passengers.Add(new Passenger("Jib Jab"));
        a2.Passengers.Add(new Passenger("Jackie Tyler"));
        a2.Passengers.Add(new Passenger("Jane Doe"));
        a3.Passengers.Add(new Passenger("John Smith"));

        // Set up data binding for the parent Airplanes.
        grid.DataSource = bsA;
        grid.AutoGenerateColumns = true;
        txtModel.DataBindings.Add("Text", bsA, "Model");

        // Set up data binding for the child Passengers.
        bsP.DataSource = bsA; // Connect the two sources.
        bsP.DataMember = "Passengers";
        lstPassengers.DataSource = bsP;
        lstPassengers.DisplayMember = "Name";
        txtName.DataBindings.Add("Text", bsP, "Name");

        // Allow the user to add rows.
        ((BindingList<Airplane>)bsA.List).AllowNew = true;
        ((BindingList<Airplane>)bsA.List).AllowRemove = true;
    }

    private void bsP_ListChanged(object? sender, ListChangedEventArgs e)
    {
        if (e.ListChangedType == ListChangedType.Reset)
            txtName.Enabled = bsP.Current is not null;
    }
}

public class Airplane
{
    public Airplane() { }
    public Airplane(string model, int fuelKg) { Model = model; FuelLeftKg = fuelKg; }

    public int ID { get; } = GetNewID();
    public int FuelLeftKg { get; set; }
    public string Model { get; set; } = string.Empty;
    public List<Passenger> Passengers { get; } = new List<Passenger>(); // Do not return IList then it will show up in Grid.

    private static int lastID = 0;
    private static int GetNewID() => ++lastID;
}

public class Passenger
{
    public Passenger(string name) { ID = GetNewID(); Name = name; }

    public int ID { get; }
    public string Name { get; set; }

    private static int lastID = 0;
    private static int GetNewID() => ++lastID;
}
