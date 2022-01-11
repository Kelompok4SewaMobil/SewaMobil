
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Pelanggan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxnama = new System.Windows.Forms.TextBox();
            this.dgvpenyewa = new System.Windows.Forms.DataGridView();
            this.txtnomorid = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btncari = new System.Windows.Forms.ToolStripButton();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnresetdata = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenyewa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Penyewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor ID";
            // 
            // textboxnama
            // 
            this.textboxnama.Location = new System.Drawing.Point(237, 59);
            this.textboxnama.Name = "textboxnama";
            this.textboxnama.Size = new System.Drawing.Size(187, 26);
            this.textboxnama.TabIndex = 4;
            this.textboxnama.TextChanged += new System.EventHandler(this.textboxnama_TextChanged);
            // 
            // dgvpenyewa
            // 
            this.dgvpenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpenyewa.Location = new System.Drawing.Point(86, 261);
            this.dgvpenyewa.Name = "dgvpenyewa";
            this.dgvpenyewa.RowHeadersWidth = 62;
            this.dgvpenyewa.RowTemplate.Height = 28;
            this.dgvpenyewa.Size = new System.Drawing.Size(701, 271);
            this.dgvpenyewa.TabIndex = 8;
            this.dgvpenyewa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpenyewa_CellContentClick);
            // 
            // txtnomorid
            // 
            this.txtnomorid.Location = new System.Drawing.Point(237, 153);
            this.txtnomorid.Name = "txtnomorid";
            this.txtnomorid.Size = new System.Drawing.Size(187, 26);
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
            this.toolStrip1.Size = new System.Drawing.Size(871, 33);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(173, 28);
            this.toolStripLabel1.Text = "Pencarian Pelanggan";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 33);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // btncari
            // 
            this.btncari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncari.Image = ((System.Drawing.Image)(resources.GetObject("btncari.Image")));
            this.btncari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(34, 28);
            this.btncari.Text = "toolStripButton1";
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(86, 207);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(126, 37);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(287, 207);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(115, 37);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(482, 207);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(116, 37);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnresetdata
            // 
            this.btnresetdata.Location = new System.Drawing.Point(657, 207);
            this.btnresetdata.Name = "btnresetdata";
            this.btnresetdata.Size = new System.Drawing.Size(130, 37);
            this.btnresetdata.TabIndex = 15;
            this.btnresetdata.Text = "Reset Data";
            this.btnresetdata.UseVisualStyleBackColor = true;
            this.btnresetdata.Click += new System.EventHandler(this.btnresetdata_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(237, 104);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(187, 26);
            this.txtid.TabIndex = 16;
            // 
            // Data_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 560);
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
            this.Text = "Data_Pelanggan";
            this.Load += new System.EventHandler(this.Data_Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenyewa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}