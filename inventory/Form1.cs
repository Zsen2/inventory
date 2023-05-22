using System.Data.SqlClient;
using System.Drawing;

namespace inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userTB.Text;
            string password = passTB.Text;

            if (AuthenticateUser(username, password))
            {
                new Home().Show();
                this.Hide();
                // Redirect to the main application or perform other actions
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
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
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [UserTable] WHERE Username=@username AND Password=@password", Con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();
                Con.Close();

                return (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}