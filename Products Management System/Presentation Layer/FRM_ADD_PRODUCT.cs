using Products_Management_System.Business_Layer;
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

namespace Products_Management_System.Presentation_Layer
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        Business_Layer.CLS_PRODUCTS prd = new Business_Layer.CLS_PRODUCTS();
        public string state = "add";
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.JPG; *.PNG; *.GIF; *.BMP";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if(cmbCategories.Text == string.Empty ||
                txtRef.Text == string.Empty || 
                txtDesc.Text == string.Empty || txtPRICE.Text == string.Empty
                || txtQTE.Text == string.Empty)
            {
                MessageBox.Show("قم بإدخال جميع البيانات المطلوبة","خطأ", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
            }
            else
            {
                if (state == "add")
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    prd.ADD_PRODUCTS(Convert.ToInt32(cmbCategories.SelectedValue),
                        txtDesc.Text, txtRef.Text, Convert.ToInt32(txtQTE.Text)
                        , txtPRICE.Text, byteImage);
                    MessageBox.Show("تم إضافة المنتج بنجاح", "تنبيه", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    prd.UPDATE_PRODCUTS(Convert.ToInt32(cmbCategories.SelectedValue),
                        txtDesc.Text, txtRef.Text, Convert.ToInt32(txtQTE.Text)
                        , txtPRICE.Text, byteImage);
                    MessageBox.Show("تم تعديل المنتج بنجاح", "تنبيه", MessageBoxButtons.OK
                         , MessageBoxIcon.Information);

                }

                FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
                txtDesc.Clear();
                txtRef.Clear();
                txtQTE.Clear();
                txtPRICE.Clear();
                cmbCategories.Focus();
            }




        }

        private void txtRef_Validated(object sender, EventArgs e)
        {



            DataTable Dt = new DataTable();
            Dt = prd.VERIFY_PRODUCT_ID(txtRef.Text);
            if(Dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا المنتج موجود مسبقاً", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtRef.Focus();
                txtRef.SelectionStart = 0;
                txtRef.SelectionLength = txtRef.TextLength;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
