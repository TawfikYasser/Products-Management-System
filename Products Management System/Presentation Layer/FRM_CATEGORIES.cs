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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Products_Management_System.Presentation_Layer
{
    public partial class FRM_CATEGORIES : Form
    {

        SqlConnection SqlConnection = new SqlConnection("Server=DESKTOP-KM1EAAM; Database=POS_DB; Integrated Security=true");
        SqlDataAdapter da;//to send and get data from and to databases (server)
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;

        public FRM_CATEGORIES()
        {
            InitializeComponent();
           
            da = new SqlDataAdapter("select id_cat as 'رقم الصنف', DESCRIPTION_CAT as 'اسم الصنف' from CATEGORIES", SqlConnection);
            da.Fill(dt);
            dgList.DataSource = dt;

            txtID.DataBindings.Add("text", dt, "رقم الصنف");
            txtDesc.DataBindings.Add("text", dt, "اسم الصنف");

            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position+1) + " / " + bmb.Count;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0])+1;
            txtID.Text = id.ToString();
            txtDesc.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDesc.Text == string.Empty)
            {
                MessageBox.Show("قم بكتابة اسم الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                dgList.DataSource = dt;
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
                MessageBox.Show("تم إضافة الصنف الجديد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذا الصنف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                dgList.DataSource = dt;
                lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
                MessageBox.Show("تم حذف الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            MessageBox.Show("تم تعديل الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnrintCurrent_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_category my_report_single_cat = new RPT.rpt_single_category();
            RPT.FRM_RPT_PRODUCTcs mForm = new RPT.FRM_RPT_PRODUCTcs();
            my_report_single_cat.Refresh();
            my_report_single_cat.SetParameterValue("@ID", Convert.ToInt32(txtID.Text));
            mForm.crystalReportViewer1.ReportSource = my_report_single_cat;
            mForm.ShowDialog();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_categories my_report_all_cat = new RPT.rpt_all_categories();
            RPT.FRM_RPT_PRODUCTcs mForm = new RPT.FRM_RPT_PRODUCTcs();
            my_report_all_cat.Refresh();
            mForm.crystalReportViewer1.ReportSource = my_report_all_cat;
            mForm.ShowDialog();
        }

        private void exportToPdfAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_categories myrep_all_categories_to_pdf = new RPT.rpt_all_categories();
            //Create export options
            ExportOptions export = new ExportOptions();
            //Create object to save destination
            DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            // set destination name
            dfOptions.DiskFileName = @"T:\FCAI\My Projects\DB\CategoriesList.pdf";
            export = myrep_all_categories_to_pdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfOptions;
            myrep_all_categories_to_pdf.Refresh();
            myrep_all_categories_to_pdf.Export();
            MessageBox.Show("تم تصدير جميع الاصناف الى ملف PDF.", "تصدير PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exportToPdfCurrent_Click(object sender, EventArgs e)
        {

            RPT.rpt_single_category myrep_single_categories_to_pdf = new RPT.rpt_single_category();
            //Create export options
            ExportOptions export = new ExportOptions();
            //Create object to save destination
            DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            // set destination name
            dfOptions.DiskFileName = @"T:\FCAI\My Projects\DB\CategoriesListWithProducts.pdf";
            export = myrep_single_categories_to_pdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfOptions;
            myrep_single_categories_to_pdf.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            myrep_single_categories_to_pdf.Export();
            MessageBox.Show("تم تصدير جميع الاصناف ومنتجاتهم الى ملف PDF.", "تصدير PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
