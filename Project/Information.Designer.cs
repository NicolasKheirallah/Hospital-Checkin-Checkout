namespace Project
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.buttonOkey = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.grbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grbDates = new System.Windows.Forms.GroupBox();
            this.dateTimeCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbCategory = new System.Windows.Forms.GroupBox();
            this.cmbRoomCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbContactInfo = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.grbCustomerInfo.SuspendLayout();
            this.grbDates.SuspendLayout();
            this.grbCategory.SuspendLayout();
            this.grbContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(95, 31);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(382, 20);
            this.textFirstName.TabIndex = 3;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(95, 19);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(382, 20);
            this.textPhoneNumber.TabIndex = 2;
            this.textPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhoneNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID number *";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(95, 85);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(382, 20);
            this.textId.TabIndex = 5;
            // 
            // buttonOkey
            // 
            this.buttonOkey.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkey.Location = new System.Drawing.Point(34, 371);
            this.buttonOkey.Name = "buttonOkey";
            this.buttonOkey.Size = new System.Drawing.Size(200, 35);
            this.buttonOkey.TabIndex = 4;
            this.buttonOkey.Text = "OK";
            this.buttonOkey.UseVisualStyleBackColor = true;
            this.buttonOkey.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(289, 371);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 35);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // grbCustomerInfo
            // 
            this.grbCustomerInfo.Controls.Add(this.textLastName);
            this.grbCustomerInfo.Controls.Add(this.label4);
            this.grbCustomerInfo.Controls.Add(this.textFirstName);
            this.grbCustomerInfo.Controls.Add(this.label1);
            this.grbCustomerInfo.Controls.Add(this.textId);
            this.grbCustomerInfo.Controls.Add(this.label3);
            this.grbCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.grbCustomerInfo.Name = "grbCustomerInfo";
            this.grbCustomerInfo.Size = new System.Drawing.Size(502, 119);
            this.grbCustomerInfo.TabIndex = 0;
            this.grbCustomerInfo.TabStop = false;
            this.grbCustomerInfo.Text = "Patient Information";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(95, 58);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(382, 20);
            this.textLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name *";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(95, 46);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(382, 20);
            this.textEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // grbDates
            // 
            this.grbDates.Controls.Add(this.dateTimeCheckOut);
            this.grbDates.Controls.Add(this.dateTimeCheckIn);
            this.grbDates.Controls.Add(this.label6);
            this.grbDates.Controls.Add(this.label5);
            this.grbDates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDates.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grbDates.Location = new System.Drawing.Point(12, 217);
            this.grbDates.Name = "grbDates";
            this.grbDates.Size = new System.Drawing.Size(502, 73);
            this.grbDates.TabIndex = 2;
            this.grbDates.TabStop = false;
            this.grbDates.Text = "Reservation Dates";
            // 
            // dateTimeCheckOut
            // 
            this.dateTimeCheckOut.Location = new System.Drawing.Point(95, 45);
            this.dateTimeCheckOut.Name = "dateTimeCheckOut";
            this.dateTimeCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCheckOut.TabIndex = 3;
            this.dateTimeCheckOut.ValueChanged += new System.EventHandler(this.dateTime_CheckOut_ValueChanged);
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Location = new System.Drawing.Point(95, 19);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCheckIn.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Check Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Check In";
            // 
            // grbCategory
            // 
            this.grbCategory.Controls.Add(this.cmbRoomCategory);
            this.grbCategory.Controls.Add(this.label7);
            this.grbCategory.Location = new System.Drawing.Point(12, 296);
            this.grbCategory.Name = "grbCategory";
            this.grbCategory.Size = new System.Drawing.Size(502, 52);
            this.grbCategory.TabIndex = 3;
            this.grbCategory.TabStop = false;
            this.grbCategory.Text = "Medical Catagory";
            // 
            // cmbRoomCategory
            // 
            this.cmbRoomCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomCategory.FormattingEnabled = true;
            this.cmbRoomCategory.Location = new System.Drawing.Point(95, 23);
            this.cmbRoomCategory.Name = "cmbRoomCategory";
            this.cmbRoomCategory.Size = new System.Drawing.Size(382, 21);
            this.cmbRoomCategory.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Medicial Reason";
            // 
            // grbContactInfo
            // 
            this.grbContactInfo.Controls.Add(this.textEmail);
            this.grbContactInfo.Controls.Add(this.lblEmail);
            this.grbContactInfo.Controls.Add(this.label2);
            this.grbContactInfo.Controls.Add(this.textPhoneNumber);
            this.grbContactInfo.Location = new System.Drawing.Point(12, 137);
            this.grbContactInfo.Name = "grbContactInfo";
            this.grbContactInfo.Size = new System.Drawing.Size(502, 74);
            this.grbContactInfo.TabIndex = 1;
            this.grbContactInfo.TabStop = false;
            this.grbContactInfo.Text = "Patient Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = " * required too input";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbContactInfo);
            this.Controls.Add(this.grbCategory);
            this.Controls.Add(this.grbDates);
            this.Controls.Add(this.grbCustomerInfo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOkey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformationForm_FormClosing);
            this.grbCustomerInfo.ResumeLayout(false);
            this.grbCustomerInfo.PerformLayout();
            this.grbDates.ResumeLayout(false);
            this.grbDates.PerformLayout();
            this.grbCategory.ResumeLayout(false);
            this.grbCategory.PerformLayout();
            this.grbContactInfo.ResumeLayout(false);
            this.grbContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button buttonOkey;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox grbCustomerInfo;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.GroupBox grbDates;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoomCategory;
        private System.Windows.Forms.GroupBox grbContactInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
    }
}