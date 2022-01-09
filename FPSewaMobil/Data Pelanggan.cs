﻿using System;
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
            (@"");

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select From pelanggan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "pelanggan");
            dgvpenyewa.DataSource = ds;
            dgvpenyewa.datapelanggan = "pelanggan";
            DataGridViewCellContextMenuStripNeededEventArgs.ReadOnly = true;

        }


        private void resetdata()
        {
            textboxid.Text = "";
            textboxnama.Text = "";
            textboxharga.Text = "";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ADDPELANGGAN";
            cmd.CommandType = CommandType.StoredProcedure;

            //Buat parameter yang sama dengan sql
            SqlParameter idpelanggan = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter namaPelanggan = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter harga = new SqlParameter("@harga", SqlDbType.VarChar);

            //mengisi variable sql parameter dengan nilai textbox
            idpelanggan.Value = txtnomobil.Text;
            namaPelanggan.Value = txtnamamobil.Text;
            harga.Value = txthargasewa.Text;

            //menambah parameter tadi ke comand yang ada
            cmd.Parameters.Add(idpelanggan);
            cmd.Parameters.Add(namaPelanggan);
            cmd.Parameters.Add(harga);

            //jalankan procedure
            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();


        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvpenyewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textboxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_Pelanggan_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }
    }
}