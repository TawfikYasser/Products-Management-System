namespace Products_Management_System.Presentation_Layer
{
    partial class FRM_PRODUCTS_LIST
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
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.AllowUserToAddRows = false;
            this.dgvProductsList.AllowUserToDeleteRows = false;
            this.dgvProductsList.AllowUserToOrderColumns = true;
            this.dgvProductsList.AllowUserToResizeRows = false;
            this.dgvProductsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductsList.Location = new System.Drawing.Point(0, 0);
            this.dgvProductsList.MultiSelect = false;
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.ReadOnly = true;
            this.dgvProductsList.RowHeadersWidth = 51;
            this.dgvProductsList.RowTemplate.Height = 24;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(1134, 468);
            this.dgvProductsList.TabIndex = 0;
            this.dgvProductsList.DoubleClick += new System.EventHandler(this.dgvProductsList_DoubleClick);
            // 
            // FRM_PRODUCTS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 468);
            this.Controls.Add(this.dgvProductsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة المنتجات";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvProductsList;
    }
}