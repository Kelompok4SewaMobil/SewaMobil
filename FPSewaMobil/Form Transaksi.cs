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
            get
            {
                con.Open();
                string nomor = "SW-001";
                SqlCommand cmd = new SqlCommand("select max(right(no_transaksi,4)) from transaksimobil", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "SW-" + (int.Parse(rd[0].ToString()) + 1).ToString("0000");
                rd.Close();
                return nomor;
            }
        }

        private void isicombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nama_mobil from mobil";
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds1, "mobil");
            cbmobil.DataSource = ds1.Tables["mobil"];
            cbmobil.DisplayMember = "nama_mobil";
        }

        private void resetdata()
        {
            con.Close();
            txtno.Text = notrans;
            txtidcust.Text = "";
            cbmobil.Text = "";
            txttahun.Text = "";
            txtnomormobil.Text = "";
        }

        private void Form_Transaksi_Load(object sender, EventArgs e)
        {
            txtno.Text = notrans;
            isicombo();
            txttgl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txttahun.Text == "")
            {
                MessageBox.Show("Data harap diisi!");
                goto berhenti;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into transaksimobil values('" + txtno.Text + "','" + txttgl.Text + "','" + txtidcust.Text + "','" + txttahun.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "insert into detailtransaksimobil values('" + txtno.Text + "','" + txtnomormobil.Text + "')";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();

            resetdata();
            txtidcust.Focus();

        berhenti:
            ;
        }

        private void cbmobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from mobil where nama_mobil='" + cbmobil.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtnomormobil.Text = rd[0].ToString();
                txttahun.Text = rd[2].ToString();
                rd.Close();
            }
        }
    }
}
