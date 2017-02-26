namespace Ishan_Sharma_Test_01_Ex_01
{
    partial class CustomerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeliverAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomerDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateCustomerDetails);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtDeliveryAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtOrderNumber);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.lblDeliverAddress);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblOrderNumber);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(19, 33);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(79, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblDeliverAddress
            // 
            this.lblDeliverAddress.AutoSize = true;
            this.lblDeliverAddress.Location = new System.Drawing.Point(19, 90);
            this.lblDeliverAddress.Name = "lblDeliverAddress";
            this.lblDeliverAddress.Size = new System.Drawing.Size(92, 13);
            this.lblDeliverAddress.TabIndex = 2;
            this.lblDeliverAddress.Text = "Delivery Address: ";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(22, 119);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(50, 13);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact: ";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(117, 30);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(117, 87);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryAddress.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(117, 116);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 7;
            // 
            // btnUpdateCustomerDetails
            // 
            this.btnUpdateCustomerDetails.Location = new System.Drawing.Point(44, 153);
            this.btnUpdateCustomerDetails.Name = "btnUpdateCustomerDetails";
            this.btnUpdateCustomerDetails.Size = new System.Drawing.Size(164, 23);
            this.btnUpdateCustomerDetails.TabIndex = 8;
            this.btnUpdateCustomerDetails.Text = "Update Customer Details";
            this.btnUpdateCustomerDetails.UseVisualStyleBackColor = true;
            // 
            // CustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(294, 227);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateCustomerDetails;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDeliverAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrderNumber;
    }
}
