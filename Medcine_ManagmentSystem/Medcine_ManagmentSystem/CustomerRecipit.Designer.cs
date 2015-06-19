namespace Medcine_ManagmentSystem
{
    partial class frmCustomerRecipit
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
            this.dgvCustomerRecipit = new System.Windows.Forms.DataGridView();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.txtDateAndTime = new System.Windows.Forms.TextBox();
            this.lblVoucherID = new System.Windows.Forms.Label();
            this.txtVocherID = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecipit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerRecipit
            // 
            this.dgvCustomerRecipit.AllowUserToAddRows = false;
            this.dgvCustomerRecipit.AllowUserToDeleteRows = false;
            this.dgvCustomerRecipit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRecipit.Location = new System.Drawing.Point(243, 313);
            this.dgvCustomerRecipit.Name = "dgvCustomerRecipit";
            this.dgvCustomerRecipit.ReadOnly = true;
            this.dgvCustomerRecipit.Size = new System.Drawing.Size(482, 251);
            this.dgvCustomerRecipit.TabIndex = 33;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(609, 209);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(116, 39);
            this.btnRight.TabIndex = 32;
            this.btnRight.Text = "Right ->";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(487, 209);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 39);
            this.btnForward.TabIndex = 31;
            this.btnForward.Text = "Forward =>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(365, 209);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(116, 39);
            this.btnBackward.TabIndex = 30;
            this.btnBackward.Text = "Backward <=";
            this.btnBackward.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(243, 209);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(116, 39);
            this.btnLeft.TabIndex = 29;
            this.btnLeft.Text = "Left <-";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(609, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 39);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(487, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 39);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(365, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 39);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Location = new System.Drawing.Point(273, 54);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(62, 13);
            this.lblCompanyID.TabIndex = 25;
            this.lblCompanyID.Text = "CompanyID";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(349, 47);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(356, 20);
            this.txtCompanyID.TabIndex = 24;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(273, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 23;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(349, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(356, 20);
            this.txtAmount.TabIndex = 22;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(263, 102);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(72, 13);
            this.lblDateAndTime.TabIndex = 21;
            this.lblDateAndTime.Text = "DateAndTiem";
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Location = new System.Drawing.Point(349, 99);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(356, 20);
            this.txtDateAndTime.TabIndex = 20;
            // 
            // lblVoucherID
            // 
            this.lblVoucherID.AutoSize = true;
            this.lblVoucherID.Location = new System.Drawing.Point(273, 28);
            this.lblVoucherID.Name = "lblVoucherID";
            this.lblVoucherID.Size = new System.Drawing.Size(61, 13);
            this.lblVoucherID.TabIndex = 19;
            this.lblVoucherID.Text = "Voucher ID";
            // 
            // txtVocherID
            // 
            this.txtVocherID.Location = new System.Drawing.Point(349, 21);
            this.txtVocherID.Name = "txtVocherID";
            this.txtVocherID.Size = new System.Drawing.Size(356, 20);
            this.txtVocherID.TabIndex = 18;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(243, 164);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 39);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmCustomerRecipit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 584);
            this.Controls.Add(this.dgvCustomerRecipit);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.txtDateAndTime);
            this.Controls.Add(this.lblVoucherID);
            this.Controls.Add(this.txtVocherID);
            this.Controls.Add(this.btnInsert);
            this.Location = new System.Drawing.Point(208, 173);
            this.Name = "frmCustomerRecipit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCustomerRecipit";
            this.Load += new System.EventHandler(this.CustomerRecipit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecipit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerRecipit;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.TextBox txtDateAndTime;
        private System.Windows.Forms.Label lblVoucherID;
        private System.Windows.Forms.TextBox txtVocherID;
        private System.Windows.Forms.Button btnInsert;
    }
}