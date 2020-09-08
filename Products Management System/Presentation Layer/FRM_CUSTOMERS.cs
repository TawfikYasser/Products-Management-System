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
    public partial class FRM_CUSTOMERS : Form
    {

        Business_Layer.CLS_CUSTOMERS cust = new Business_Layer.CLS_CUSTOMERS();
        int ID;
        int Position;

        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
            dgList.Columns[0].Visible = false;
            dgList.Columns[5].Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {


            try
            {


                if(txtFirstName.Text == string.Empty ||
                    txtLastName.Text == string.Empty ||
                    txtTel.Text == string.Empty ||
                    txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("تأكد من ملئ جميع البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    byte[] picture;
                    if (pbox.Image == null)
                    {

                        picture = new byte[0];
                        cust.ADD_CUSTOMERS(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "without_image");
                        MessageBox.Show("تم إضافة العميل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
                        dgList.Refresh();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtTel.Clear();
                        txtEmail.Clear();
                        pbox.Image = null;
                        txtFirstName.Focus();

                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        pbox.Image.Save(ms, pbox.Image.RawFormat);
                        picture = ms.ToArray();
                        cust.ADD_CUSTOMERS(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "with_image");
                        MessageBox.Show("تم إضافة العميل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
                        dgList.Refresh();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtTel.Clear();
                        txtEmail.Clear();
                        pbox.Image = null;
                        txtFirstName.Focus();

                    }
                }


            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
            }




        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.JPG; *.PNG; *.GIF; *.BMP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            pbox.Image = null;
            txtFirstName.Focus();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void dgList_DoubleClick(object sender, EventArgs e)
        {


            try
            {
                pbox.Image = null;
                ID = Convert.ToInt32(dgList.CurrentRow.Cells[0].Value);
                this.txtFirstName.Text = dgList.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = dgList.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = dgList.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = dgList.CurrentRow.Cells[4].Value.ToString();
                byte[] Picture = (byte[])dgList.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(ID == 0)
            {
                MessageBox.Show("قم بتحديد عميل أولا بالضغط مرتين عليه");
                return;
            }

            try
            {
                byte[] picture;
                if (pbox.Image == null)
                {

                    picture = new byte[0];
                    cust.EDIT_CUSTOMERS(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "without_image",ID);
                    MessageBox.Show("تم التعديل بنجاح!");
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture = ms.ToArray();
                    cust.EDIT_CUSTOMERS(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "with_image",ID);
                    MessageBox.Show("تم التعديل بنجاح!");
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();

                }

            }
            catch
            {
                return;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("قم بتحديد عميل أولا بالضغط مرتين عليه","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
         
                if (MessageBox.Show("هل تريد فعلا حذف هذا العميل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cust.DELETE_CUSTOMERS(ID);
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtTel.Clear();
                txtEmail.Clear();
                pbox.Image = null;
                txtFirstName.Focus();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                MessageBox.Show("تم حذف العميل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = cust.SEARCH_CUSTOMER(txtSearch.Text);
            this.dgList.DataSource = Dt;
        }


        void Navigate(int Index)
        {

            try
            {
                pbox.Image = null;
                DataRowCollection DRC = cust.GET_ALL_CUSTOMERS().Rows;
                ID = Convert.ToInt32(DRC[Index][0]);
                txtFirstName.Text = DRC[Index][1].ToString();
                txtLastName.Text = DRC[Index][2].ToString();
                txtTel.Text = DRC[Index][3].ToString();
                txtEmail.Text = DRC[Index][4].ToString();
                byte[] Picture = (byte[])DRC[Index][5];
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Position = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
            Navigate(Position);

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (Position == 0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
           
            Position -= 1;
            Navigate(Position);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Position == cust.GET_ALL_CUSTOMERS().Rows.Count-1)
            {
                MessageBox.Show("هذا اخر عنصر");
                return;
            }

            Position += 1;
            Navigate(Position);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
