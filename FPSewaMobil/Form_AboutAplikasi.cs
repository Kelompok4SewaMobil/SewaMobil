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
    public partial class Form_AboutAplikasi : Form
    {
        public Form_AboutAplikasi()
        {
            InitializeComponent();
        }

        private void aboutkembali1_Click(object sender, EventArgs e)
        {
            Form_Utama frm_menu = new Form_Utama();
            frm_menu.Show();
            this.Hide();
        }
    }
}
