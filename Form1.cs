using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace taskmgrSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Icon ico1 = TaskMgrSwitch.Properties.Resources.task1;
        Icon ico2 = TaskMgrSwitch.Properties.Resources.tasks;
        RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
        private void button1_Click(object sender, EventArgs e)
        {
            key.SetValue("DisableTaskMgr", 0);
            Icon = ico1;
            MessageBox.Show("On", "TaskMgr Switch");
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            key.SetValue("DisableTaskMgr", 1);
            Icon = ico2;
            MessageBox.Show("Off", "TaskMgr Switch");
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
