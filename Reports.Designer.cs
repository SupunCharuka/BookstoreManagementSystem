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
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 701);
            this.panel1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(49, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 41);
            this.button3.TabIndex = 37;
            this.button3.Text = "Orders";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SkyBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(49, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(240, 41);
            this.button9.TabIndex = 36;
            this.button9.Text = "Customers";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SkyBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(49, 636);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(240, 41);
            this.button10.TabIndex = 35;
            this.button10.Text = "Logout";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 41);
            this.button1.TabIndex = 34;
            this.button1.Text = "Sales";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(49, 331);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(240, 41);
            this.button11.TabIndex = 31;
            this.button11.Text = "Suppliers";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.SkyBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(49, 177);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(240, 41);
            this.button12.TabIndex = 30;
            this.button12.Text = "Staff";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.SkyBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(49, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(240, 41);
            this.button13.TabIndex = 29;
            this.button13.Text = "Dashboard";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.SkyBlue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(49, 96);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(240, 41);
            this.button14.TabIndex = 28;
            this.button14.Text = "Books";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(49, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reports";
            this.button2.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
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