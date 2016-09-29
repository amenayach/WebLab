namespace WebLab.UserControls
{
    partial class ProjectTemplatesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlProjectTemplates = new System.Windows.Forms.Panel();
            this.lstProjectTemplates = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlProjectTemplates.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjectTemplates
            // 
            this.pnlProjectTemplates.Controls.Add(this.lstProjectTemplates);
            this.pnlProjectTemplates.Controls.Add(this.tbSearch);
            this.pnlProjectTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectTemplates.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectTemplates.Name = "pnlProjectTemplates";
            this.pnlProjectTemplates.Size = new System.Drawing.Size(417, 673);
            this.pnlProjectTemplates.TabIndex = 1;
            // 
            // lstProjectTemplates
            // 
            this.lstProjectTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProjectTemplates.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjectTemplates.FormattingEnabled = true;
            this.lstProjectTemplates.ItemHeight = 23;
            this.lstProjectTemplates.Location = new System.Drawing.Point(3, 36);
            this.lstProjectTemplates.Name = "lstProjectTemplates";
            this.lstProjectTemplates.Size = new System.Drawing.Size(411, 625);
            this.lstProjectTemplates.TabIndex = 1;
            this.lstProjectTemplates.SelectedValueChanged += new System.EventHandler(this.lstProjectTemplates_SelectedValueChanged);
            this.lstProjectTemplates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProjectTemplates_KeyDown);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(411, 30);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // ProjectTemplatesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProjectTemplates);
            this.Name = "ProjectTemplatesUserControl";
            this.Size = new System.Drawing.Size(417, 673);
            this.Load += new System.EventHandler(this.ProjectTemplatesUserControl_Load);
            this.pnlProjectTemplates.ResumeLayout(false);
            this.pnlProjectTemplates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProjectTemplates;
        private System.Windows.Forms.ListBox lstProjectTemplates;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
