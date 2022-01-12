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
    public partial class Form_Transaksi : Form
    {
        public Form_Transaksi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Utama frm_menu = new Form_Utama();
            frm_menu.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-1NFNB131;Initial Catalog=SEWA_MOBIL;Integrated Security=True");

        private string notrans
        {

        }

        private void isicombo()
        {

        }

        private void resetdata()
        {

        }

        private void Form_Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }

        private void cbmobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from menu where namaMenu='" + cbmobil.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtnomormobil.Text = rd[0].ToString();
                txtharga.Text = rd[2].ToString();
                rd.Close();
            }
        }
    }
}
