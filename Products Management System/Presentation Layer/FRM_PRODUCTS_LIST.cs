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
    public partial class FRM_PRODUCTS_LIST : Form
    {

        Business_Layer.CLS_PRODUCTS prd = new Business_Layer.CLS_PRODUCTS();

        public FRM_PRODUCTS_LIST()
        {
            InitializeComponent();
            this.dgvProductsList.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void dgvProductsList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
