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

    public partial class FRM_LOGIN : Form
    {

        Business_Layer.CLS_LOGIN log = new Business_Layer.CLS_LOGIN();
           
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtPWD.Text.Length == 0)
            {
                MessageBox.Show("من فضلك قم بإدخال جميع البيانات المطلوبة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DataTable Dt = log.LOGIN(txtID.Text, txtPWD.Text);
                if (Dt.Rows.Count > 0)
                {

                    if(Dt.Rows[0][2].ToString() == "مدير")
                    {
                        FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إستعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.تسجيلالدخولToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getMainForm.تسجيلالخروجToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إعداداتالسيرفرToolStripMenuItem.Enabled = true;


                        Program.salesman = Dt.Rows[0]["FullName"].ToString();
                        FRM_MAIN.getMainForm.اسمالبائعToolStripMenuItem.Text = "البائع الحالي:  "+Dt.Rows[0]["FullName"].ToString();
                        this.Close();
                    }
                    else if(Dt.Rows[0][2].ToString() == "عادي")
                    {
                        FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إستعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.تسجيلالدخولToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getMainForm.تسجيلالخروجToolStripMenuItem.Enabled = true;

                        Program.salesman = Dt.Rows[0]["FullName"].ToString();
                        FRM_MAIN.getMainForm.اسمالبائعToolStripMenuItem.Text = "البائع الحالي:  " + Dt.Rows[0]["FullName"].ToString();

                        this.Close();
                    }

                   
                }
                else
                {
                    MessageBox.Show("قم بالتحقق من اسم المستخدم وكلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
