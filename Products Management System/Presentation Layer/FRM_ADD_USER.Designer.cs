namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_ADD_USER
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCloseUF = new System.Windows.Forms.Button();
            this.btnSaveU = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.tCPass = new System.Windows.Forms.TextBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.tFullName = new System.Windows.Forms.TextBox();
            this.tUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCloseUF);
            this.groupBox2.Controls.Add(this.btnSaveU);
            this.groupBox2.Controls.Add(this.comboType);
            this.groupBox2.Controls.Add(this.tCPass);
            this.groupBox2.Controls.Add(this.tPass);
            this.groupBox2.Controls.Add(this.tFullName);
            this.groupBox2.Controls.Add(this.tUserName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 286);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   بيانات المستخدم   ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCloseUF
            // 
            this.btnCloseUF.Location = new System.Drawing.Point(18, 234);
            this.btnCloseUF.Name = "btnCloseUF";
            this.btnCloseUF.Size = new System.Drawing.Size(151, 38);
            this.btnCloseUF.TabIndex = 6;
            this.btnCloseUF.Text = "خروج";
            this.btnCloseUF.UseVisualStyleBackColor = true;
            this.btnCloseUF.Click += new System.EventHandler(this.btnCloseUF_Click);
            // 
            // btnSaveU
            // 
            this.btnSaveU.Location = new System.Drawing.Point(18, 47);
            this.btnSaveU.Name = "btnSaveU";
            this.btnSaveU.Size = new System.Drawing.Size(151, 38);
            this.btnSaveU.TabIndex = 5;
            this.btnSaveU.Text = "حفظ";
            this.btnSaveU.UseVisualStyleBackColor = true;
            this.btnSaveU.Click += new System.EventHandler(this.btnSaveU_Click);
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "مدير",
            "عادي"});
            this.comboType.Location = new System.Drawing.Point(185, 239);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(272, 33);
            this.comboType.TabIndex = 4;
            // 
            // tCPass
            // 
            this.tCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCPass.Location = new System.Drawing.Point(185, 191);
            this.tCPass.Name = "tCPass";
            this.tCPass.PasswordChar = '*';
            this.tCPass.Size = new System.Drawing.Size(272, 30);
            this.tCPass.TabIndex = 3;
            // 
            // tPass
            // 
            this.tPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPass.Location = new System.Drawing.Point(185, 143);
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(272, 30);
            this.tPass.TabIndex = 2;
            // 
            // tFullName
            // 
            this.tFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFullName.Location = new System.Drawing.Point(185, 95);
            this.tFullName.Name = "tFullName";
            this.tFullName.Size = new System.Drawing.Size(272, 30);
            this.tFullName.TabIndex = 1;
            // 
            // tUserName
            // 
            this.tUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserName.Location = new System.Drawing.Point(185, 47);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(272, 30);
            this.tUserName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "نوع المستخدم";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "تأكيد كلمة المرور";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "كلمة المرور";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "الاسم الكامل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "اسم المستخدم";
            // 
            // FRM_ADD_USER
            // 
            this.ClientSize = new System.Drawing.Size(604, 307);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_USER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدم جديد";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCloseUF;
        public System.Windows.Forms.Button btnSaveU;
        public System.Windows.Forms.ComboBox comboType;
        public System.Windows.Forms.TextBox tCPass;
        public System.Windows.Forms.TextBox tPass;
        public System.Windows.Forms.TextBox tFullName;
        public System.Windows.Forms.TextBox tUserName;
    }
}