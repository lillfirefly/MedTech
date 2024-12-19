using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace output
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
           
        }
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPageHandler;
            printDoc.Print();
        }

        // Define variables for drawing
        System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
        private Brush brush = Brushes.Black;
        private float x = 50; // Starting position for drawing on the x-axis
        private float y = 20; // Starting position for drawing on the y-axis

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Form1 form1 = new Form1();
            // Get the data from the DataGridView
            foreach (DataGridViewRow row in form1.dataGridView1.Rows)
            {
                // Extract data from the row and print it on the page
                string productName = row.Cells["ProductName"].Value.ToString();
                int quantitySold = Convert.ToInt32(row.Cells["QuantitySold"].Value);
                decimal totalRevenue = Convert.ToDecimal(row.Cells["TotalRevenue"].Value);

                // Use GDI+ to draw the data on the page
                e.Graphics.DrawString(productName, font, brush, x, y);
                y += font.GetHeight(); // Adjust y position for next line
                // ... (draw other data using similar logic)
            }
        }

    }
}
