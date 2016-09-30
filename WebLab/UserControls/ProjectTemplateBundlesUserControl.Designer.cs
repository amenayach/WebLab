namespace WebLab.UserControls
{
    partial class ProjectTemplateBundlesUserControl
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
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateInstanceTo = new System.Windows.Forms.Button();
            this.tbInstanceName = new System.Windows.Forms.TextBox();
            this.lblInstanceName = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblAvailableBundles = new System.Windows.Forms.Label();
            this.lstSelectedBundles = new System.Windows.Forms.ListBox();
            this.tbSearchAvailableBundles = new System.Windows.Forms.TextBox();
            this.lstAvailableBundles = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplateName.Location = new System.Drawing.Point(8, 14);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(117, 23);
            this.lblTemplateName.TabIndex = 0;
            this.lblTemplateName.Text = "Template name";
            // 
            // tbTemplateName
            // 
            this.tbTemplateName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemplateName.Location = new System.Drawing.Point(131, 11);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new System.Drawing.Size(335, 30);
            this.tbTemplateName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(471, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(560, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreateInstanceTo
            // 
            this.btnCreateInstanceTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnCreateInstanceTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInstanceTo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInstanceTo.ForeColor = System.Drawing.Color.White;
            this.btnCreateInstanceTo.Location = new System.Drawing.Point(561, 48);
            this.btnCreateInstanceTo.Name = "btnCreateInstanceTo";
            this.btnCreateInstanceTo.Size = new System.Drawing.Size(83, 34);
            this.btnCreateInstanceTo.TabIndex = 4;
            this.btnCreateInstanceTo.Text = "&Create Instance";
            this.btnCreateInstanceTo.UseVisualStyleBackColor = false;
            // 
            // tbInstanceName
            // 
            this.tbInstanceName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstanceName.Location = new System.Drawing.Point(131, 52);
            this.tbInstanceName.Name = "tbInstanceName";
            this.tbInstanceName.Size = new System.Drawing.Size(335, 30);
            this.tbInstanceName.TabIndex = 6;
            // 
            // lblInstanceName
            // 
            this.lblInstanceName.AutoSize = true;
            this.lblInstanceName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstanceName.Location = new System.Drawing.Point(8, 55);
            this.lblInstanceName.Name = "lblInstanceName";
            this.lblInstanceName.Size = new System.Drawing.Size(113, 23);
            this.lblInstanceName.TabIndex = 5;
            this.lblInstanceName.Text = "Instance name";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(472, 49);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 34);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbInstanceName);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.lblTemplateName);
            this.splitContainer1.Panel1.Controls.Add(this.tbTemplateName);
            this.splitContainer1.Panel1.Controls.Add(this.lblInstanceName);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateInstanceTo);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstAvailableBundles);
            this.splitContainer1.Panel2.Controls.Add(this.lblAvailableBundles);
            this.splitContainer1.Panel2.Controls.Add(this.lstSelectedBundles);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchAvailableBundles);
            this.splitContainer1.Size = new System.Drawing.Size(892, 617);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 8;
            // 
            // lblAvailableBundles
            // 
            this.lblAvailableBundles.AutoSize = true;
            this.lblAvailableBundles.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBundles.Location = new System.Drawing.Point(8, 11);
            this.lblAvailableBundles.Name = "lblAvailableBundles";
            this.lblAvailableBundles.Size = new System.Drawing.Size(94, 23);
            this.lblAvailableBundles.TabIndex = 6;
            this.lblAvailableBundles.Text = "Bundles list";
            // 
            // lstSelectedBundles
            // 
            this.lstSelectedBundles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedBundles.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectedBundles.FormattingEnabled = true;
            this.lstSelectedBundles.ItemHeight = 23;
            this.lstSelectedBundles.Location = new System.Drawing.Point(454, 73);
            this.lstSelectedBundles.Name = "lstSelectedBundles";
            this.lstSelectedBundles.Size = new System.Drawing.Size(435, 418);
            this.lstSelectedBundles.TabIndex = 3;
            // 
            // tbSearchAvailableBundles
            // 
            this.tbSearchAvailableBundles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchAvailableBundles.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchAvailableBundles.Location = new System.Drawing.Point(3, 37);
            this.tbSearchAvailableBundles.Name = "tbSearchAvailableBundles";
            this.tbSearchAvailableBundles.Size = new System.Drawing.Size(386, 30);
            this.tbSearchAvailableBundles.TabIndex = 2;
            // 
            // lstAvailableBundles
            // 
            this.lstAvailableBundles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAvailableBundles.CheckOnClick = true;
            this.lstAvailableBundles.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lstAvailableBundles.FormattingEnabled = true;
            this.lstAvailableBundles.Location = new System.Drawing.Point(5, 73);
            this.lstAvailableBundles.Name = "lstAvailableBundles";
            this.lstAvailableBundles.Size = new System.Drawing.Size(427, 429);
            this.lstAvailableBundles.TabIndex = 7;
            this.lstAvailableBundles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstAvailableBundles_ItemCheck);
            // 
            // ProjectTemplateBundlesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProjectTemplateBundlesUserControl";
            this.Size = new System.Drawing.Size(892, 617);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.TextBox tbTemplateName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateInstanceTo;
        private System.Windows.Forms.TextBox tbInstanceName;
        private System.Windows.Forms.Label lblInstanceName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstSelectedBundles;
        private System.Windows.Forms.TextBox tbSearchAvailableBundles;
        private System.Windows.Forms.Label lblAvailableBundles;
        private System.Windows.Forms.CheckedListBox lstAvailableBundles;
    }
}
