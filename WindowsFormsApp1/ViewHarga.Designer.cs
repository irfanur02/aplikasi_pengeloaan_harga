namespace WindowsFormsApp1
{
    partial class ViewHarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHarga));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTahun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMitra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.dgvPenawaranHarga = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPenawaranMitra = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenawaranHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbTahun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMitra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBarang);
            this.groupBox1.Controls.Add(this.btnTampilkan);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lihat Harga Penawaran Sebelumnya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Berdasarkan";
            // 
            // cmbTahun
            // 
            this.cmbTahun.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.Location = new System.Drawing.Point(68, 63);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.Size = new System.Drawing.Size(75, 25);
            this.cmbTahun.TabIndex = 25;
            this.cmbTahun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbTahun_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cari Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tahun";
            // 
            // cmbMitra
            // 
            this.cmbMitra.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMitra.FormattingEnabled = true;
            this.cmbMitra.Location = new System.Drawing.Point(68, 32);
            this.cmbMitra.Name = "cmbMitra";
            this.cmbMitra.Size = new System.Drawing.Size(180, 25);
            this.cmbMitra.TabIndex = 19;
            this.cmbMitra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbMitra_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mitra";
            // 
            // txtBarang
            // 
            this.txtBarang.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarang.Location = new System.Drawing.Point(99, 167);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(147, 24);
            this.txtBarang.TabIndex = 20;
            this.txtBarang.TextChanged += new System.EventHandler(this.txtBarang_TextChanged);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilkan.Image = ((System.Drawing.Image)(resources.GetObject("btnTampilkan.Image")));
            this.btnTampilkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTampilkan.Location = new System.Drawing.Point(68, 101);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(94, 25);
            this.btnTampilkan.TabIndex = 24;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // dgvPenawaranHarga
            // 
            this.dgvPenawaranHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenawaranHarga.Location = new System.Drawing.Point(308, 32);
            this.dgvPenawaranHarga.Name = "dgvPenawaranHarga";
            this.dgvPenawaranHarga.Size = new System.Drawing.Size(1020, 342);
            this.dgvPenawaranHarga.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data Harga Penawaran";
            // 
            // labelPenawaranMitra
            // 
            this.labelPenawaranMitra.AutoSize = true;
            this.labelPenawaranMitra.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenawaranMitra.Location = new System.Drawing.Point(447, 12);
            this.labelPenawaranMitra.Name = "labelPenawaranMitra";
            this.labelPenawaranMitra.Size = new System.Drawing.Size(11, 17);
            this.labelPenawaranMitra.TabIndex = 30;
            this.labelPenawaranMitra.Text = ":";
            // 
            // ViewHarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 391);
            this.Controls.Add(this.labelPenawaranMitra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPenawaranHarga);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewHarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHarga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenawaranHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarang;
        private System.Windows.Forms.ComboBox cmbMitra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTahun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPenawaranHarga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPenawaranMitra;
    }
}