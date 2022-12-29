namespace WindowsFormsApp1
{
    partial class MenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kelolaMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMesinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatPenawaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buatPenawaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelolaMasterToolStripMenuItem,
            this.penjualanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kelolaMasterToolStripMenuItem
            // 
            this.kelolaMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterMesinToolStripMenuItem,
            this.masterBarangToolStripMenuItem,
            this.masterJasaToolStripMenuItem,
            this.masterMitraToolStripMenuItem});
            this.kelolaMasterToolStripMenuItem.Name = "kelolaMasterToolStripMenuItem";
            this.kelolaMasterToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.kelolaMasterToolStripMenuItem.Text = "Kelola Master";
            // 
            // masterMesinToolStripMenuItem
            // 
            this.masterMesinToolStripMenuItem.Name = "masterMesinToolStripMenuItem";
            this.masterMesinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masterMesinToolStripMenuItem.Text = "Master Mesin";
            this.masterMesinToolStripMenuItem.Click += new System.EventHandler(this.masterMesinToolStripMenuItem_Click);
            // 
            // masterBarangToolStripMenuItem
            // 
            this.masterBarangToolStripMenuItem.Name = "masterBarangToolStripMenuItem";
            this.masterBarangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masterBarangToolStripMenuItem.Text = "Master Barang";
            this.masterBarangToolStripMenuItem.Click += new System.EventHandler(this.masterBarangToolStripMenuItem_Click);
            // 
            // masterJasaToolStripMenuItem
            // 
            this.masterJasaToolStripMenuItem.Name = "masterJasaToolStripMenuItem";
            this.masterJasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masterJasaToolStripMenuItem.Text = "Master Jasa";
            this.masterJasaToolStripMenuItem.Click += new System.EventHandler(this.masterJasaToolStripMenuItem_Click);
            // 
            // masterMitraToolStripMenuItem
            // 
            this.masterMitraToolStripMenuItem.Name = "masterMitraToolStripMenuItem";
            this.masterMitraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masterMitraToolStripMenuItem.Text = "Master Mitra";
            this.masterMitraToolStripMenuItem.Click += new System.EventHandler(this.masterMitraToolStripMenuItem_Click);
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatPenawaranToolStripMenuItem,
            this.buatPenawaranToolStripMenuItem});
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.penjualanToolStripMenuItem.Text = "Penawaran";
            // 
            // lihatPenawaranToolStripMenuItem
            // 
            this.lihatPenawaranToolStripMenuItem.Name = "lihatPenawaranToolStripMenuItem";
            this.lihatPenawaranToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lihatPenawaranToolStripMenuItem.Text = "Lihat Penawaran";
            this.lihatPenawaranToolStripMenuItem.Click += new System.EventHandler(this.lihatPenawaranToolStripMenuItem_Click_1);
            // 
            // buatPenawaranToolStripMenuItem
            // 
            this.buatPenawaranToolStripMenuItem.Name = "buatPenawaranToolStripMenuItem";
            this.buatPenawaranToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buatPenawaranToolStripMenuItem.Text = "Buat Penawaran";
            this.buatPenawaranToolStripMenuItem.Click += new System.EventHandler(this.buatPenawaranToolStripMenuItem_Click_1);
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kelolaMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMesinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatPenawaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buatPenawaranToolStripMenuItem;
    }
}

