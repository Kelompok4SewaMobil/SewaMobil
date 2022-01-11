
namespace FPSewaMobil
{
    partial class Data_Pelanggan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxnama = new System.Windows.Forms.TextBox();
            this.dgvpenyewa = new System.Windows.Forms.DataGridView();
            this.txtnomorid = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnresetdata = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncari = new System.Windows.Forms.ToolStripButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenyewa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Indentitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Penyewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor Identitas";
            // 
            // textboxnama
            // 
            this.textboxnama.Location = new System.Drawing.Point(365, 123);
            this.textboxnama.Name = "textboxnama";
            this.textboxnama.Size = new System.Drawing.Size(249, 26);
            this.textboxnama.TabIndex = 4;
            this.textboxnama.TextChanged += new System.EventHandler(this.textboxnama_TextChanged);
            // 
            // dgvpenyewa
            // 
            this.dgvpenyewa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvpenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpenyewa.Location = new System.Drawing.Point(214, 325);
            this.dgvpenyewa.Name = "dgvpenyewa";
            this.dgvpenyewa.RowHeadersWidth = 62;
            this.dgvpenyewa.RowTemplate.Height = 28;
            this.dgvpenyewa.Size = new System.Drawing.Size(590, 271);
            this.dgvpenyewa.TabIndex = 8;
            this.dgvpenyewa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpenyewa_CellContentClick);
            // 
            // txtnomorid
            // 
            this.txtnomorid.Location = new System.Drawing.Point(365, 217);
            this.txtnomorid.Name = "txtnomorid";
            this.txtnomorid.Size = new System.Drawing.Size(249, 26);
            this.txtnomorid.TabIndex = 10;
            this.txtnomorid.TextChanged += new System.EventHandler(this.txtnomorid_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.btncari});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 38);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(210, 28);
            this.toolStripLabel1.Text = "Pencarian Data Customer";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 33);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(214, 262);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(126, 46);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "SIMPAN";
            this.btninsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(365, 262);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 46);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "EDIT";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(498, 262);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(116, 46);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "HAPUS";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnresetdata
            // 
            this.btnresetdata.Location = new System.Drawing.Point(642, 262);
            this.btnresetdata.Name = "btnresetdata";
            this.btnresetdata.Size = new System.Drawing.Size(162, 46);
            this.btnresetdata.TabIndex = 15;
            this.btnresetdata.Text = "RESET DATA";
            this.btnresetdata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnresetdata.UseVisualStyleBackColor = true;
            this.btnresetdata.Click += new System.EventHandler(this.btnresetdata_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(365, 168);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(249, 26);
            this.txtid.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "KEMBALI";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncari
            // 
            this.btncari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncari.Image = global::FPSewaMobil.Properties.Resources.search;
            this.btncari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(34, 28);
            this.btncari.Text = "toolStripButton1";
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FPSewaMobil.Properties.Resources.Back;
            this.pictureBox5.Location = new System.Drawing.Point(684, 619);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FPSewaMobil.Properties.Resources.share;
            this.pictureBox4.Location = new System.Drawing.Point(655, 270);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FPSewaMobil.Properties.Resources.write;
            this.pictureBox2.Location = new System.Drawing.Point(381, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FPSewaMobil.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(508, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FPSewaMobil.Properties.Resources.document__1_;
            this.pictureBox3.Location = new System.Drawing.Point(230, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Form untuk Menginputkan Data Customer penyewaan mobil";
            // 
            // Data_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1028, 694);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnresetdata);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtnomorid);
            this.Controls.Add(this.dgvpenyewa);
            this.Controls.Add(this.textboxnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Data_Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenyewa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxnama;
        private System.Windows.Forms.DataGridView dgvpenyewa;
        private System.Windows.Forms.TextBox txtnomorid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btncari;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnresetdata;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}