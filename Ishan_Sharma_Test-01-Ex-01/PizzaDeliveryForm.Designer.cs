namespace Ishan_Sharma_Test_01_Ex_01
{
    partial class PizzaDeliveryForm
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
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.chkCapsicum = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.lblPizzaToppings = new System.Windows.Forms.Label();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.lblPizzaTypes = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.cmbPizzaShop = new System.Windows.Forms.ComboBox();
            this.lblPizzaShop = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderSummary = new System.Windows.Forms.TextBox();
            this.btnClearOrderSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalHst = new System.Windows.Forms.TextBox();
            this.customerUserControl2 = new Ishan_Sharma_Test_01_Ex_01.CustomerUserControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Controls.Add(this.btnClearOrder);
            this.groupBox1.Controls.Add(this.chkCapsicum);
            this.groupBox1.Controls.Add(this.chkOnions);
            this.groupBox1.Controls.Add(this.chkPepperoni);
            this.groupBox1.Controls.Add(this.chkMushroom);
            this.groupBox1.Controls.Add(this.chkTomatoes);
            this.groupBox1.Controls.Add(this.chkOlives);
            this.groupBox1.Controls.Add(this.lblPizzaToppings);
            this.groupBox1.Controls.Add(this.rbtnMedium);
            this.groupBox1.Controls.Add(this.rbtnLarge);
            this.groupBox1.Controls.Add(this.rbtnSmall);
            this.groupBox1.Controls.Add(this.lblPizzaTypes);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.cmbPizzaShop);
            this.groupBox1.Controls.Add(this.lblPizzaShop);
            this.groupBox1.Location = new System.Drawing.Point(313, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Details: ";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(207, 195);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 16;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(98, 195);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrder.TabIndex = 15;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // chkCapsicum
            // 
            this.chkCapsicum.AutoSize = true;
            this.chkCapsicum.Location = new System.Drawing.Point(98, 136);
            this.chkCapsicum.Name = "chkCapsicum";
            this.chkCapsicum.Size = new System.Drawing.Size(72, 17);
            this.chkCapsicum.TabIndex = 14;
            this.chkCapsicum.Text = "Capsicum";
            this.chkCapsicum.UseVisualStyleBackColor = true;
            this.chkCapsicum.CheckedChanged += new System.EventHandler(this.chkCapsicum_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(180, 136);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(59, 17);
            this.chkOnions.TabIndex = 13;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(98, 159);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(77, 17);
            this.chkPepperoni.TabIndex = 12;
            this.chkPepperoni.Text = "Pepperroni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(12, 161);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(75, 17);
            this.chkMushroom.TabIndex = 11;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(180, 159);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 10;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(12, 138);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 9;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // lblPizzaToppings
            // 
            this.lblPizzaToppings.AutoSize = true;
            this.lblPizzaToppings.Location = new System.Drawing.Point(9, 110);
            this.lblPizzaToppings.Name = "lblPizzaToppings";
            this.lblPizzaToppings.Size = new System.Drawing.Size(85, 13);
            this.lblPizzaToppings.TabIndex = 8;
            this.lblPizzaToppings.Text = "Pizza Toppings: ";
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(78, 79);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rbtnMedium.TabIndex = 7;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(155, 79);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rbtnLarge.TabIndex = 6;
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(12, 79);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rbtnSmall.TabIndex = 5;
            this.rbtnSmall.TabStop = true;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            // 
            // lblPizzaTypes
            // 
            this.lblPizzaTypes.AutoSize = true;
            this.lblPizzaTypes.Location = new System.Drawing.Point(9, 52);
            this.lblPizzaTypes.Name = "lblPizzaTypes";
            this.lblPizzaTypes.Size = new System.Drawing.Size(70, 13);
            this.lblPizzaTypes.TabIndex = 4;
            this.lblPizzaTypes.Text = "Pizza Types: ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(320, 32);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(56, 34);
            this.txtSubTotal.TabIndex = 3;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(317, 16);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(59, 13);
            this.lblSubTotal.TabIndex = 2;
            this.lblSubTotal.Text = "Sub Total: ";
            // 
            // cmbPizzaShop
            // 
            this.cmbPizzaShop.FormattingEnabled = true;
            this.cmbPizzaShop.Items.AddRange(new object[] {
            "Dominos",
            "Pizza Hut",
            "Pizza Pizza"});
            this.cmbPizzaShop.Location = new System.Drawing.Point(78, 22);
            this.cmbPizzaShop.Name = "cmbPizzaShop";
            this.cmbPizzaShop.Size = new System.Drawing.Size(121, 21);
            this.cmbPizzaShop.TabIndex = 1;
            // 
            // lblPizzaShop
            // 
            this.lblPizzaShop.AutoSize = true;
            this.lblPizzaShop.Location = new System.Drawing.Point(6, 25);
            this.lblPizzaShop.Name = "lblPizzaShop";
            this.lblPizzaShop.Size = new System.Drawing.Size(66, 13);
            this.lblPizzaShop.TabIndex = 0;
            this.lblPizzaShop.Text = "Pizza Shop: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderSummary);
            this.groupBox2.Location = new System.Drawing.Point(13, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // txtOrderSummary
            // 
            this.txtOrderSummary.Location = new System.Drawing.Point(6, 19);
            this.txtOrderSummary.Multiline = true;
            this.txtOrderSummary.Name = "txtOrderSummary";
            this.txtOrderSummary.Size = new System.Drawing.Size(657, 75);
            this.txtOrderSummary.TabIndex = 0;
            // 
            // btnClearOrderSummary
            // 
            this.btnClearOrderSummary.Location = new System.Drawing.Point(19, 359);
            this.btnClearOrderSummary.Name = "btnClearOrderSummary";
            this.btnClearOrderSummary.Size = new System.Drawing.Size(150, 23);
            this.btnClearOrderSummary.TabIndex = 3;
            this.btnClearOrderSummary.Text = "Clear Order Summary";
            this.btnClearOrderSummary.UseVisualStyleBackColor = true;
            this.btnClearOrderSummary.Click += new System.EventHandler(this.btnClearOrderSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(193, 359);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total(13% HST):";
            // 
            // txtTotalHst
            // 
            this.txtTotalHst.Location = new System.Drawing.Point(633, 358);
            this.txtTotalHst.Multiline = true;
            this.txtTotalHst.Name = "txtTotalHst";
            this.txtTotalHst.ReadOnly = true;
            this.txtTotalHst.Size = new System.Drawing.Size(56, 24);
            this.txtTotalHst.TabIndex = 7;
            this.txtTotalHst.TextChanged += new System.EventHandler(this.txtTotalHst_TextChanged);
            // 
            // customerUserControl2
            // 
            this.customerUserControl2.Contact = "";
            this.customerUserControl2.CustomerName = "";
            this.customerUserControl2.DeliverAddress = "";
            this.customerUserControl2.Location = new System.Drawing.Point(13, 12);
            this.customerUserControl2.Name = "customerUserControl2";
            this.customerUserControl2.OrderNumber = "";
            this.customerUserControl2.Size = new System.Drawing.Size(294, 227);
            this.customerUserControl2.TabIndex = 1;
            // 
            // PizzaDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 434);
            this.Controls.Add(this.txtTotalHst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearOrderSummary);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.customerUserControl2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PizzaDeliveryForm";
            this.Text = "Pizza Ordering System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.ComboBox cmbPizzaShop;
        private System.Windows.Forms.Label lblPizzaShop;
        private CustomerUserControl customerUserControl2;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.Label lblPizzaTypes;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.CheckBox chkCapsicum;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.Label lblPizzaToppings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderSummary;
        private System.Windows.Forms.Button btnClearOrderSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalHst;
    }
}

