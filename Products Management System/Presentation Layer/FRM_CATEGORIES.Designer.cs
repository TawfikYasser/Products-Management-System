namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_CATEGORIES
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
            this.dgList = new System.Windows.Forms.DataGridView();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportToPdfAll = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.exportToPdfCurrent = new System.Windows.Forms.Button();
            this.btnrintCurrent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgList);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   الاصناف   ";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(26, 21);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersWidth = 51;
            this.dgList.RowTemplate.Height = 24;
            this.dgList.Size = new System.Drawing.Size(545, 224);
            this.dgList.TabIndex = 6;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(715, 220);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(596, 211);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 34);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(653, 211);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 34);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(784, 211);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(51, 34);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(841, 211);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(51, 34);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(596, 83);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(296, 105);
            this.txtDesc.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(596, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(296, 30);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(926, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "وصف الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(926, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exportToPdfAll);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnPrintAll);
            this.groupBox2.Controls.Add(this.exportToPdfCurrent);
            this.groupBox2.Controls.Add(this.btnrintCurrent);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   العمليات المتاحة   ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // exportToPdfAll
            // 
            this.exportToPdfAll.Location = new System.Drawing.Point(290, 87);
            this.exportToPdfAll.Name = "exportToPdfAll";
            this.exportToPdfAll.Size = new System.Drawing.Size(199, 47);
            this.exportToPdfAll.TabIndex = 6;
            this.exportToPdfAll.Text = "تصدير الى ملف PDF";
            this.exportToPdfAll.UseVisualStyleBackColor = true;
            this.exportToPdfAll.Click += new System.EventHandler(this.exportToPdfAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(290, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(199, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAll.Location = new System.Drawing.Point(737, 87);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(199, 47);
            this.btnPrintAll.TabIndex = 4;
            this.btnPrintAll.Text = "طباعة كل الاصناف";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // exportToPdfCurrent
            // 
            this.exportToPdfCurrent.Location = new System.Drawing.Point(62, 87);
            this.exportToPdfCurrent.Name = "exportToPdfCurrent";
            this.exportToPdfCurrent.Size = new System.Drawing.Size(199, 47);
            this.exportToPdfCurrent.TabIndex = 7;
            this.exportToPdfCurrent.Text = "تصدير الصنف ومنتجاته الى ملف PDF";
            this.exportToPdfCurrent.UseVisualStyleBackColor = true;
            this.exportToPdfCurrent.Click += new System.EventHandler(this.exportToPdfCurrent_Click);
            // 
            // btnrintCurrent
            // 
            this.btnrintCurrent.Location = new System.Drawing.Point(514, 87);
            this.btnrintCurrent.Name = "btnrintCurrent";
            this.btnrintCurrent.Size = new System.Drawing.Size(199, 47);
            this.btnrintCurrent.TabIndex = 5;
            this.btnrintCurrent.Text = "طباعة الصنف الحالي ومنتجاته";
            this.btnrintCurrent.UseVisualStyleBackColor = true;
            this.btnrintCurrent.Click += new System.EventHandler(this.btnrintCurrent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(62, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(199, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(514, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNew.Location = new System.Drawing.Point(737, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(199, 47);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FRM_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATEGORIES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button exportToPdfAll;
        private System.Windows.Forms.Button exportToPdfCurrent;
        private System.Windows.Forms.Button btnrintCurrent;
        private System.Windows.Forms.Button btnPrintAll;
    }
}