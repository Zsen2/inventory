using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void populate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [CustomerTB]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cusGV.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [CustomerTB] (CustomerName, CustomerNum) VALUES (@name, @number)", Con);
                cmd.Parameters.AddWithValue("@name", cusName.Text);
                cmd.Parameters.AddWithValue("@number", cusNum.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
            populate();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [CustomerTB] WHERE CustomerID=@cusid", Con);
                cmd.Parameters.AddWithValue("@cusid", cusID.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
            }
            populate();
        }

        private void cusGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.cusGV.Rows[e.RowIndex];
            cusName.Text = row.Cells["CustomerName"].Value.ToString();
            cusNum.Text = row.Cells["CustomerNum"].Value.ToString();
            cusID.Text = row.Cells["CustomerID"].Value.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [CustomerTB] SET CustomerName=@name, CustomerNum=@num WHERE CustomerID=@id", Con);
                cmd.Parameters.AddWithValue("@id", cusID.Text);
                cmd.Parameters.AddWithValue("@name", cusName.Text);
                cmd.Parameters.AddWithValue("@num", cusNum.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Update failed");
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
