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
    public partial class FRM_BACKUP : Form
    {

        SqlConnection con = new SqlConnection("Server=DESKTOP-KM1EAAM; Database=POS_DB; Integrated Security=true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileNameBU.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void btn_Close_backup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeBackup_Click(object sender, EventArgs e)
        {

            if(txtFileNameBU.Text == string.Empty)
            {
                MessageBox.Show("قم بتحديد مجلد الحفظ أولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string fileName = txtFileNameBU.Text +
                    "\\PSO_DB" + DateTime.Now.ToShortDateString().Replace('/', '-')
                    + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQuery = "Backup Database POS_DB to Disk='" + fileName + ".bak'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم إنشاء النسخة الإحتياطية بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileNameBU.Clear();
            }


        }
    }
}
