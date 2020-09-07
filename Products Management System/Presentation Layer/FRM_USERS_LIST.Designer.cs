namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_USERS_LIST
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtSearchAllUsers = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrintOrdersList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Location = new System.Drawing.Point(10, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 420);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   قائمة المستخدمين   ";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 21);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1036, 393);
            this.dgvUsers.TabIndex = 0;
            // 
            // txtSearchAllUsers
            // 
            this.txtSearchAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAllUsers.Location = new System.Drawing.Point(296, 18);
            this.txtSearchAllUsers.Name = "txtSearchAllUsers";
            this.txtSearchAllUsers.Size = new System.Drawing.Size(336, 30);
            this.txtSearchAllUsers.TabIndex = 0;
            this.txtSearchAllUsers.TextChanged += new System.EventHandler(this.txtSearchAllUsers_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(687, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintOrdersList
            // 
            this.btnPrintOrdersList.Location = new System.Drawing.Point(243, 480);
            this.btnPrintOrdersList.Name = "btnPrintOrdersList";
            this.btnPrintOrdersList.Size = new System.Drawing.Size(142, 40);
            this.btnPrintOrdersList.TabIndex = 1;
            this.btnPrintOrdersList.Text = "إضافة مستخدم";
            this.btnPrintOrdersList.UseVisualStyleBackColor = true;
            this.btnPrintOrdersList.Click += new System.EventHandler(this.btnPrintOrdersList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "قم بإدخال الكلمة المراد البحث عنها:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "تعديل المستخدم";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "حذف المستخدم";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_USERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchAllUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrintOrdersList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_USERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المستخدمين";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtSearchAllUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrintOrdersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}