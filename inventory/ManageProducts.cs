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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void fillManufac()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM [CatTB]";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "CatName";
                comboBox1.DataSource = dt;
                comboBox2.ValueMember = "CatName";
                comboBox2.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void populate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [ProductTB]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void fillByManufac()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [ProductTB] where ProdManufac='" + comboBox2.SelectedValue.ToString() + "'", Con);
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            prodName.Text = row.Cells["ProdName"].Value.ToString();
            prodQT.Text = row.Cells["ProdQTY"].Value.ToString();
            prodPrice.Text = row.Cells["ProdPrice"].Value.ToString();
            desc.Text = row.Cells["ProdDesc"].Value.ToString();
            comboBox1.Text = row.Cells["ProdManufac"].Value.ToString();
            prodID.Text = row.Cells["ProdID"].Value.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillManufac();
            populate();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [ProductTB] (ProdID, ProdName, ProdQTY, ProdPrice, ProdDesc, ProdManufac) VALUES (@id, @name, @qty, @price, @desc, @manufac)", Con);
                cmd.Parameters.AddWithValue("@id", prodID.Text);
                cmd.Parameters.AddWithValue("@name", prodName.Text);
                cmd.Parameters.AddWithValue("@qty", prodQT.Text);
                cmd.Parameters.AddWithValue("@price", prodPrice.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@manufac", comboBox1.Text);
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
                SqlCommand cmd = new SqlCommand("UPDATE [ProductTB] SET ProdName=@name, ProdQTY=@qty, ProdPrice=@price, ProdDesc=@desc, ProdManufac=@manufac WHERE ProdID=@id", Con);
                cmd.Parameters.AddWithValue("@id", prodID.Text);
                cmd.Parameters.AddWithValue("@name", prodName.Text);
                cmd.Parameters.AddWithValue("@qty", prodQT.Text);
                cmd.Parameters.AddWithValue("@price", prodPrice.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@manufac", comboBox1.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            populate();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [ProductTB] WHERE ProdID=@id", Con);
                cmd.Parameters.AddWithValue("@id", prodID.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch
            {
            }
            populate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillByManufac();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
