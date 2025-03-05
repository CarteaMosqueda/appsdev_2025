namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmationResult == DialogResult.Yes)
            { }
            string fNameValue = firstname.Text;
            string mNameValue = middlename.Text;
            string lNameValue = lastname.Text;
            string suffix = suffixTextBox.Text;
           
            string greetingMessage = $"Hello There! {fNameValue} {mNameValue} {lNameValue} {suffix}!";
            MessageBox.Show(greetingMessage, "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
