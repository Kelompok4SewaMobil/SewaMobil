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
    public partial class Data_Pelanggan : Form
    {
        public Data_Pelanggan()
        {
            InitializeComponent();
           
        }
         SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-44L09114\ANDRIAN;Initial Catalog=SEWA_MOBIL;Integrated Security=True");
    

        private void showdata()
        {
            

        }


        private void resetdata()
        {
            txtid.Text = "";
            textboxnama.Text = "";
            txtnomorid.Text = "";

        }


        private void btndelete_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvpenyewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textboxnama_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Data_Pelanggan_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void cbid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnomorid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Isi Nama Penyewa Yang Dihapus");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from penyewa where nama_penyewa = '" + txtid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;

        }

        private void btnresetdata_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void btncari_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from penyewa where nama_penyewa like '%" + toolStripTextBox1.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "penyewa");
            dgvpenyewa.DataSource = ds;
            dgvpenyewa.DataMember = "penyewa";
            dgvpenyewa.ReadOnly = true;
        }
    }
}
