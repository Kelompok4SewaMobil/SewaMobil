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
namespace FPSewaMobil
{
    public partial class Form_Data_Mobil : Form
    {
        public Form_Data_Mobil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
            (@"Data Source=USER-PC;Initial Catalog=SEWA_MOBIL;Integrated Security=True");

        private void resetdata()
        {
            txtnomobil.Text = "";
            txttahun.Text = "";
            txtnama.Text = "";
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from mobil";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "mobil");
            dgvdatamobil.DataSource = ds;
            dgvdatamobil.DataMember = "mobil";
            dgvdatamobil.ReadOnly = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form_Utama frm_menu = new Form_Utama();
            frm_menu.Show();
            this.Hide();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
         
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

       
        }

        private void btncari_Click(object sender, EventArgs e)
        {
           
        }
    }
}
