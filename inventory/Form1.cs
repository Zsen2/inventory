namespace inventory
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                passTB.UseSystemPasswordChar = false;
            }
            else
            {
                passTB.UseSystemPasswordChar = true;
            }
        }

        private void userTB_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}