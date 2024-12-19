using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Configuration;


namespace output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000, "Notification Title", "Notification Message", ToolTipIcon.Info);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Stock Level");
            dataTable.Columns.Add("Quantity Sold");
            dataTable.Columns.Add("Waiting List");

            dataTable.Rows.Add("panadol", "500", "100", "mohammed ali");
            dataTable.Rows.Add("voltarien", "700", "50", "gehad ahmed");

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            notification_form notifications = new notification_form();
            notifications.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesReportForm reportForm = new SalesReportForm();
            reportForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
