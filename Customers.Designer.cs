namespace BookstoreManagementSystem
{
    partial class Customers
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.brnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.booksBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvCustomers);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.brnDelete);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Location = new System.Drawing.Point(345, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 701);
            this.panel2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Customers List";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(27, 390);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(915, 297);
            this.dgvCustomers.TabIndex = 32;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Moccasin;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(283, 269);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 42);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // brnDelete
            // 
            this.brnDelete.BackColor = System.Drawing.Color.Moccasin;
            this.brnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDelete.Location = new System.Drawing.Point(514, 269);
            this.brnDelete.Name = "brnDelete";
            this.brnDelete.Size = new System.Drawing.Size(166, 42);
            this.brnDelete.TabIndex = 30;
            this.brnDelete.Text = "Delete";
            this.brnDelete.UseVisualStyleBackColor = false;
            this.brnDelete.Click += new System.EventHandler(this.brnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(750, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 42);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Moccasin;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(47, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 42);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(680, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 34);
            this.txtAddress.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(360, 109);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 34);
            this.txtPhone.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(27, 109);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(240, 34);
            this.txtCustomerName.TabIndex = 11;
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
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(934, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 36);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.reportsBtn);
            this.panel1.Controls.Add(this.ordersBtn);
            this.panel1.Controls.Add(this.customersBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.booksBtn);
            this.panel1.Controls.Add(this.salesBtn);
            this.panel1.Controls.Add(this.supplierBtn);
            this.panel1.Controls.Add(this.staffBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 701);
            this.panel1.TabIndex = 6;
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Location = new System.Drawing.Point(49, 562);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(240, 41);
            this.reportsBtn.TabIndex = 56;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click_1);
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ordersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersBtn.Location = new System.Drawing.Point(49, 339);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(240, 41);
            this.ordersBtn.TabIndex = 55;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click_1);
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.Location = new System.Drawing.Point(49, 182);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(240, 41);
            this.customersBtn.TabIndex = 54;
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
            this.logoutBtn.TabIndex = 53;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click_1);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Location = new System.Drawing.Point(49, 27);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(240, 41);
            this.dashboardBtn.TabIndex = 50;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.button13_Click);
            // 
            // booksBtn
            // 
            this.booksBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.booksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.booksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksBtn.Location = new System.Drawing.Point(49, 102);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(240, 41);
            this.booksBtn.TabIndex = 49;
            this.booksBtn.Text = "Books";
            this.booksBtn.UseVisualStyleBackColor = false;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click_1);
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.Location = new System.Drawing.Point(49, 416);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(240, 41);
            this.salesBtn.TabIndex = 48;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = false;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click_1);
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.Location = new System.Drawing.Point(49, 258);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(240, 41);
            this.supplierBtn.TabIndex = 21;
            this.supplierBtn.Text = "Suppliers";
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click_1);
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(49, 489);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(240, 41);
            this.staffBtn.TabIndex = 20;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click_1);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1331, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button brnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button reportsBtn;
    }
}