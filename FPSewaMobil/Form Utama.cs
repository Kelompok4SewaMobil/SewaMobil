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
            if (MessageBox.Show("Yakin akan keluar?","Exit",MessageBoxButtons.OKCancel) == DialogResult.OK)
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

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
