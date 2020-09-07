namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_ORDERS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtorder = new System.Windows.Forms.DateTimePicker();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.txtDescOrder = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pboxo = new System.Windows.Forms.PictureBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWithDiscountProduct = new System.Windows.Forms.TextBox();
            this.txtDiscountProduct = new System.Windows.Forms.TextBox();
            this.txtWithoutDiscountProduct = new System.Windows.Forms.TextBox();
            this.txtQteProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSumTotals = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالسطرالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrowseProdcuts = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtorder);
            this.groupBox1.Controls.Add(this.txtSalesMan);
            this.groupBox1.Controls.Add(this.txtDescOrder);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   بيانات الفاتورة   ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtorder
            // 
            this.dtorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtorder.Location = new System.Drawing.Point(112, 185);
            this.dtorder.Name = "dtorder";
            this.dtorder.Size = new System.Drawing.Size(317, 30);
            this.dtorder.TabIndex = 2;
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesMan.Location = new System.Drawing.Point(112, 230);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(319, 30);
            this.txtSalesMan.TabIndex = 3;
            // 
            // txtDescOrder
            // 
            this.txtDescOrder.Location = new System.Drawing.Point(112, 85);
            this.txtDescOrder.Multiline = true;
            this.txtDescOrder.Name = "txtDescOrder";
            this.txtDescOrder.Size = new System.Drawing.Size(317, 81);
            this.txtDescOrder.TabIndex = 1;
            // 
            // txtOrderId
            // 
            this.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(112, 40);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(319, 30);
            this.txtOrderId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم البائع";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ البيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pboxo);
            this.groupBox2.Controls.Add(this.txtEm);
            this.groupBox2.Controls.Add(this.txtT);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.txtCustomerId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(578, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   بيانات العميل   ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pboxo
            // 
            this.pboxo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxo.Location = new System.Drawing.Point(7, 26);
            this.pboxo.Name = "pboxo";
            this.pboxo.Size = new System.Drawing.Size(180, 235);
            this.pboxo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxo.TabIndex = 6;
            this.pboxo.TabStop = false;
            // 
            // txtEm
            // 
            this.txtEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm.Location = new System.Drawing.Point(217, 231);
            this.txtEm.Name = "txtEm";
            this.txtEm.ReadOnly = true;
            this.txtEm.Size = new System.Drawing.Size(235, 30);
            this.txtEm.TabIndex = 5;
            // 
            // txtT
            // 
            this.txtT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.Location = new System.Drawing.Point(217, 183);
            this.txtT.Name = "txtT";
            this.txtT.ReadOnly = true;
            this.txtT.Size = new System.Drawing.Size(235, 30);
            this.txtT.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(217, 136);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(235, 30);
            this.txtLName.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(217, 88);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(235, 30);
            this.txtFName.TabIndex = 5;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(319, 44);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(135, 30);
            this.txtCustomerId.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(475, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "البريد الإلكتروني";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "رقم الهاتف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "الاسم الاخير";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "الاسم الاول";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWithDiscountProduct);
            this.groupBox3.Controls.Add(this.txtDiscountProduct);
            this.groupBox3.Controls.Add(this.txtWithoutDiscountProduct);
            this.groupBox3.Controls.Add(this.txtQteProduct);
            this.groupBox3.Controls.Add(this.txtPriceProduct);
            this.groupBox3.Controls.Add(this.txtNameProduct);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtIdProduct);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtSumTotals);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.Controls.Add(this.btnBrowseProdcuts);
            this.groupBox3.Location = new System.Drawing.Point(11, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1168, 356);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "   المنتجات   ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtWithDiscountProduct
            // 
            this.txtWithDiscountProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtWithDiscountProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWithDiscountProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithDiscountProduct.Location = new System.Drawing.Point(7, 64);
            this.txtWithDiscountProduct.Name = "txtWithDiscountProduct";
            this.txtWithDiscountProduct.ReadOnly = true;
            this.txtWithDiscountProduct.Size = new System.Drawing.Size(182, 30);
            this.txtWithDiscountProduct.TabIndex = 7;
            this.txtWithDiscountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWithDiscountProduct.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtDiscountProduct
            // 
            this.txtDiscountProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDiscountProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountProduct.Location = new System.Drawing.Point(188, 64);
            this.txtDiscountProduct.MaxLength = 3;
            this.txtDiscountProduct.Name = "txtDiscountProduct";
            this.txtDiscountProduct.Size = new System.Drawing.Size(137, 30);
            this.txtDiscountProduct.TabIndex = 7;
            this.txtDiscountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscountProduct.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.txtDiscountProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscountProduct_KeyDown);
            this.txtDiscountProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountProduct_KeyPress);
            this.txtDiscountProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscountProduct_KeyUp);
            // 
            // txtWithoutDiscountProduct
            // 
            this.txtWithoutDiscountProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtWithoutDiscountProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWithoutDiscountProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithoutDiscountProduct.Location = new System.Drawing.Point(324, 64);
            this.txtWithoutDiscountProduct.Name = "txtWithoutDiscountProduct";
            this.txtWithoutDiscountProduct.ReadOnly = true;
            this.txtWithoutDiscountProduct.Size = new System.Drawing.Size(137, 30);
            this.txtWithoutDiscountProduct.TabIndex = 7;
            this.txtWithoutDiscountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWithoutDiscountProduct.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtQteProduct
            // 
            this.txtQteProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQteProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQteProduct.Location = new System.Drawing.Point(460, 64);
            this.txtQteProduct.MaxLength = 8;
            this.txtQteProduct.Name = "txtQteProduct";
            this.txtQteProduct.Size = new System.Drawing.Size(137, 30);
            this.txtQteProduct.TabIndex = 7;
            this.txtQteProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQteProduct.TextChanged += new System.EventHandler(this.txtQteProduct_TextChanged);
            this.txtQteProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQteProduct_KeyDown);
            this.txtQteProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQteProduct_KeyPress);
            this.txtQteProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQteProduct_KeyUp);
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceProduct.Location = new System.Drawing.Point(596, 64);
            this.txtPriceProduct.MaxLength = 8;
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(137, 30);
            this.txtPriceProduct.TabIndex = 7;
            this.txtPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPriceProduct_KeyDown);
            this.txtPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceProduct_KeyPress);
            this.txtPriceProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPriceProduct_KeyUp);
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(732, 64);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(231, 30);
            this.txtNameProduct.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(7, 31);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5);
            this.label17.Size = new System.Drawing.Size(182, 34);
            this.label17.TabIndex = 6;
            this.label17.Text = "المبلغ بعد الخصم";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(188, 31);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5);
            this.label16.Size = new System.Drawing.Size(137, 34);
            this.label16.TabIndex = 6;
            this.label16.Text = "الخصم (%)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label15_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(324, 31);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5);
            this.label15.Size = new System.Drawing.Size(137, 34);
            this.label15.TabIndex = 6;
            this.label15.Text = "المبلغ بدون خصم";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(460, 31);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(5);
            this.label14.Size = new System.Drawing.Size(137, 34);
            this.label14.TabIndex = 6;
            this.label14.Text = "الكمية";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(596, 31);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(137, 34);
            this.label13.TabIndex = 6;
            this.label13.Text = "الثمن";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(732, 31);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(231, 34);
            this.label12.TabIndex = 6;
            this.label12.Text = "اسم المنتج";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(1075, 31);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(5);
            this.label18.Size = new System.Drawing.Size(87, 34);
            this.label18.TabIndex = 6;
            this.label18.Text = "اختيار منتج";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIdProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduct.Location = new System.Drawing.Point(962, 64);
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.ReadOnly = true;
            this.txtIdProduct.Size = new System.Drawing.Size(114, 30);
            this.txtIdProduct.TabIndex = 7;
            this.txtIdProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(962, 31);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(116, 34);
            this.label11.TabIndex = 6;
            this.label11.Text = "رقم المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSumTotals
            // 
            this.txtSumTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumTotals.Location = new System.Drawing.Point(6, 320);
            this.txtSumTotals.Name = "txtSumTotals";
            this.txtSumTotals.ReadOnly = true;
            this.txtSumTotals.Size = new System.Drawing.Size(130, 30);
            this.txtSumTotals.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "المبلغ الإجمالي";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProducts.Location = new System.Drawing.Point(7, 102);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1155, 212);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProducts_RowsRemoved);
            this.dgvProducts.DockChanged += new System.EventHandler(this.dgvProducts_DockChanged);
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفالسطرالحاليToolStripMenuItem,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 82);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // حذفالسطرالحاليToolStripMenuItem
            // 
            this.حذفالسطرالحاليToolStripMenuItem.Name = "حذفالسطرالحاليToolStripMenuItem";
            this.حذفالسطرالحاليToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.حذفالسطرالحاليToolStripMenuItem.Text = "حذف السطر الحالي";
            this.حذفالسطرالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالحاليToolStripMenuItem_Click);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // btnBrowseProdcuts
            // 
            this.btnBrowseProdcuts.Location = new System.Drawing.Point(1075, 64);
            this.btnBrowseProdcuts.Name = "btnBrowseProdcuts";
            this.btnBrowseProdcuts.Size = new System.Drawing.Size(87, 32);
            this.btnBrowseProdcuts.TabIndex = 0;
            this.btnBrowseProdcuts.Text = "...";
            this.btnBrowseProdcuts.UseVisualStyleBackColor = true;
            this.btnBrowseProdcuts.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(215, 668);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(185, 38);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "عملية بيع جديدة";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Enabled = false;
            this.btnSaveOrder.Location = new System.Drawing.Point(407, 668);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(185, 38);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "حفظ عملية البيع";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(599, 668);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(185, 38);
            this.btnPrintOrder.TabIndex = 2;
            this.btnPrintOrder.Text = "طباعة اخر فاتورة";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(791, 668);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 38);
            this.button6.TabIndex = 3;
            this.button6.Text = "خروج";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 719);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المبيعات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescOrder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesMan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pboxo;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSumTotals;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dtorder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWithoutDiscountProduct;
        private System.Windows.Forms.TextBox txtQteProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWithDiscountProduct;
        private System.Windows.Forms.TextBox txtDiscountProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBrowseProdcuts;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdProduct;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالحاليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
    }
}