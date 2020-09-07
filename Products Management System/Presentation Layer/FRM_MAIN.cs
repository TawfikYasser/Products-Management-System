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
    public partial class FRM_MAIN : Form
    {

        //Single Instance
        private static FRM_MAIN frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }

        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }

            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = false;
            this.إستعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem.Enabled = false;

        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void إضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void إضافةعمليةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_ORDERS frm = new Presentation_Layer.FRM_ORDERS();
            frm.ShowDialog();
        }

        private void إدارةالمبيعاتوالتقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_ORDERS_LIST frm = new Presentation_Layer.FRM_ORDERS_LIST();
            frm.ShowDialog();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_ADD_USER frm = new Presentation_Layer.FRM_ADD_USER();
            frm.ShowDialog();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_USERS_LIST frm = new Presentation_Layer.FRM_USERS_LIST();
            frm.ShowDialog();
        }

        private void إنشاءنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_BACKUP frm = new Presentation_Layer.FRM_BACKUP();
            frm.ShowDialog();
        }

        private void إستعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FRM_RESTORE frm = new Presentation_Layer.FRM_RESTORE();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = false;
            this.إستعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem.Enabled = false;
            this.تسجيلالدخولToolStripMenuItem.Enabled = true;
        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //System.Diagnostics.Process.Start("https://www.linkedin.com/in/tawfikyasser/");

    }
}
