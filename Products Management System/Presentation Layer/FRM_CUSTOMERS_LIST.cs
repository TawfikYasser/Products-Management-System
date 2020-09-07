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


    public partial class FRM_CUSTOMERS_LIST : Form
    {

        Business_Layer.CLS_CUSTOMERS custlist = new Business_Layer.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.dgvCustomers.DataSource = custlist.GET_ALL_CUSTOMERS();
            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Columns[5].Visible = false;
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
