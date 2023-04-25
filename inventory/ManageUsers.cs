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

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Table]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
            catch
            {

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
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (Username, Password, FullName, PhoneNum) VALUES (@username, @password, @fullname, @phone)", Con);
                cmd.Parameters.AddWithValue("@username", userTB.Text);
                cmd.Parameters.AddWithValue("@password", passTB.Text);
                cmd.Parameters.AddWithValue("@fullname", fullNameTB.Text);
                cmd.Parameters.AddWithValue("@phone", numTB.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
                MessageBox.Show("User Already Existed");
            }
            populate();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE FullName=@fullname", Con);
                cmd.Parameters.AddWithValue("@fullname", fullNameTB.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
            }
            populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            userTB.Text = row.Cells["Username"].Value.ToString();
            passTB.Text = row.Cells["Password"].Value.ToString();
            fullNameTB.Text = row.Cells["FullName"].Value.ToString();
            numTB.Text = row.Cells["PhoneNum"].Value.ToString();

        }
    }
}
