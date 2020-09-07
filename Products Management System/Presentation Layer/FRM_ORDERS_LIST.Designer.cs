namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_ORDERS_LIST
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvbOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintOrdersList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearchAllOrders = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvbOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvbOrders);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 428);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   قائمة الفواتير   ";
            // 
            // dvbOrders
            // 
            this.dvbOrders.AllowUserToAddRows = false;
            this.dvbOrders.AllowUserToDeleteRows = false;
            this.dvbOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvbOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvbOrders.Location = new System.Drawing.Point(6, 21);
            this.dvbOrders.Name = "dvbOrders";
            this.dvbOrders.ReadOnly = true;
            this.dvbOrders.RowHeadersWidth = 51;
            this.dvbOrders.RowTemplate.Height = 24;
            this.dvbOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvbOrders.Size = new System.Drawing.Size(1036, 401);
            this.dvbOrders.TabIndex = 0;
            this.dvbOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvbOrders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "قم بإدخال الكلمة المراد البحث عنها:";
            // 
            // btnPrintOrdersList
            // 
            this.btnPrintOrdersList.Location = new System.Drawing.Point(387, 510);
            this.btnPrintOrdersList.Name = "btnPrintOrdersList";
            this.btnPrintOrdersList.Size = new System.Drawing.Size(142, 40);
            this.btnPrintOrdersList.TabIndex = 1;
            this.btnPrintOrdersList.Text = "طباعة";
            this.btnPrintOrdersList.UseVisualStyleBackColor = true;
            this.btnPrintOrdersList.Click += new System.EventHandler(this.btnPrintOrdersList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(555, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearchAllOrders
            // 
            this.txtSearchAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAllOrders.Location = new System.Drawing.Point(305, 21);
            this.txtSearchAllOrders.Name = "txtSearchAllOrders";
            this.txtSearchAllOrders.Size = new System.Drawing.Size(368, 30);
            this.txtSearchAllOrders.TabIndex = 0;
            this.txtSearchAllOrders.TextChanged += new System.EventHandler(this.txtSearchAllOrders_TextChanged);
            // 
            // FRM_ORDERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 562);
            this.Controls.Add(this.txtSearchAllOrders);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintOrdersList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المبيعات والفواتير";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvbOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dvbOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintOrdersList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearchAllOrders;
    }
}