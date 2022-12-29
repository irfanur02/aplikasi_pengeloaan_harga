namespace WindowsFormsApp1
{
    partial class ViewPenawaran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMitra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPenawaran = new System.Windows.Forms.DataGridView();
            this.cmbTahun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenawaran)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTahun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMitra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Penawaran";
            // 
            // cmbMitra
            // 
            this.cmbMitra.DropDownHeight = 200;
            this.cmbMitra.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMitra.FormattingEnabled = true;
            this.cmbMitra.IntegralHeight = false;
            this.cmbMitra.Location = new System.Drawing.Point(61, 36);
            this.cmbMitra.Name = "cmbMitra";
            this.cmbMitra.Size = new System.Drawing.Size(204, 25);
            this.cmbMitra.TabIndex = 27;
            this.cmbMitra.SelectedValueChanged += new System.EventHandler(this.cmbMitra_SelectedValueChanged);
            this.cmbMitra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbMitra_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mitra";
            // 
            // dgvPenawaran
            // 
            this.dgvPenawaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenawaran.Location = new System.Drawing.Point(12, 108);
            this.dgvPenawaran.Name = "dgvPenawaran";
            this.dgvPenawaran.Size = new System.Drawing.Size(641, 259);
            this.dgvPenawaran.TabIndex = 11;
            this.dgvPenawaran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenawaran_CellClick);
            // 
            // cmbTahun
            // 
            this.cmbTahun.DropDownHeight = 200;
            this.cmbTahun.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.IntegralHeight = false;
            this.cmbTahun.Location = new System.Drawing.Point(333, 36);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.Size = new System.Drawing.Size(85, 25);
            this.cmbTahun.TabIndex = 29;
            this.cmbTahun.SelectedValueChanged += new System.EventHandler(this.cmbTahun_SelectedValueChanged);
            this.cmbTahun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbTahun_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tahun";
            // 
            // ViewPenawaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 385);
            this.Controls.Add(this.dgvPenawaran);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewPenawaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPenawaran";
            this.Load += new System.EventHandler(this.ViewPenawaran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenawaran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPenawaran;
        private System.Windows.Forms.ComboBox cmbMitra;
        private System.Windows.Forms.ComboBox cmbTahun;
        private System.Windows.Forms.Label label1;
    }
}