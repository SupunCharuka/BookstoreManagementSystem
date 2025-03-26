namespace BookstoreManagementSystem
{
    partial class Users
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.cmbRole);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridViewUsers);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Location = new System.Drawing.Point(345, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 701);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(675, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "Email";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(680, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 34);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(675, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(680, 198);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(240, 34);
            this.txtConfirmPassword.TabIndex = 37;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "SalesClerk"});
            this.cmbRole.Location = new System.Drawing.Point(27, 289);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(249, 37);
            this.cmbRole.TabIndex = 36;
            this.cmbRole.Text = "Select Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Roles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(421, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Staff List";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(27, 444);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(915, 243);
            this.dataGridViewUsers.TabIndex = 32;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Moccasin;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(284, 356);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(166, 42);
            this.editBtn.TabIndex = 31;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Moccasin;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(515, 356);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(166, 42);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Moccasin;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(751, 356);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(166, 42);
            this.resetBtn.TabIndex = 29;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Moccasin;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(48, 356);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(166, 42);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(360, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 34);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(27, 198);
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
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(27, 109);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 34);
            this.txtUsername.TabIndex = 11;
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
            this.panel1.Controls.Add(this.salesBtn);
            this.panel1.Controls.Add(this.supplierBtn);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.staffBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 701);
            this.panel1.TabIndex = 4;
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Location = new System.Drawing.Point(49, 563);
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
            this.ordersBtn.Location = new System.Drawing.Point(49, 333);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(240, 41);
            this.ordersBtn.TabIndex = 55;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click_1);
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.Location = new System.Drawing.Point(49, 176);
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
            this.dashboardBtn.Location = new System.Drawing.Point(49, 18);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(240, 41);
            this.dashboardBtn.TabIndex = 50;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.Location = new System.Drawing.Point(49, 406);
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
            this.supplierBtn.Location = new System.Drawing.Point(49, 252);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(240, 41);
            this.supplierBtn.TabIndex = 21;
            this.supplierBtn.Text = "Suppliers";
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.SkyBlue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(49, 102);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(240, 41);
            this.button14.TabIndex = 49;
            this.button14.Text = "Books";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(49, 483);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(240, 41);
            this.staffBtn.TabIndex = 20;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click_1);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1331, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button reportsBtn;
    }
}