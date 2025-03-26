namespace BookstoreManagementSystem
{
    partial class Reports
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tabOrderReport = new System.Windows.Forms.TabPage();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.dgvOrderReport = new System.Windows.Forms.DataGridView();
            this.btnGenerateOrder = new System.Windows.Forms.Button();
            this.dtpOrderEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.booksBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.tabOrderReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(345, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 701);
            this.panel2.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSalesReport);
            this.tabControl1.Controls.Add(this.tabOrderReport);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 642);
            this.tabControl1.TabIndex = 67;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.BackColor = System.Drawing.Color.Azure;
            this.tabSalesReport.Controls.Add(this.btnPrint);
            this.tabSalesReport.Controls.Add(this.dgvSalesReport);
            this.tabSalesReport.Controls.Add(this.btnGenerate);
            this.tabSalesReport.Controls.Add(this.dtpEndDate);
            this.tabSalesReport.Controls.Add(this.dtpStartDate);
            this.tabSalesReport.Location = new System.Drawing.Point(4, 34);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesReport.Size = new System.Drawing.Size(963, 604);
            this.tabSalesReport.TabIndex = 0;
            this.tabSalesReport.Text = "Sales";
            this.tabSalesReport.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(6, 543);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(192, 42);
            this.btnPrint.TabIndex = 79;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(6, 75);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.RowTemplate.Height = 24;
            this.dgvSalesReport.Size = new System.Drawing.Size(935, 448);
            this.dgvSalesReport.TabIndex = 78;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Moccasin;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(488, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(177, 32);
            this.btnGenerate.TabIndex = 77;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(239, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 27);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(6, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 27);
            this.dtpStartDate.TabIndex = 0;
            // 
            // tabOrderReport
            // 
            this.tabOrderReport.BackColor = System.Drawing.Color.Azure;
            this.tabOrderReport.Controls.Add(this.btnPrintOrder);
            this.tabOrderReport.Controls.Add(this.dgvOrderReport);
            this.tabOrderReport.Controls.Add(this.btnGenerateOrder);
            this.tabOrderReport.Controls.Add(this.dtpOrderEndDate);
            this.tabOrderReport.Controls.Add(this.dtpOrderStartDate);
            this.tabOrderReport.Location = new System.Drawing.Point(4, 34);
            this.tabOrderReport.Name = "tabOrderReport";
            this.tabOrderReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderReport.Size = new System.Drawing.Size(963, 604);
            this.tabOrderReport.TabIndex = 1;
            this.tabOrderReport.Text = "Orders";
            this.tabOrderReport.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOrder.Location = new System.Drawing.Point(14, 540);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(192, 42);
            this.btnPrintOrder.TabIndex = 84;
            this.btnPrintOrder.Text = "Print Report";
            this.btnPrintOrder.UseVisualStyleBackColor = false;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // dgvOrderReport
            // 
            this.dgvOrderReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderReport.Location = new System.Drawing.Point(14, 72);
            this.dgvOrderReport.Name = "dgvOrderReport";
            this.dgvOrderReport.RowHeadersWidth = 51;
            this.dgvOrderReport.RowTemplate.Height = 24;
            this.dgvOrderReport.Size = new System.Drawing.Size(935, 448);
            this.dgvOrderReport.TabIndex = 83;
            // 
            // btnGenerateOrder
            // 
            this.btnGenerateOrder.BackColor = System.Drawing.Color.Moccasin;
            this.btnGenerateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateOrder.Location = new System.Drawing.Point(496, 22);
            this.btnGenerateOrder.Name = "btnGenerateOrder";
            this.btnGenerateOrder.Size = new System.Drawing.Size(177, 32);
            this.btnGenerateOrder.TabIndex = 82;
            this.btnGenerateOrder.Text = "Generate Report";
            this.btnGenerateOrder.UseVisualStyleBackColor = false;
            this.btnGenerateOrder.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtpOrderEndDate
            // 
            this.dtpOrderEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderEndDate.Location = new System.Drawing.Point(247, 22);
            this.dtpOrderEndDate.Name = "dtpOrderEndDate";
            this.dtpOrderEndDate.Size = new System.Drawing.Size(200, 27);
            this.dtpOrderEndDate.TabIndex = 81;
            // 
            // dtpOrderStartDate
            // 
            this.dtpOrderStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderStartDate.Location = new System.Drawing.Point(14, 22);
            this.dtpOrderStartDate.Name = "dtpOrderStartDate";
            this.dtpOrderStartDate.Size = new System.Drawing.Size(200, 27);
            this.dtpOrderStartDate.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "BookHaven ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(934, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.ordersBtn);
            this.panel1.Controls.Add(this.customersBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.salesBtn);
            this.panel1.Controls.Add(this.supplierBtn);
            this.panel1.Controls.Add(this.staffBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.booksBtn);
            this.panel1.Controls.Add(this.reportsBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 701);
            this.panel1.TabIndex = 10;
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ordersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersBtn.Location = new System.Drawing.Point(49, 338);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(240, 41);
            this.ordersBtn.TabIndex = 37;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click_1);
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.Location = new System.Drawing.Point(49, 180);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(240, 41);
            this.customersBtn.TabIndex = 36;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = false;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click_1);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(49, 636);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(240, 41);
            this.logoutBtn.TabIndex = 35;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click_1);
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.Location = new System.Drawing.Point(49, 416);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(240, 41);
            this.salesBtn.TabIndex = 34;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = false;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click_1);
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.Location = new System.Drawing.Point(49, 260);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(240, 41);
            this.supplierBtn.TabIndex = 31;
            this.supplierBtn.Text = "Suppliers";
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click_1);
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(49, 491);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(240, 41);
            this.staffBtn.TabIndex = 30;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click_1);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Location = new System.Drawing.Point(49, 15);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(240, 41);
            this.dashboardBtn.TabIndex = 29;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // booksBtn
            // 
            this.booksBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.booksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.booksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksBtn.Location = new System.Drawing.Point(49, 96);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(240, 41);
            this.booksBtn.TabIndex = 28;
            this.booksBtn.Text = "Books";
            this.booksBtn.UseVisualStyleBackColor = false;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click_1);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Location = new System.Drawing.Point(49, 561);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(240, 41);
            this.reportsBtn.TabIndex = 23;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1331, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSalesReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.tabOrderReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.TabPage tabOrderReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.DataGridView dgvOrderReport;
        private System.Windows.Forms.Button btnGenerateOrder;
        private System.Windows.Forms.DateTimePicker dtpOrderEndDate;
        private System.Windows.Forms.DateTimePicker dtpOrderStartDate;
    }
}