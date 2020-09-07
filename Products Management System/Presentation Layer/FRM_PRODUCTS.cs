using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Products_Management_System.Presentation_Layer
{
    public partial class FRM_PRODUCTS : Form
    {


        private static FRM_PRODUCTS frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;

            }
        }




        Business_Layer.CLS_PRODUCTS prd = new Business_Layer.CLS_PRODUCTS();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }

            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            RPT.rpt_prd_single my_report = new RPT.rpt_prd_single();
            my_report.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCTcs myForm = new RPT.FRM_RPT_PRODUCTcs();
            myForm.crystalReportViewer1.ReportSource = my_report;
            myForm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();

            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SEARCH_PRODUCT(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد فعلا حذف هذا المنتج؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                prd.DELETE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();

                MessageBox.Show("تم حذف المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDesc.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQTE.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPRICE.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تعديل المنتج: " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOK.Text = "تحديث";
            frm.state = "update";
            frm.txtRef.Enabled = false;
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_products my_report_all = new RPT.rpt_all_products();
            RPT.FRM_RPT_PRODUCTcs mForm = new RPT.FRM_RPT_PRODUCTcs();
            mForm.crystalReportViewer1.ReportSource = my_report_all;
            mForm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_products myrep_to_excel = new RPT.rpt_all_products();
            //Create export options
            ExportOptions export = new ExportOptions();
            //Create object to save destination
            DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();
            ExcelFormatOptions eFormat = new ExcelFormatOptions();
            // set destination name
            dfOptions.DiskFileName = @"T:\FCAI\My Projects\DB\ProductsList.xls";
            export = myrep_to_excel.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = eFormat;
            export.ExportDestinationOptions = dfOptions;
            myrep_to_excel.Export();
            MessageBox.Show("تم تصدير جميع المنتجات الى ملف اكسيل.","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
