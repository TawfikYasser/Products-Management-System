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
    public partial class FRM_USERS_LIST : Form
    {

        Business_Layer.CLS_LOGIN login = new Business_Layer.CLS_LOGIN();
        public FRM_USERS_LIST()
        {
            InitializeComponent();
            this.dgvUsers.DataSource = login.SEARCH_USERS("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintOrdersList_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_ADD_USER frm = new Presentation_Layer.FRM_ADD_USER();
            frm.btnSaveU.Text = "حفظ";
            frm.ShowDialog();
            this.dgvUsers.DataSource = login.SEARCH_USERS("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_ADD_USER frm = new Presentation_Layer.FRM_ADD_USER();
            frm.tUserName.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            frm.tFullName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            frm.tPass.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            frm.comboType.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            frm.tCPass.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            frm.btnSaveU.Text = "تأكيد التعديل";
            frm.tUserName.Enabled = false;
            frm.ShowDialog();
            this.dgvUsers.DataSource = login.SEARCH_USERS("");

        }

        private void txtSearchAllUsers_TextChanged(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = login.SEARCH_USERS(txtSearchAllUsers.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت متأكد من حذف المستخدم؟","حذف المستخدم",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Business_Layer.CLS_LOGIN login = new Business_Layer.CLS_LOGIN();
                login.DELETE_USER(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح");
                this.dgvUsers.DataSource = login.SEARCH_USERS("");

            }
        }
    }
}
