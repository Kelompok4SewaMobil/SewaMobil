
namespace FPSewaMobil
{
    partial class Form_Laporan
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
            this.print = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(25, 37);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 33);
            this.print.TabIndex = 0;
            this.print.Text = "Tampilkan";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(327, 37);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(100, 33);
            this.kembali.TabIndex = 2;
            this.kembali.Text = "Kembali";
            this.kembali.UseVisualStyleBackColor = true;
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // Form_Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.print);
            this.Name = "Form_Laporan";
            this.Text = "Form_Laporan";
            this.Load += new System.EventHandler(this.Form_Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kembali;
    }
}