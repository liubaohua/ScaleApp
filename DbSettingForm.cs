using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Print
{
    public partial class DbSettingForm : Form
    {
        public DbSettingForm()
        {
            InitializeComponent();
        }
        private bool isNull(string str)
        {
            return str == null || str.Trim().Length==0;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (isNull(getIP())|| isNull(getPassword()) || isNull(getIP()) || isNull(getDatabasename()))
            {
                MessageBox.Show("信息请填写完整");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        public String getIP()
        {
            return tbIP.Text;
        }

        public String getUser()
        {
            return tbUser.Text;
        }
        
        public String getPassword()
        {
            return tbPassword.Text;
        }
        public String getDatabasename()
        {
            return tbDatabaseName.Text;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
