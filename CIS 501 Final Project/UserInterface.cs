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
                p.loadLocal(uxOpenDialog.FileName);
            }

        }

        private void uxVerify_Click(object sender, EventArgs e)
        {

        }

        private void uxReload_Click(object sender, EventArgs e)
        {

        }

        private void uxClear_Click(object sender, EventArgs e)
        {

        }
        public void ShowUser(string text)
        {
            MessageBox.Show(text);
        }
        public void ShowLocalFilename(string filename)
        {
            uxLocalPath.Text = filename;
        }
        public void ShowKsisFilename(string filename)
        {
            uxLocalPath.Text = filename;
        }
    }
}
