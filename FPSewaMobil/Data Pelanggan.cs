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
            (@"Data Source=LAPTOP-1NFNB131;Initial Catalog=SEWA_MOBIL;Integrated Security=True");
    

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from penyewa";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "penyewa");
            dgvpenyewa.DataSource = ds;
            dgvpenyewa.DataMember = "penyewa";
            dgvpenyewa.ReadOnly = true;

        }


        private void resetdata()
        {
            txtid.Text = "";
            textboxnama.Text = "";
            txtnomorid.Text = "";

        }


        private void btndelete_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "penyewa";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idPenyewa = new SqlParameter("@id", SqlDbType.VarChar);

            idPenyewa.Value = txtid.Text;
            cmd.Parameters.Add(idPenyewa);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }

        private void dgvpenyewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvpenyewa.Rows[e.RowIndex];

                textboxnama.Text = row.Cells["nama_penyewa"].Value.ToString();
                txtid.Text = row.Cells["jenis_id"].Value.ToString();
                txtnomorid.Text = row.Cells["nomor_id"].Value.ToString();
            }
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

            if (textboxnama.Text == "" | txtid.Text == "" | txtnomorid.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "PERINGATAN");
                goto berhenti;
            }
            int num;
            bool isNum = int.TryParse(txtnomorid.Text.ToString(), out num);
            if (!isNum)
            {
                MessageBox.Show("Mohon Isi Nomor ID", "PERINGATAN");
                goto berhenti;
            }
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into penyewa values ('" + textboxnama.Text + "','" + txtid.Text + "'," + int.Parse(txtnomorid.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        berhenti:;

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

            if (textboxnama.Text == "" | txtid.Text == "" | txtnomorid.Text == "")
            {
                MessageBox.Show("Semua Data Harus Diisi", "PERINGATAN");
                goto berhenti;
            }
            int num;
            bool isNum = int.TryParse(txtnomorid.Text.ToString(), out num);
            if (!isNum)
            {
                MessageBox.Show("Mohon Isi Nomor ID", "PERINGATAN");
                goto berhenti;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update penyewa set jenis_id = '" + txtid.Text + "',  nomor_id =" + txtnomorid.Text + " where nomor_id = '" + txtnomorid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Isi Nama Penyewa Yang Dihapus", "PERINGATAN");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Utama frm_menu = new Form_Utama();
            frm_menu.Show();
            this.Hide();
        }
    }
}
