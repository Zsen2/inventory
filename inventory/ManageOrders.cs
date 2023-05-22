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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        public int num = 0, sum = 0, stock, uprice, totprice, qty, flag = 0;
        public string product;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [CustomerTB]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void populateProd()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [ProductTB]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
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
                comboBox2.ValueMember = "CatName";
                comboBox2.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProd();
            fillManufac();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            cusID.Text = row.Cells["CustomerID"].Value.ToString();
            cusName.Text = row.Cells["CustomerName"].Value.ToString();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [ProductTB] where ProdManufac='" + comboBox2.SelectedValue.ToString() + "'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            product = row.Cells["ProdName"].Value.ToString();
            uprice = (int)row.Cells["ProdPrice"].Value;
            stock = (int)row.Cells["ProdQTY"].Value;
            dataGridView2.CurrentRow.Selected = true;
            flag = 1;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Please Select a Product");
            }
            else if (int.Parse(qtyTB.Text) > stock)
            {
                MessageBox.Show("Not Enough Stocks Left");
            }
            else
            {
                num++;
                qty = int.Parse(qtyTB.Text);
                totprice = qty * uprice;
                dataGridView3.Rows.Add(num, product, qty, uprice, totprice);
                sum += totprice;
                totalAm.Text = "PHP " + sum.ToString();
                updateQTY();
                flag = 0;
            }
        }
        void updateQTY()
        {
            int id = (int)dataGridView2.Rows[0].Cells[0].Value;
            int newQTY = stock - int.Parse(qtyTB.Text);

            if (newQTY > 0)
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [ProductTB] SET ProdQTY=@qty WHERE ProdID=@id", Con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@qty", newQTY);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateProd();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cusID.Equals("") || cusName.Equals(""))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [OrderTB] (CusID, CusName, OrderDate, TotalAmnt) VALUES (@cusid, @cusname, @orderdate, @totalamount)", Con);
                    cmd.Parameters.AddWithValue("@cusid", cusID.Text);
                    cmd.Parameters.AddWithValue("@cusname", cusName.Text);

                    // Convert the orderDate.Text to DateTime object
                    DateTime orderDateTime;
                    if (DateTime.TryParse(orderDate.Text, out orderDateTime))
                    {
                        cmd.Parameters.AddWithValue("@orderdate", orderDateTime);
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format");
                        Con.Close();
                        return;
                    }

                    cmd.Parameters.AddWithValue("@totalamount", sum);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ViewOrders().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void orderID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
