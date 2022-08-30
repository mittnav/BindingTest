namespace BindingTest;

internal static class Program
{
    /// <summary>The main entry point for the application.</summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(defaultValue: false);
        if (MessageBox.Show("Would you like to show the DataSet-based example (Form2)?\n\nClick No for the object-based example (Form1).", string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes)
            Application.Run(new Form2());
        else
            Application.Run(new Form1());
    }
}
