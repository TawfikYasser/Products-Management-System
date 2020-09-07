using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Products_Management_System.Presentation_Layer
{
    public partial class FRM_RESTORE : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-KM1EAAM; Database=master; Integrated Security=true");
        SqlCommand cmd;
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileNameRestore.Text = openFileDialog1.FileName;
            }
        }

        private void btn_Close_Restore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {

            if(txtFileNameRestore.Text == string.Empty)
            {
                MessageBox.Show("قم بإختيار ملف النسخة الإحتياطية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string strQuery = "ALTER Database POS_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database POS_DB From Disk='" + txtFileNameRestore.Text + "' WITH REPLACE";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileNameRestore.Clear();
            }

        }
    }
}
