using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management_System.Presentation_Layer
{
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();


            txtServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            if(Properties.Settings.Default.Mode == "SQL")
            {
                rbSQL.Checked = true;
                txtIdS.Text = Properties.Settings.Default.ID;
                txtPassS.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtIdS.Clear();
                txtIdS.ReadOnly = true;
                txtPassS.ReadOnly = true;
            }
            


        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Mode = rbSQL.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.ID = txtIdS.Text;
            Properties.Settings.Default.Password = txtPassS.Text;
            Properties.Settings.Default.Save();
        }

        private void FRM_CONFIG_Load(object sender, EventArgs e)
        {

        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtIdS.ReadOnly = false;
            txtPassS.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtIdS.ReadOnly = true;
            txtPassS.ReadOnly = true;
        }
    }
}
