using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GeneratePDF();
        }
        void populateProd()
        {
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [OrderTB]", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateProd();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
        private void GeneratePDF()
        {
            try
            {
                using (Document doc = new Document())
                {
                    string pdfFilePath = "D:\\Documents\\OrderSummary.pdf";
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));

                    doc.Open();

                    // Center-aligned paragraph for the "Order Summary"
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 25, iTextSharp.text.Font.BOLD);
                    Paragraph titleParagraph = new Paragraph("Order Summary", titleFont);
                    titleParagraph.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titleParagraph);

                    // Add a blank line
                    doc.Add(new Paragraph(" "));

                    // Access the table data from the DataGridView control
                    DataGridViewRow row = dataGridView2.CurrentRow;
                    string orderID = row.Cells[0].Value.ToString();
                    string customerID = row.Cells[1].Value.ToString();
                    string customerName = row.Cells[2].Value.ToString();
                    string orderDate = row.Cells[3].Value.ToString();
                    string totalAmount = row.Cells[4].Value.ToString();

                    // Add the order details to the PDF
                    doc.Add(new Paragraph("Order ID: " + orderID));
                    doc.Add(new Paragraph("Customer ID: " + customerID));
                    doc.Add(new Paragraph("Customer Name: " + customerName));
                    doc.Add(new Paragraph("Order Date: " + orderDate));
                    doc.Add(new Paragraph("Total Amount: " + totalAmount));

                    doc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }
    }
}
