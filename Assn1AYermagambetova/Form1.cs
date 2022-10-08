namespace Assn1AYermagambetova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string streetAddress = txtStreetAddress.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;

            lblDisplay.Text = $"Thank you for entering your contact information\r\n\r\n{lastName}" +
                $", {firstName}\r\n{streetAddress}\r\n{city}, {province} {postalCode}";
            btnSave.BackColor = Color.LightGreen;
            btnSave.Text = "Save Successful!";
            btnSave.Enabled = false;
        }        
    }
}