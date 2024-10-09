using MHF.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int used;
        RegistryKey ck = Registry.CurrentUser.OpenSubKey("Software\\MediaHuman\\Video Converter", true);
        private void loadvalues()
        {
            used = (int)ck.GetValue("FilesDone");
            fu.Text = fu.Text.Replace("x", used.ToString());
            if (used == 0)
            {
                status.Text = "Already at lowest possible value!";
                status.ForeColor = Color.Red;
                rb.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.msgtouser, "Hi!");
            loadvalues();   
        
        }

        private void rb_Click(object sender, EventArgs e)
        {
            Process.Start("taskkill", "/f /IM MHVideoConverter.exe");
            ck.SetValue("FilesDone", 0);
            used = 0;
            loadvalues();
        }

        private void inf_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This mode will make it so that you have 2+ Billion files to convert before needing to pay. Continue?", "oooo", buttons:MessageBoxButtons.YesNo) == DialogResult.Yes);
            {
                Process.Start("taskkill", "/f /IM MHVideoConverter.exe");
                ck.SetValue("FilesDone", Int32.MinValue + 6969);
                used = 0;
                loadvalues();
            }
        }
    }
}
