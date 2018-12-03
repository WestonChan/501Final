namespace CIS_501_Final_Project
{
    partial class Form1
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
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxReload = new System.Windows.Forms.Button();
            this.uxLabelLocal = new System.Windows.Forms.Label();
            this.uxLabelKSIS = new System.Windows.Forms.Label();
            this.uxLocalPath = new System.Windows.Forms.TextBox();
            this.uxKSISPath = new System.Windows.Forms.TextBox();
            this.uxText = new System.Windows.Forms.TextBox();
            this.verifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "uxMenuStrip";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.verifyToolStripMenuItem});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 20);
            this.uxFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Load Local";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(713, 1);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(75, 23);
            this.uxClear.TabIndex = 1;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            // 
            // uxReload
            // 
            this.uxReload.Location = new System.Drawing.Point(632, 1);
            this.uxReload.Name = "uxReload";
            this.uxReload.Size = new System.Drawing.Size(75, 23);
            this.uxReload.TabIndex = 2;
            this.uxReload.Text = "Reload";
            this.uxReload.UseVisualStyleBackColor = true;
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
            // verifyToolStripMenuItem
            // 
            this.verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            this.verifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verifyToolStripMenuItem.Text = "Verify";
            // 
            // Form1
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Button uxReload;
        private System.Windows.Forms.Label uxLabelLocal;
        private System.Windows.Forms.Label uxLabelKSIS;
        private System.Windows.Forms.TextBox uxLocalPath;
        private System.Windows.Forms.TextBox uxKSISPath;
        private System.Windows.Forms.ToolStripMenuItem verifyToolStripMenuItem;
        private System.Windows.Forms.TextBox uxText;
    }
}

