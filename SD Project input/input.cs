using System.Diagnostics.Eventing.Reader;

namespace SD_Project_input
{
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill in Customer ID first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox2.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please fill in Customer name first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox3.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please fill in Customer address first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox4.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please fill in medicne id first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox5.Enabled = true;  // Enable TextBox2 if input is valid
            }

        }

        private void textBox5_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please fill in stock level first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox6.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void textBox6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please fill in price first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox7.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void textBox7_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Please fill in product name first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox8.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void textBox8_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please fill in quantity first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox9.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void textBox9_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please fill in status first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox9.Enabled = true;  // Enable TextBox2 if input is valid
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == "") || (textBox8.Text == "") || (textBox9.Text == ""))
            {
                MessageBox.Show("Please fill the required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Success", "The information is successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}