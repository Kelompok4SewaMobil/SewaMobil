using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPSewaMobil
{
    public partial class Form_Utama : Form
    {
        public Form_Utama()
        {
            InitializeComponent();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?","Keluar",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Form_Login frm_menu = new Form_Login();
                frm_menu.Show();
                this.Hide();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 frm_menu = new Form1();
            frm_menu.Show();
            this.Hide();
        }

        private void laporan_Click(object sender, EventArgs e)
        {
            Form_Laporan frm_menu = new Form_Laporan();
            frm_menu.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form_Transaksi frm_menu = new Form_Transaksi();
            frm_menu.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form_Data_Mobil frm_menu = new Form_Data_Mobil();
            frm_menu.Show();
            this.Hide();
        }

        private void aboutaplikasi_Click(object sender, EventArgs e)
        {
            Form_AboutAplikasi frm_menu = new Form_AboutAplikasi();
            frm_menu.Show();
            this.Hide();
        }

        private void aboutkelompok_Click(object sender, EventArgs e)
        {
            Form_AboutKelompok frm_menu = new Form_AboutKelompok();
            frm_menu.Show();
            this.Hide();
        }


        private void toolStripDataPelanggan_Click_1(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Data_Pelanggan frm_menu = new Data_Pelanggan();
            frm_menu.Show();
            this.Hide();
        }
    }
}
