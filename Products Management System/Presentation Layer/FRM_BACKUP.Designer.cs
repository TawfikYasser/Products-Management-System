namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_BACKUP
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
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.txtFileNameBU = new System.Windows.Forms.TextBox();
            this.btnMakeBackup = new System.Windows.Forms.Button();
            this.btn_Close_backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(576, 24);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(135, 38);
            this.btnBrowseBackup.TabIndex = 0;
            this.btnBrowseBackup.Text = ". . .";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtFileNameBU
            // 
            this.txtFileNameBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNameBU.Location = new System.Drawing.Point(12, 24);
            this.txtFileNameBU.Name = "txtFileNameBU";
            this.txtFileNameBU.ReadOnly = true;
            this.txtFileNameBU.Size = new System.Drawing.Size(558, 38);
            this.txtFileNameBU.TabIndex = 1;
            // 
            // btnMakeBackup
            // 
            this.btnMakeBackup.Location = new System.Drawing.Point(576, 68);
            this.btnMakeBackup.Name = "btnMakeBackup";
            this.btnMakeBackup.Size = new System.Drawing.Size(133, 42);
            this.btnMakeBackup.TabIndex = 1;
            this.btnMakeBackup.Text = "إنشاء النسخة";
            this.btnMakeBackup.UseVisualStyleBackColor = true;
            this.btnMakeBackup.Click += new System.EventHandler(this.btnMakeBackup_Click);
            // 
            // btn_Close_backup
            // 
            this.btn_Close_backup.Location = new System.Drawing.Point(576, 116);
            this.btn_Close_backup.Name = "btn_Close_backup";
            this.btn_Close_backup.Size = new System.Drawing.Size(133, 42);
            this.btn_Close_backup.TabIndex = 2;
            this.btn_Close_backup.Text = "خروج";
            this.btn_Close_backup.UseVisualStyleBackColor = true;
            this.btn_Close_backup.Click += new System.EventHandler(this.btn_Close_backup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "* قم بتحديد المجلد الذي تريد حفظ النسخة الاحتياطية فيه ثم اضغط على إنشاء النسخة.";
            // 
            // FRM_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close_backup);
            this.Controls.Add(this.btnMakeBackup);
            this.Controls.Add(this.txtFileNameBU);
            this.Controls.Add(this.btnBrowseBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء نسخة إحتياطية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.TextBox txtFileNameBU;
        private System.Windows.Forms.Button btnMakeBackup;
        private System.Windows.Forms.Button btn_Close_backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}