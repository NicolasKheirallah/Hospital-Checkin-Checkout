namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonNewPatient = new System.Windows.Forms.Button();
            this.listPatient = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.grpRoomInfo = new System.Windows.Forms.GroupBox();
            this.labelFreeRooms = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpDatesInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpRoomInfo.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpDatesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewPatient
            // 
            this.buttonNewPatient.Location = new System.Drawing.Point(203, 301);
            this.buttonNewPatient.Name = "buttonNewPatient";
            this.buttonNewPatient.Size = new System.Drawing.Size(88, 25);
            this.buttonNewPatient.TabIndex = 0;
            this.buttonNewPatient.Text = "New customer";
            this.buttonNewPatient.UseVisualStyleBackColor = true;
            this.buttonNewPatient.Click += new System.EventHandler(this.buttonNewCustomer_Click);
            // 
            // listPatient
            // 
            this.listPatient.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listPatient.FormattingEnabled = true;
            this.listPatient.ItemHeight = 16;
            this.listPatient.Location = new System.Drawing.Point(180, 30);
            this.listPatient.Name = "listPatient";
            this.listPatient.Size = new System.Drawing.Size(480, 244);
            this.listPatient.TabIndex = 1;
            this.listPatient.SelectedIndexChanged += new System.EventHandler(this.lastSavedInformation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Check in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Category";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(712, 301);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 25);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(485, 301);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 25);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(391, 301);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 25);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // grpRoomInfo
            // 
            this.grpRoomInfo.Controls.Add(this.labelFreeRooms);
            this.grpRoomInfo.Controls.Add(this.label5);
            this.grpRoomInfo.Controls.Add(this.labelCategory);
            this.grpRoomInfo.Controls.Add(this.label6);
            this.grpRoomInfo.Location = new System.Drawing.Point(9, 186);
            this.grpRoomInfo.Name = "grpRoomInfo";
            this.grpRoomInfo.Size = new System.Drawing.Size(165, 88);
            this.grpRoomInfo.TabIndex = 16;
            this.grpRoomInfo.TabStop = false;
            this.grpRoomInfo.Text = "Room Information";
            // 
            // labelFreeRooms
            // 
            this.labelFreeRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFreeRooms.Location = new System.Drawing.Point(69, 54);
            this.labelFreeRooms.Name = "labelFreeRooms";
            this.labelFreeRooms.Size = new System.Drawing.Size(81, 23);
            this.labelFreeRooms.TabIndex = 15;
            this.labelFreeRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Availability";
            // 
            // labelCategory
            // 
            this.labelCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCategory.Location = new System.Drawing.Point(69, 21);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 23);
            this.labelCategory.TabIndex = 13;
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.LabelID);
            this.grpCustomerInfo.Controls.Add(this.labelName);
            this.grpCustomerInfo.Controls.Add(this.label14);
            this.grpCustomerInfo.Controls.Add(this.label13);
            this.grpCustomerInfo.Location = new System.Drawing.Point(9, 27);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(165, 82);
            this.grpCustomerInfo.TabIndex = 13;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Patient Information";
            // 
            // LabelID
            // 
            this.LabelID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelID.Location = new System.Drawing.Point(47, 56);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(112, 23);
            this.LabelID.TabIndex = 6;
            this.LabelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName.Location = new System.Drawing.Point(47, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 23);
            this.labelName.TabIndex = 5;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "ID ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Name";
            // 
            // grpDatesInfo
            // 
            this.grpDatesInfo.Controls.Add(this.label8);
            this.grpDatesInfo.Controls.Add(this.labelDays);
            this.grpDatesInfo.Location = new System.Drawing.Point(9, 115);
            this.grpDatesInfo.Name = "grpDatesInfo";
            this.grpDatesInfo.Size = new System.Drawing.Size(165, 75);
            this.grpDatesInfo.TabIndex = 12;
            this.grpDatesInfo.TabStop = false;
            this.grpDatesInfo.Text = "Days In hospital";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Days";
            // 
            // labelDays
            // 
            this.labelDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDays.Location = new System.Drawing.Point(69, 32);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(81, 23);
            this.labelDays.TabIndex = 13;
            this.labelDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(297, 301);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(88, 25);
            this.buttonShowInfo.TabIndex = 18;
            this.buttonShowInfo.Text = "More Info";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Enterprise  Infirmary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Project.Properties.Resources.medical;
            this.pictureBox1.Location = new System.Drawing.Point(676, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpRoomInfo);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNewPatient);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.grpDatesInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enterprise Medical Infirmary";
            this.grpRoomInfo.ResumeLayout(false);
            this.grpRoomInfo.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpDatesInfo.ResumeLayout(false);
            this.grpDatesInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewPatient;
        private System.Windows.Forms.ListBox listPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox grpRoomInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox grpDatesInfo;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.Label labelFreeRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

