namespace Medcine_ManagmentSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.llableProfile = new System.Windows.Forms.LinkLabel();
            this.btnPurches = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnCustomerRecipit = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomerPayment = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daCustomer = new System.Data.SqlClient.SqlDataAdapter();
            this.dsCustomer1 = new Medcine_ManagmentSystem.DSCustomer();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.DASaleSaleDetail = new System.Data.SqlClient.SqlDataAdapter();
            this.dsSaleSaleDetail1 = new Medcine_ManagmentSystem.DSSaleSaleDetail();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.DASale = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleSaleDetail1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(281, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 3;
            // 
            // llableProfile
            // 
            this.llableProfile.AutoSize = true;
            this.llableProfile.LinkColor = System.Drawing.Color.Gray;
            this.llableProfile.Location = new System.Drawing.Point(26, 637);
            this.llableProfile.Name = "llableProfile";
            this.llableProfile.Size = new System.Drawing.Size(65, 13);
            this.llableProfile.TabIndex = 7;
            this.llableProfile.TabStop = true;
            this.llableProfile.Text = "AdminProfile";
            this.llableProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llableProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnPurches
            // 
            this.btnPurches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurches.Location = new System.Drawing.Point(12, 524);
            this.btnPurches.Name = "btnPurches";
            this.btnPurches.Size = new System.Drawing.Size(191, 52);
            this.btnPurches.TabIndex = 6;
            this.btnPurches.Text = "purchase";
            this.btnPurches.UseVisualStyleBackColor = true;
            this.btnPurches.Click += new System.EventHandler(this.btnPurches_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompany.Location = new System.Drawing.Point(12, 176);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(191, 52);
            this.btnCompany.TabIndex = 5;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedicine.Location = new System.Drawing.Point(12, 408);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(191, 52);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "medicine";
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnCustomerRecipit
            // 
            this.btnCustomerRecipit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerRecipit.Location = new System.Drawing.Point(12, 350);
            this.btnCustomerRecipit.Name = "btnCustomerRecipit";
            this.btnCustomerRecipit.Size = new System.Drawing.Size(191, 52);
            this.btnCustomerRecipit.TabIndex = 3;
            this.btnCustomerRecipit.Text = "customer Recipit";
            this.btnCustomerRecipit.UseVisualStyleBackColor = true;
            this.btnCustomerRecipit.Click += new System.EventHandler(this.btnCustomerRecipit_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.Location = new System.Drawing.Point(12, 466);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(191, 52);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustomerPayment
            // 
            this.btnCustomerPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerPayment.Location = new System.Drawing.Point(12, 292);
            this.btnCustomerPayment.Name = "btnCustomerPayment";
            this.btnCustomerPayment.Size = new System.Drawing.Size(191, 52);
            this.btnCustomerPayment.TabIndex = 2;
            this.btnCustomerPayment.Text = "customer payment";
            this.btnCustomerPayment.UseVisualStyleBackColor = true;
            this.btnCustomerPayment.Click += new System.EventHandler(this.btnCustomerPayment_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Location = new System.Drawing.Point(12, 234);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(191, 52);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Customers.*\r\nFROM            Customers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Medicine;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CustomerName", System.Data.SqlDbType.Char, 0, "CustomerName"),
            new System.Data.SqlClient.SqlParameter("@CustomerAddress", System.Data.SqlDbType.NVarChar, 0, "CustomerAddress"),
            new System.Data.SqlClient.SqlParameter("@CustomerPhoneNo", System.Data.SqlDbType.Int, 0, "CustomerPhoneNo"),
            new System.Data.SqlClient.SqlParameter("@CustomerDescription", System.Data.SqlDbType.Char, 0, "CustomerDescription")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CustomerName", System.Data.SqlDbType.Char, 0, "CustomerName"),
            new System.Data.SqlClient.SqlParameter("@CustomerAddress", System.Data.SqlDbType.NVarChar, 0, "CustomerAddress"),
            new System.Data.SqlClient.SqlParameter("@CustomerPhoneNo", System.Data.SqlDbType.Int, 0, "CustomerPhoneNo"),
            new System.Data.SqlClient.SqlParameter("@CustomerDescription", System.Data.SqlDbType.Char, 0, "CustomerDescription"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerName", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerPhoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerPhoneNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerDescription", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerDescription", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerName", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerPhoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerPhoneNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerDescription", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerDescription", System.Data.DataRowVersion.Original, null)});
            // 
            // daCustomer
            // 
            this.daCustomer.DeleteCommand = this.sqlDeleteCommand1;
            this.daCustomer.InsertCommand = this.sqlInsertCommand1;
            this.daCustomer.SelectCommand = this.sqlSelectCommand1;
            this.daCustomer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"),
                        new System.Data.Common.DataColumnMapping("CustomerAddress", "CustomerAddress"),
                        new System.Data.Common.DataColumnMapping("CustomerPhoneNo", "CustomerPhoneNo"),
                        new System.Data.Common.DataColumnMapping("CustomerDescription", "CustomerDescription")})});
            this.daCustomer.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dsCustomer1
            // 
            this.dsCustomer1.DataSetName = "DSCustomer";
            this.dsCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // DASaleSaleDetail
            // 
            this.DASaleSaleDetail.SelectCommand = this.sqlSelectCommand2;
            this.DASaleSaleDetail.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SaleID", "SaleID"),
                        new System.Data.Common.DataColumnMapping("SaleDateAndTime", "SaleDateAndTime"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Discount", "Discount"),
                        new System.Data.Common.DataColumnMapping("Price", "Price")})});
            // 
            // dsSaleSaleDetail1
            // 
            this.dsSaleSaleDetail1.DataSetName = "DSSaleSaleDetail";
            this.dsSaleSaleDetail1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 173);
            this.panel1.TabIndex = 2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        Sales.*\r\nFROM            Sales";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [Sales] ([SaleID], [SaleDateAndTime], [CustomerID]) VALUES (@SaleID, " +
                "@SaleDateAndTime, @CustomerID);\r\nSELECT SaleID, SaleDateAndTime, CustomerID FROM" +
                " Sales WHERE (SaleID = @SaleID)";
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SaleID", System.Data.SqlDbType.Int, 0, "SaleID"),
            new System.Data.SqlClient.SqlParameter("@SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, "SaleDateAndTime"),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SaleID", System.Data.SqlDbType.Int, 0, "SaleID"),
            new System.Data.SqlClient.SqlParameter("@SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, "SaleDateAndTime"),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@Original_SaleID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleDateAndTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [Sales] WHERE (([SaleID] = @Original_SaleID) AND ([SaleDateAndTime] =" +
                " @Original_SaleDateAndTime) AND ([CustomerID] = @Original_CustomerID))";
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SaleID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleDateAndTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null)});
            // 
            // DASale
            // 
            this.DASale.DeleteCommand = this.sqlDeleteCommand2;
            this.DASale.InsertCommand = this.sqlInsertCommand2;
            this.DASale.SelectCommand = this.sqlSelectCommand3;
            this.DASale.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SaleID", "SaleID"),
                        new System.Data.Common.DataColumnMapping("SaleDateAndTime", "SaleDateAndTime"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID")})});
            this.DASale.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 766);
            this.Controls.Add(this.llableProfile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPurches);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnCustomerRecipit);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnCustomerPayment);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = " v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleSaleDetail1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnCustomerRecipit;
        private System.Windows.Forms.Button btnCustomerPayment;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPurches;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daCustomer;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private DSCustomer dsCustomer1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter DASaleSaleDetail;
        private DSSaleSaleDetail dsSaleSaleDetail1;
        private System.Windows.Forms.LinkLabel llableProfile;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter DASale;
    }
}

