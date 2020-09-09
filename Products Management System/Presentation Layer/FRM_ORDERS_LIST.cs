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
    public partial class FRM_ORDERS_LIST : Form
    {

        Business_Layer.ClS_ORDERS order = new Business_Layer.ClS_ORDERS();

        public FRM_ORDERS_LIST()
        {
            InitializeComponent();
            this.dvbOrders.DataSource = order.SEARCH_ORDERS("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnPrintOrdersList_Click(object sender, EventArgs e)
        {
            //Get the last order
            this.Cursor = Cursors.WaitCursor;
            int order_id =Convert.ToInt32(dvbOrders.CurrentRow.Cells[0].Value);
            RPT.rpt_orders reporto = new RPT.rpt_orders();
            RPT.FRM_RPT_PRODUCTcs frm = new RPT.FRM_RPT_PRODUCTcs();
            reporto.Refresh();
            reporto.SetDataSource(order.GET_ORDER_DETAILS(order_id));
            frm.crystalReportViewer1.ReportSource = reporto;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void txtSearchAllOrders_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dvbOrders.DataSource = order.SEARCH_ORDERS(txtSearchAllOrders.Text);
            }
            catch
            {
                return;
            }
        }

        private void dvbOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
