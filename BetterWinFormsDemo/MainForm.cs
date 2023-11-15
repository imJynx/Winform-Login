using WinFormsDemo;

namespace BetterWinFormsDemo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void sayHelloButton_Click(object sender, EventArgs e)
    {
        // Get the entered first name
        string enteredFirstName = firstNameText.Text;

        // Check if the entered first name is valid
        if (isValidFirstName(enteredFirstName))
        {
            // Hide the login panel
            this.Hide();

            // Wait for 1 second
            System.Threading.Thread.Sleep(1000);

            // Open the new window
            Form2 frm = new("Hello from Form1");
            frm.Show();
        }
        else
        {
            // Display an error message and close the application
            MessageBox.Show("Invalid license key.");
            Application.Exit();
        }
    }

    private void firstNameLabel_Click(object sender, EventArgs e)
    {

    }
    private void firstNameText_TextChanged(object sender, EventArgs e)
    {

    }

    private bool isValidFirstName(string firstName)
    {
        // Implement your logic to validate the first name
        // Replace the following placeholder code with your actual validation logic
        const string expectedFirstName = "imJynx";
        return firstName.Equals(expectedFirstName);
    }

}