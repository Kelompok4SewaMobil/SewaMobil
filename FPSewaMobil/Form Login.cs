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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
       SqlConnection con = new SqlConnection
      (@"Data Source=DESKTOP-UVE2IP6\UMIRFH;Initial Catalog=SEWA_MOBIL;Integrated Security=True");

        private string CaesarCipher(string value, int shift)
        {
            string[] joinCipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');
            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    char[] buffer = wordArray[x].ToCharArray();
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        char letter = buffer[i];
                        letter = (char)(letter + shift);
                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        buffer[i] = letter;
                    }
                    string HasilKonversi = new string(buffer);
                    joinCipher[x] = HasilKonversi;
                }
                joinText = string.Join(" ", joinCipher);
                return joinText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                if (txtuser.Text == "" | txtpwd.Text == "")
                {
                    MessageBox.Show("Semua data harus diisi", "PERINGATAN");
                    goto berhenti;
                }
                string tekscipher = null;
                tekscipher = CaesarCipher(txtpwd.Text, 17);

                con.Close();
                SqlCommand cmd = new SqlCommand("select * from login_admin where username='" +
                    txtuser.Text + "' and password= '" + tekscipher + "'", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    Form_Utama frm_menu = new Form_Utama();
                    frm_menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username atau password tidak valid", "PERINGATAN");
                    txtuser.Text = "";
                    txtuser.Focus();
                    txtpwd.Text = "";
                    rd.Close();
                }

            berhenti:
                ;
            }

        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
