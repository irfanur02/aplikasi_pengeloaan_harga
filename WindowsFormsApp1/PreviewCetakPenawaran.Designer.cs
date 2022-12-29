namespace WindowsFormsApp1
{
    partial class PreviewCetakPenawaran
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
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CRPenawaran1 = new WindowsFormsApp1.CRPenawaran();
            this.SuspendLayout();
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = 0;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(0, 0);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.ReportSource = this.CRPenawaran1;
            this.CRViewer.ShowCloseButton = false;
            this.CRViewer.ShowCopyButton = false;
            this.CRViewer.ShowExportButton = false;
            this.CRViewer.ShowGroupTreeButton = false;
            this.CRViewer.ShowLogo = false;
            this.CRViewer.ShowParameterPanelButton = false;
            this.CRViewer.ShowRefreshButton = false;
            this.CRViewer.ShowTextSearchButton = false;
            this.CRViewer.Size = new System.Drawing.Size(707, 519);
            this.CRViewer.TabIndex = 0;
            this.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PreviewCetakPenawaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 519);
            this.Controls.Add(this.CRViewer);
            this.Name = "PreviewCetakPenawaran";
            this.Text = "PreviewCetakPenawaran";
            this.Load += new System.EventHandler(this.PreviewCetakPenawaran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private CRPenawaran CRPenawaran1;
    }
}