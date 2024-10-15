namespace CENG211Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool name = false, email = false;
            if (textBox1.Text != "")
                name = true;
            if (textBox2.Text != "")
                email = true;
            if (name && email) {
                MessageBox.Show("Welcome to the program.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You didnt filled both textboxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
