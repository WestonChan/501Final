using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIS_501_Final_Project
{
    public partial class UserInterface : Form
    {
        Presenter p;
        public UserInterface()
        {
            InitializeComponent();
            p = new Presenter(this);
        }

        private void uxOpenFile_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                p.LoadLocal(uxOpenDialog.FileName);
            }

        }

        private void uxVerify_Click(object sender, EventArgs e)
        {
            if(uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                p.Verify(uxOpenDialog.FileName);
            }
        }

        private void uxReload_Click(object sender, EventArgs e)
        {
            string local = uxLocalPath.Text;
            string ksis = uxKsisPath.Text;
            p.Reload(local, ksis);
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            p.Clear();
        }
        public void ShowUser(string text)
        {
            MessageBox.Show(text);
        }
        public void ShowLocalFilename(string path)
        {
            uxLocalPath.Text = path;
        }
        public void ShowKsisFilename(string path)
        {
            uxKsisPath.Text = path;
        }

        public void ShowReload()
        {
            uxText.Text = uxText.Text + "\nSuccessfully reloaded files.";
        }

        public void ClearUI()
        {
            uxLocalPath.Text = "";
            uxKsisPath.Text = "";
            uxText.Text = "";
        }

        public void DisplayVersions(string version, string versionDate)
        {
            uxText.Text = uxText.Text + "\nCSV Version: " + version
                + "\nCSV Version Date: " + versionDate;
        }

    }
}
