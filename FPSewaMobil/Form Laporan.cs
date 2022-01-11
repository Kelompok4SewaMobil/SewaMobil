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
using DGVPrinterHelper;

namespace FPSewaMobil
{
    public partial class Form_Laporan : Form
    {
        SqlConnection koneksi = new SqlConnection
            (@"Data Source=LAPTOP-44L09114\ANDRIAN;Initial Catalog=SEWA_MOBIL;Integrated Security=True");

        public Form_Laporan()
        {
            InitializeComponent();
        }

        private void Form_Laporan_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dtap = new SqlDataAdapter("select * from login_admin", koneksi);
            DataTable dt = new DataTable();
            dtap.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan";
            printer.SubTitle = string.Format("Tanggal {0}", DateTime.Now.Date.ToString("dd-MMMM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            Form_Utama frm_menu = new Form_Utama();
            frm_menu.Show();
            this.Hide();
        }
    }
}
