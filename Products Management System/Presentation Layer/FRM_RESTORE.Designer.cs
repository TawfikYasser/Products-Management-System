namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_RESTORE
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close_Restore = new System.Windows.Forms.Button();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.txtFileNameRestore = new System.Windows.Forms.TextBox();
            this.btnBrowseRestore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "* قم بتحديد مسار تواجد النسخة الإحتياطية ثم قم بالضغط على إستعادة النسخة.";
            // 
            // btn_Close_Restore
            // 
            this.btn_Close_Restore.Location = new System.Drawing.Point(575, 110);
            this.btn_Close_Restore.Name = "btn_Close_Restore";
            this.btn_Close_Restore.Size = new System.Drawing.Size(133, 42);
            this.btn_Close_Restore.TabIndex = 2;
            this.btn_Close_Restore.Text = "خروج";
            this.btn_Close_Restore.UseVisualStyleBackColor = true;
            this.btn_Close_Restore.Click += new System.EventHandler(this.btn_Close_Restore_Click);
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.Location = new System.Drawing.Point(575, 62);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(133, 42);
            this.btnRestoreBackup.TabIndex = 1;
            this.btnRestoreBackup.Text = "إستعادة النسخة";
            this.btnRestoreBackup.UseVisualStyleBackColor = true;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // txtFileNameRestore
            // 
            this.txtFileNameRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNameRestore.Location = new System.Drawing.Point(11, 18);
            this.txtFileNameRestore.Name = "txtFileNameRestore";
            this.txtFileNameRestore.ReadOnly = true;
            this.txtFileNameRestore.Size = new System.Drawing.Size(558, 38);
            this.txtFileNameRestore.TabIndex = 6;
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Location = new System.Drawing.Point(575, 18);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(135, 38);
            this.btnBrowseRestore.TabIndex = 0;
            this.btnBrowseRestore.Text = ". . .";
            this.btnBrowseRestore.UseVisualStyleBackColor = true;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_RESTORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close_Restore);
            this.Controls.Add(this.btnRestoreBackup);
            this.Controls.Add(this.txtFileNameRestore);
            this.Controls.Add(this.btnBrowseRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RESTORE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إستعادة النسخة الإحتياطية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close_Restore;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.TextBox txtFileNameRestore;
        private System.Windows.Forms.Button btnBrowseRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}