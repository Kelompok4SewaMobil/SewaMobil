
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
            this.textboxid = new System.Windows.Forms.TextBox();
            this.textboxnama = new System.Windows.Forms.TextBox();
            this.textboxharga = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvpenyewa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenyewa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 105);
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
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Sewa";
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(237, 58);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(187, 26);
            this.textboxid.TabIndex = 3;
            this.textboxid.TextChanged += new System.EventHandler(this.textboxid_TextChanged);
            // 
            // textboxnama
            // 
            this.textboxnama.Location = new System.Drawing.Point(237, 105);
            this.textboxnama.Name = "textboxnama";
            this.textboxnama.Size = new System.Drawing.Size(187, 26);
            this.textboxnama.TabIndex = 4;
            this.textboxnama.TextChanged += new System.EventHandler(this.textboxnama_TextChanged);
            // 
            // textboxharga
            // 
            this.textboxharga.Location = new System.Drawing.Point(237, 153);
            this.textboxharga.Name = "textboxharga";
            this.textboxharga.Size = new System.Drawing.Size(187, 26);
            this.textboxharga.TabIndex = 5;
            this.textboxharga.TextChanged += new System.EventHandler(this.textboxharga_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(553, 207);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 38);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(689, 209);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 35);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            // Data_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 560);
            this.Controls.Add(this.dgvpenyewa);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textboxharga);
            this.Controls.Add(this.textboxnama);
            this.Controls.Add(this.textboxid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pelanggan";
            this.Text = "Data_Pelanggan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenyewa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.TextBox textboxnama;
        private System.Windows.Forms.TextBox textboxharga;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvpenyewa;
    }
}