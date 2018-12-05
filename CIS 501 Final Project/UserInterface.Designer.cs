namespace CIS_501_Final_Project
{
    partial class UserInterface
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
            this.uxOpenMenu = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxReload = new System.Windows.Forms.Button();
            this.uxLabelLocal = new System.Windows.Forms.Label();
            this.uxLabelKSIS = new System.Windows.Forms.Label();
            this.uxLocalPath = new System.Windows.Forms.TextBox();
            this.uxKSISPath = new System.Windows.Forms.TextBox();
            this.uxText = new System.Windows.Forms.TextBox();
            this.uxOpenMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxOpenMenu
            // 
            this.uxOpenMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile,
            this.aboutToolStripMenuItem});
            this.uxOpenMenu.Location = new System.Drawing.Point(0, 0);
            this.uxOpenMenu.Name = "uxOpenMenu";
            this.uxOpenMenu.Size = new System.Drawing.Size(800, 24);
            this.uxOpenMenu.TabIndex = 0;
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFile,
            this.uxVerify});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 20);
            this.uxFile.Text = "File";
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.Name = "uxOpenFile";
            this.uxOpenFile.Size = new System.Drawing.Size(131, 22);
            this.uxOpenFile.Text = "Load Local";
            this.uxOpenFile.Click += new System.EventHandler(this.uxOpenFile_Click);
            // 
            // uxVerify
            // 
            this.uxVerify.Name = "uxVerify";
            this.uxVerify.Size = new System.Drawing.Size(131, 22);
            this.uxVerify.Text = "Verify";
            this.uxVerify.Click += new System.EventHandler(this.uxVerify_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "uxOpenDialog";
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(713, 1);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(75, 23);
            this.uxClear.TabIndex = 1;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxReload
            // 
            this.uxReload.Location = new System.Drawing.Point(632, 1);
            this.uxReload.Name = "uxReload";
            this.uxReload.Size = new System.Drawing.Size(75, 23);
            this.uxReload.TabIndex = 2;
            this.uxReload.Text = "Reload";
            this.uxReload.UseVisualStyleBackColor = true;
            this.uxReload.Click += new System.EventHandler(this.uxReload_Click);
            // 
            // uxLabelLocal
            // 
            this.uxLabelLocal.AutoSize = true;
            this.uxLabelLocal.Location = new System.Drawing.Point(13, 32);
            this.uxLabelLocal.Name = "uxLabelLocal";
            this.uxLabelLocal.Size = new System.Drawing.Size(33, 13);
            this.uxLabelLocal.TabIndex = 3;
            this.uxLabelLocal.Text = "Local";
            // 
            // uxLabelKSIS
            // 
            this.uxLabelKSIS.AutoSize = true;
            this.uxLabelKSIS.Location = new System.Drawing.Point(449, 32);
            this.uxLabelKSIS.Name = "uxLabelKSIS";
            this.uxLabelKSIS.Size = new System.Drawing.Size(31, 13);
            this.uxLabelKSIS.TabIndex = 4;
            this.uxLabelKSIS.Text = "KSIS";
            // 
            // uxLocalPath
            // 
            this.uxLocalPath.Location = new System.Drawing.Point(54, 29);
            this.uxLocalPath.Name = "uxLocalPath";
            this.uxLocalPath.Size = new System.Drawing.Size(283, 20);
            this.uxLocalPath.TabIndex = 5;
            // 
            // uxKSISPath
            // 
            this.uxKSISPath.Location = new System.Drawing.Point(490, 29);
            this.uxKSISPath.Name = "uxKSISPath";
            this.uxKSISPath.Size = new System.Drawing.Size(298, 20);
            this.uxKSISPath.TabIndex = 6;
            // 
            // uxText
            // 
            this.uxText.Location = new System.Drawing.Point(12, 51);
            this.uxText.Multiline = true;
            this.uxText.Name = "uxText";
            this.uxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxText.Size = new System.Drawing.Size(776, 387);
            this.uxText.TabIndex = 7;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxText);
            this.Controls.Add(this.uxKSISPath);
            this.Controls.Add(this.uxLocalPath);
            this.Controls.Add(this.uxLabelKSIS);
            this.Controls.Add(this.uxLabelLocal);
            this.Controls.Add(this.uxReload);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxOpenMenu);
            this.MainMenuStrip = this.uxOpenMenu;
            this.Name = "UserInterface";
            this.Text = "Schedule Verification Tool";
            this.uxOpenMenu.ResumeLayout(false);
            this.uxOpenMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpenFile;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Button uxReload;
        private System.Windows.Forms.Label uxLabelLocal;
        private System.Windows.Forms.Label uxLabelKSIS;
        private System.Windows.Forms.TextBox uxLocalPath;
        private System.Windows.Forms.TextBox uxKSISPath;
        private System.Windows.Forms.ToolStripMenuItem uxVerify;
        private System.Windows.Forms.TextBox uxText;
    }
}

