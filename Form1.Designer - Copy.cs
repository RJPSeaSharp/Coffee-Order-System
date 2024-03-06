namespace Assignment_3._3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRoast = new System.Windows.Forms.Label();
            this.lblCupSize = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.GrpBoxOrder = new System.Windows.Forms.GroupBox();
            this.cmboRoast = new System.Windows.Forms.ComboBox();
            this.cmbCupSize = new System.Windows.Forms.ComboBox();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.CmboCreamer = new System.Windows.Forms.ComboBox();
            this.cmboSugar = new System.Windows.Forms.ComboBox();
            this.lblAddCreamer = new System.Windows.Forms.Label();
            this.lnlAddSugar = new System.Windows.Forms.Label();
            this.btnAddcoffee = new System.Windows.Forms.Button();
            this.btnDeleteCoffee = new System.Windows.Forms.Button();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.lblCoffeeShop = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.GrpBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(18, 27);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name";
            this.lblCustomerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblRoast
            // 
            this.lblRoast.AutoSize = true;
            this.lblRoast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoast.Location = new System.Drawing.Point(19, 65);
            this.lblRoast.Name = "lblRoast";
            this.lblRoast.Size = new System.Drawing.Size(44, 15);
            this.lblRoast.TabIndex = 2;
            this.lblRoast.Text = "Roast";
            this.lblRoast.Click += new System.EventHandler(this.lblRoast_Click);
            // 
            // lblCupSize
            // 
            this.lblCupSize.AutoSize = true;
            this.lblCupSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupSize.Location = new System.Drawing.Point(18, 111);
            this.lblCupSize.Name = "lblCupSize";
            this.lblCupSize.Size = new System.Drawing.Size(64, 15);
            this.lblCupSize.TabIndex = 4;
            this.lblCupSize.Text = "Cup Size";
            this.lblCupSize.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp.Location = new System.Drawing.Point(18, 156);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(89, 15);
            this.lbltemp.TabIndex = 6;
            this.lbltemp.Text = "Temperature";
            this.lbltemp.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // GrpBoxOrder
            // 
            this.GrpBoxOrder.BackColor = System.Drawing.Color.Tan;
            this.GrpBoxOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GrpBoxOrder.BackgroundImage")));
            this.GrpBoxOrder.Controls.Add(this.cmboRoast);
            this.GrpBoxOrder.Controls.Add(this.cmbCupSize);
            this.GrpBoxOrder.Controls.Add(this.cmbTemp);
            this.GrpBoxOrder.Controls.Add(this.btnSubmit);
            this.GrpBoxOrder.Controls.Add(this.CmboCreamer);
            this.GrpBoxOrder.Controls.Add(this.cmboSugar);
            this.GrpBoxOrder.Controls.Add(this.lblAddCreamer);
            this.GrpBoxOrder.Controls.Add(this.lnlAddSugar);
            this.GrpBoxOrder.Controls.Add(this.lbltemp);
            this.GrpBoxOrder.Controls.Add(this.lblCupSize);
            this.GrpBoxOrder.Controls.Add(this.lblRoast);
            this.GrpBoxOrder.Controls.Add(this.txtName);
            this.GrpBoxOrder.Controls.Add(this.lblCustomerName);
            this.GrpBoxOrder.Location = new System.Drawing.Point(501, 257);
            this.GrpBoxOrder.Name = "GrpBoxOrder";
            this.GrpBoxOrder.Size = new System.Drawing.Size(398, 337);
            this.GrpBoxOrder.TabIndex = 7;
            this.GrpBoxOrder.TabStop = false;
            this.GrpBoxOrder.Text = "Order Details";
            this.GrpBoxOrder.Visible = false;
            this.GrpBoxOrder.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmboRoast
            // 
            this.cmboRoast.FormattingEnabled = true;
            this.cmboRoast.Location = new System.Drawing.Point(147, 64);
            this.cmboRoast.Name = "cmboRoast";
            this.cmboRoast.Size = new System.Drawing.Size(229, 21);
            this.cmboRoast.TabIndex = 17;
            this.cmboRoast.SelectedIndexChanged += new System.EventHandler(this.cmboRoast_SelectedIndexChanged);
            // 
            // cmbCupSize
            // 
            this.cmbCupSize.FormattingEnabled = true;
            this.cmbCupSize.Location = new System.Drawing.Point(147, 110);
            this.cmbCupSize.Name = "cmbCupSize";
            this.cmbCupSize.Size = new System.Drawing.Size(229, 21);
            this.cmbCupSize.TabIndex = 16;
            // 
            // cmbTemp
            // 
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(147, 155);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(229, 21);
            this.cmbTemp.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(119, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(177, 41);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CmboCreamer
            // 
            this.CmboCreamer.FormattingEnabled = true;
            this.CmboCreamer.Location = new System.Drawing.Point(147, 240);
            this.CmboCreamer.Name = "CmboCreamer";
            this.CmboCreamer.Size = new System.Drawing.Size(229, 21);
            this.CmboCreamer.TabIndex = 13;
            // 
            // cmboSugar
            // 
            this.cmboSugar.FormattingEnabled = true;
            this.cmboSugar.Location = new System.Drawing.Point(147, 198);
            this.cmboSugar.Name = "cmboSugar";
            this.cmboSugar.Size = new System.Drawing.Size(229, 21);
            this.cmboSugar.TabIndex = 12;
            // 
            // lblAddCreamer
            // 
            this.lblAddCreamer.AutoSize = true;
            this.lblAddCreamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCreamer.Location = new System.Drawing.Point(19, 246);
            this.lblAddCreamer.Name = "lblAddCreamer";
            this.lblAddCreamer.Size = new System.Drawing.Size(90, 15);
            this.lblAddCreamer.TabIndex = 10;
            this.lblAddCreamer.Text = "Add Creamer";
            this.lblAddCreamer.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // lnlAddSugar
            // 
            this.lnlAddSugar.AutoSize = true;
            this.lnlAddSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlAddSugar.Location = new System.Drawing.Point(19, 199);
            this.lnlAddSugar.Name = "lnlAddSugar";
            this.lnlAddSugar.Size = new System.Drawing.Size(73, 15);
            this.lnlAddSugar.TabIndex = 8;
            this.lnlAddSugar.Text = "Add Sugar";
            this.lnlAddSugar.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // btnAddcoffee
            // 
            this.btnAddcoffee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddcoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcoffee.Location = new System.Drawing.Point(140, 293);
            this.btnAddcoffee.Name = "btnAddcoffee";
            this.btnAddcoffee.Size = new System.Drawing.Size(177, 65);
            this.btnAddcoffee.TabIndex = 8;
            this.btnAddcoffee.Text = "Add Coffee";
            this.btnAddcoffee.UseVisualStyleBackColor = false;
            this.btnAddcoffee.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnDeleteCoffee
            // 
            this.btnDeleteCoffee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCoffee.Location = new System.Drawing.Point(140, 402);
            this.btnDeleteCoffee.Name = "btnDeleteCoffee";
            this.btnDeleteCoffee.Size = new System.Drawing.Size(177, 65);
            this.btnDeleteCoffee.TabIndex = 9;
            this.btnDeleteCoffee.Text = "Delete Coffee";
            this.btnDeleteCoffee.UseVisualStyleBackColor = false;
            this.btnDeleteCoffee.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // OrderGrid
            // 
            this.OrderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Location = new System.Drawing.Point(5, 97);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.Size = new System.Drawing.Size(900, 154);
            this.OrderGrid.TabIndex = 10;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            // 
            // lblCoffeeShop
            // 
            this.lblCoffeeShop.AutoSize = true;
            this.lblCoffeeShop.BackColor = System.Drawing.Color.Tan;
            this.lblCoffeeShop.Font = new System.Drawing.Font("Lucida Calligraphy", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeShop.Location = new System.Drawing.Point(339, 9);
            this.lblCoffeeShop.Name = "lblCoffeeShop";
            this.lblCoffeeShop.Size = new System.Drawing.Size(277, 78);
            this.lblCoffeeShop.TabIndex = 11;
            this.lblCoffeeShop.Text = "C# Cafe";
            this.lblCoffeeShop.Click += new System.EventHandler(this.lblStudentMgmtSys_Click);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTime.Location = new System.Drawing.Point(1543, 792);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(10, 20);
            this.txtTime.TabIndex = 18;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 607);
            this.Controls.Add(this.lblCoffeeShop);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.btnDeleteCoffee);
            this.Controls.Add(this.btnAddcoffee);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.GrpBoxOrder);
            this.Name = "Form1";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxOrder.ResumeLayout(false);
            this.GrpBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRoast;
        private System.Windows.Forms.Label lblCupSize;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.GroupBox GrpBoxOrder;
        private System.Windows.Forms.Label lnlAddSugar;
        private System.Windows.Forms.Label lblAddCreamer;
        private System.Windows.Forms.Button btnAddcoffee;
        private System.Windows.Forms.Button btnDeleteCoffee;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Label lblCoffeeShop;
        private System.Windows.Forms.ComboBox CmboCreamer;
        private System.Windows.Forms.ComboBox cmboSugar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmboRoast;
        private System.Windows.Forms.ComboBox cmbCupSize;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

