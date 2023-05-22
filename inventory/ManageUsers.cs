using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [UserTable]", connectionString))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while populating data: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [UserTable] (Username, Password, FullName, PhoneNum) VALUES (@username, @password, @fullname, @phone)", connection);
                    cmd.Parameters.AddWithValue("@username", userTB.Text);
                    cmd.Parameters.AddWithValue("@password", passTB.Text);
                    cmd.Parameters.AddWithValue("@fullname", fullNameTB.Text);
                    cmd.Parameters.AddWithValue("@phone", numTB.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("User Already Exists or Error occurred: " + ex.Message);
            }
            populate();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [UserTable] WHERE FullName=@fullname", connection);
                    cmd.Parameters.AddWithValue("@fullname", fullNameTB.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            userTB.Text = row.Cells["Username"].Value.ToString();
            passTB.Text = row.Cells["Password"].Value.ToString();
            fullNameTB.Text = row.Cells["FullName"].Value.ToString();
            numTB.Text = row.Cells["PhoneNum"].Value.ToString();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [UserTable] SET Password=@password, Username=@username, PhoneNum=@phone WHERE FullName=@fullname", connection);
                    cmd.Parameters.AddWithValue("@password", passTB.Text);
                    cmd.Parameters.AddWithValue("@fullname", fullNameTB.Text);
                    cmd.Parameters.AddWithValue("@phone", numTB.Text);
                    cmd.Parameters.AddWithValue("@username", userTB.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            populate();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
