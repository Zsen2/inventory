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
    public partial class ManageCategories : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [CatTB]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cusGV.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [CatTB] (CatID, CatName) VALUES (@id, @name)", Con);
                cmd.Parameters.AddWithValue("@id", catID.Text);
                cmd.Parameters.AddWithValue("@name", catName.Text);
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

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [CatTB] SET CatName=@name WHERE CatID=@id", Con);
                cmd.Parameters.AddWithValue("@cusid", catID.Text);
                cmd.Parameters.AddWithValue("@cusname", catName.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Update failed");
            }
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cusGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.cusGV.Rows[e.RowIndex];
            catName.Text = row.Cells["catName"].Value.ToString();
            catID.Text = row.Cells["catID"].Value.ToString();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [CatTB] WHERE catID=@id", Con);
                cmd.Parameters.AddWithValue("@id", catID.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
            }
            populate();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
