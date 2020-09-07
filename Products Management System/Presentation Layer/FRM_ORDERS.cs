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
using System.Globalization;

namespace Products_Management_System.Presentation_Layer
{
    public partial class FRM_ORDERS : Form
    {

        Business_Layer.ClS_ORDERS order = new Business_Layer.ClS_ORDERS();
        DataTable Dt = new DataTable();
        void createDataTable()
        {
            
            Dt.Columns.Add("رقم المنتج");
            Dt.Columns.Add("اسم المنتج");
            Dt.Columns.Add("سعر المنتج");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("المبلغ");
            Dt.Columns.Add("نسبة الخصم (%)");
            Dt.Columns.Add("المبلغ بعد الخصم");
            dgvProducts.DataSource = Dt;
            //Add btn col to dgv
            /*
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "اختيار منتج";
            btn.Text = "البحث";
            btn.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Insert(0, btn);
            */

        }

        void resizeDGV()
        {
            this.dgvProducts.RowHeadersWidth = 87;
            this.dgvProducts.Columns[0].Width = 116;
            this.dgvProducts.Columns[1].Width = 231;
            this.dgvProducts.Columns[2].Width = 137;
            this.dgvProducts.Columns[3].Width = 137;
            this.dgvProducts.Columns[4].Width = 137;
            this.dgvProducts.Columns[5].Width = 137;
            this.dgvProducts.Columns[6].Width = 147;
        }

        void calculateAmount()
        {
            if(txtPriceProduct.Text !=string.Empty && txtQteProduct.Text !=string.Empty)
            {
                double withoutdis = Convert.ToDouble(txtPriceProduct.Text) * Convert.ToInt32(txtQteProduct.Text);
                txtWithoutDiscountProduct.Text = withoutdis.ToString();
            }
            
            
        }

        void calculateTotal()
        {
            if (txtWithoutDiscountProduct.Text != string.Empty  && txtDiscountProduct.Text !=string.Empty 
                && txtPriceProduct.Text != string.Empty && txtQteProduct.Text !=string.Empty)
            {
                double withoutdis = Convert.ToDouble(txtPriceProduct.Text) * Convert.ToInt32(txtQteProduct.Text);
                double Discount = Convert.ToDouble(txtDiscountProduct.Text);
                double Amount = Convert.ToDouble(txtQteProduct.Text);
                double totalAmount = Amount - (Amount * (Discount / 100));
                txtWithDiscountProduct.Text = (withoutdis - (withoutdis * (Discount / 100))).ToString();
            }
        }

        void clearBoxes()
        {
            txtIdProduct.Clear();
            txtNameProduct.Clear();
            txtPriceProduct.Clear();
            txtQteProduct.Clear();
            txtWithoutDiscountProduct.Clear();
            txtDiscountProduct.Clear();
            txtWithDiscountProduct.Clear();

        }

        void clearData()
        {
            txtOrderId.Clear();
            txtDescOrder.Clear();
            txtSalesMan.Clear();
            dtorder.ResetText();
            txtCustomerId.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtEm.Clear();
            txtT.Clear();
            clearBoxes();
            Dt.Reset();
            dgvProducts.DataSource = null;
            txtSumTotals.Clear();
            pboxo.Image = null;
        }
        public FRM_ORDERS()
        {
            InitializeComponent();
            createDataTable();
            txtSalesMan.Text = Program.salesman;
            //resizeDGV();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtOrderId.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnNewOrder.Enabled = false;
            btnSaveOrder.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnPrintOrder.Enabled = true;

            //check values
            if(txtOrderId.Text == string.Empty || txtCustomerId.Text == string.Empty || 
                dgvProducts.Rows.Count<1 || txtDescOrder.Text == string.Empty)
            {
                MessageBox.Show("تحقق من جميع البيانات المطلوبة");
                return;
            }

            //إضافة معلومات الفاتورة

            order.ADD_ORDER(Convert.ToInt32(txtOrderId.Text), dtorder.Value,
                Convert.ToInt32(txtCustomerId.Text),
                txtDescOrder.Text, txtSalesMan.Text);
            //إضافة تفاصيل ومنتجات الفاتورة
            for(int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                order.ADD_ORDER_DETAILS(
                    
                    dgvProducts.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(txtOrderId.Text),
                    Convert.ToInt32(dgvProducts.Rows[i].Cells[3].Value),
                    dgvProducts.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt32(dgvProducts.Rows[i].Cells[5].Value),
                    dgvProducts.Rows[i].Cells[4].Value.ToString(),
                    dgvProducts.Rows[i].Cells[6].Value.ToString()
                    
                    );
            }

            btnNewOrder.Enabled = true;
            btnSaveOrder.Enabled = false;
            MessageBox.Show("تم حفظ عملية البيع والفاتورة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GET customer data
            Presentation_Layer.FRM_CUSTOMERS_LIST frm = new Presentation_Layer.FRM_CUSTOMERS_LIST();
            frm.ShowDialog();
            if(frm.dgvCustomers.CurrentRow.Cells[5].Value is DBNull)
            {
                this.txtCustomerId.Text = frm.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtFName.Text = frm.dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                this.txtLName.Text = frm.dgvCustomers.CurrentRow.Cells[2].Value.ToString();
                this.txtT.Text = frm.dgvCustomers.CurrentRow.Cells[3].Value.ToString();
                this.txtEm.Text = frm.dgvCustomers.CurrentRow.Cells[4].Value.ToString();
                this.pboxo.Image = null;

            }
            else
            {
                this.txtCustomerId.Text = frm.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtFName.Text = frm.dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                this.txtLName.Text = frm.dgvCustomers.CurrentRow.Cells[2].Value.ToString();
                this.txtT.Text = frm.dgvCustomers.CurrentRow.Cells[3].Value.ToString();
                this.txtEm.Text = frm.dgvCustomers.CurrentRow.Cells[4].Value.ToString();
                byte[] custPicture = (byte[])frm.dgvCustomers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(custPicture);
                this.pboxo.Image = Image.FromStream(ms);
            }
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clearBoxes();
            Presentation_Layer.FRM_PRODUCTS_LIST frm = new Presentation_Layer.FRM_PRODUCTS_LIST();
            frm.ShowDialog();
            this.txtIdProduct.Text = frm.dgvProductsList.CurrentRow.Cells[0].Value.ToString();
            this.txtNameProduct.Text = frm.dgvProductsList.CurrentRow.Cells[1].Value.ToString();
            this.txtPriceProduct.Text = frm.dgvProductsList.CurrentRow.Cells[3].Value.ToString();
            txtQteProduct.Focus();
        }

        private void txtQteProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQteProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSepatator = Convert.ToChar(CultureInfo.CurrentCulture
                .NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=DecimalSepatator)
            {
                e.Handled = true;
            }
        }

        private void txtPriceProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtPriceProduct.Text != string.Empty)
            {
                txtQteProduct.Focus();
            }
        }

        private void txtQteProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQteProduct.Text != string.Empty)
            {
                txtDiscountProduct.Focus();
            }
        }

        private void txtPriceProduct_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotal();
        }

        private void txtQteProduct_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotal();

        }

        private void txtDiscountProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDiscountProduct_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();

        }

        private void txtDiscountProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (order.VERIFY_QTE(txtIdProduct.Text, Convert.ToInt32(txtQteProduct.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية المطلوب غير متاحة");
                    return;
                }
                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    
                    if(dgvProducts.Rows[i].Cells[0].Value.ToString() == txtIdProduct.Text)
                    {
                        MessageBox.Show("هذا المنتج موجود من قبل، يمكنك التعديل عليه.");
                        return;
                    }
                 
                }
                DataRow r = Dt.NewRow();
                r[0] = txtIdProduct.Text;
                r[1] = txtNameProduct.Text;
                r[2] = txtPriceProduct.Text;
                r[3] = txtQteProduct.Text;
                r[4] = txtWithoutDiscountProduct.Text;
                r[5] = txtDiscountProduct.Text;
                r[6] = txtWithDiscountProduct.Text;

                Dt.Rows.Add(r);
                dgvProducts.DataSource = Dt;
                clearBoxes();

                btnBrowseProdcuts.Focus();
                txtSumTotals.Text =
                    (from DataGridViewRow row in dgvProducts.Rows

                     where row.Cells[6].FormattedValue.ToString() != string.Empty

                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void dgvProducts_DockChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                txtIdProduct.Text = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtPriceProduct.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtQteProduct.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtWithoutDiscountProduct.Text = this.dgvProducts.CurrentRow.Cells[4].Value.ToString();
                txtDiscountProduct.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
                txtWithDiscountProduct.Text = this.dgvProducts.CurrentRow.Cells[6].Value.ToString();

                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                txtQteProduct.Focus();

            }
            catch
            {
                return;
            }
            
        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumTotals.Text =
                    (from DataGridViewRow row in dgvProducts.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);

            }
            catch
            {
                return;
            }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Dt.Clear();
                dgvProducts.Refresh();
            }
            catch
            {
                return;
            }
           
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            //Get the last order
            this.Cursor = Cursors.WaitCursor;
            int order_id = Convert.ToInt32(order.GET_LAST_ORDER_FOR_PRINT().Rows[0][0]);
            RPT.rpt_orders reporto = new RPT.rpt_orders();
            RPT.FRM_RPT_PRODUCTcs frm = new RPT.FRM_RPT_PRODUCTcs();
            reporto.SetDataSource(order.GET_ORDER_DETAILS(order_id));
            frm.crystalReportViewer1.ReportSource = reporto;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
