namespace Assignment1
{
    public partial class Form1 : Form
    {
        const double PAY_RATE = 10.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.ResetText();
            txtLName.ResetText();
            txtHours.ResetText();
            lblSummary.ResetText();
        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            int hoursWrked = 0;
            try
            {
                hoursWrked = int.Parse(txtHours.Text);
                lblSummary.ForeColor = Color.Black;
            }
            catch
            {
                lblSummary.Text = "Error: Enter a valid integer for hours worked.";
                lblSummary.ForeColor = Color.Red;
                return;
            }
            double totalPay = hoursWrked * PAY_RATE;
            lblSummary.Text = $"{firstName} {lastName} worked {hoursWrked} hours at {PAY_RATE.ToString("C")} an hour for a total of {totalPay.ToString("C")}.";
        }
    }
}
