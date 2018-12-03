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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void uxOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(uxOpenDialog.FileName))
                    {
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Bad File"); }
            uxLocalPath.Text = uxOpenDialog.FileName;
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

    }
}
