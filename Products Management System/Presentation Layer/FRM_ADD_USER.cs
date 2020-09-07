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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void btnSaveU_Click(object sender, EventArgs e)
        {
            if (tUserName.Text != string.Empty || tFullName.Text != string.Empty
            || tPass.Text != string.Empty || tCPass.Text != string.Empty)
            {


                if (tPass.Text == tCPass.Text)
                {
                    if (btnSaveU.Text == "حفظ")
                    {
                        Business_Layer.CLS_LOGIN user = new Business_Layer.CLS_LOGIN();
                        user.ADD_USER(tUserName.Text, tPass.Text, tFullName.Text, comboType.Text);
                        MessageBox.Show("تم حفظ المستخدم","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else if (btnSaveU.Text == "تأكيد التعديل")
                    {

                        Business_Layer.CLS_LOGIN user = new Business_Layer.CLS_LOGIN();
                        user.EDIT_USER(tUserName.Text, tPass.Text, tFullName.Text, comboType.Text);
                        MessageBox.Show("تم تعديل المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("تأكد من تطابق كلمتي المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                MessageBox.Show("تأكد من ملئ جميع البيانات","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }



            tUserName.Clear();
            tCPass.Clear();
            tFullName.Clear();
            tPass.Clear();
            tUserName.Focus();
        }

        private void btnCloseUF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
