namespace TeamBWindowsFormManagerPage
{
    partial class ManagerPage
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
            this.headerBox = new System.Windows.Forms.PictureBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmationId = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.txtLicensePlateOnFile = new System.Windows.Forms.TextBox();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnModifyReservation = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtSpaceIdentifierNumber = new System.Windows.Forms.TextBox();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMonthyContract = new System.Windows.Forms.TextBox();
            this.txtReservationId = new System.Windows.Forms.TextBox();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerBox
            // 
            this.headerBox.Image = global::TeamBWindowsFormManagerPage.Properties.Resources.parkalot;
            this.headerBox.Location = new System.Drawing.Point(2, -2);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(654, 165);
            this.headerBox.TabIndex = 0;
            this.headerBox.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(447, 229);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(190, 42);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find Reservation";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lookup Customer By Reservation ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmation ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lot Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Credit Card Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "License Plate on File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // txtConfirmationId
            // 
            this.txtConfirmationId.Enabled = false;
            this.txtConfirmationId.Location = new System.Drawing.Point(200, 317);
            this.txtConfirmationId.Name = "txtConfirmationId";
            this.txtConfirmationId.Size = new System.Drawing.Size(112, 26);
            this.txtConfirmationId.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(147, 380);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(112, 26);
            this.txtLastName.TabIndex = 14;
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Enabled = false;
            this.txtLotNumber.Location = new System.Drawing.Point(542, 315);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(94, 26);
            this.txtLotNumber.TabIndex = 15;
            // 
            // txtLicensePlateOnFile
            // 
            this.txtLicensePlateOnFile.Enabled = false;
            this.txtLicensePlateOnFile.Location = new System.Drawing.Point(514, 383);
            this.txtLicensePlateOnFile.Name = "txtLicensePlateOnFile";
            this.txtLicensePlateOnFile.Size = new System.Drawing.Size(112, 26);
            this.txtLicensePlateOnFile.TabIndex = 16;
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Enabled = false;
            this.txtCreditCardNumber.Location = new System.Drawing.Point(246, 418);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(188, 26);
            this.txtCreditCardNumber.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(128, 458);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 26);
            this.txtUsername.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(405, 462);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 26);
            this.txtPassword.TabIndex = 19;
            // 
            // btnModifyReservation
            // 
            this.btnModifyReservation.Enabled = false;
            this.btnModifyReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyReservation.Location = new System.Drawing.Point(38, 632);
            this.btnModifyReservation.Name = "btnModifyReservation";
            this.btnModifyReservation.Size = new System.Drawing.Size(280, 42);
            this.btnModifyReservation.TabIndex = 23;
            this.btnModifyReservation.Text = "Modify Reservation";
            this.btnModifyReservation.UseVisualStyleBackColor = true;
            this.btnModifyReservation.Click += new System.EventHandler(this.btnModifyReservation_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Start time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(426, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "End Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 735);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Space Identifier Number";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(81, 534);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(112, 26);
            this.txtDate.TabIndex = 29;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(320, 534);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(98, 26);
            this.txtStartTime.TabIndex = 30;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Enabled = false;
            this.txtEndTime.Location = new System.Drawing.Point(546, 534);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(98, 26);
            this.txtEndTime.TabIndex = 31;
            // 
            // txtSpaceIdentifierNumber
            // 
            this.txtSpaceIdentifierNumber.Enabled = false;
            this.txtSpaceIdentifierNumber.Location = new System.Drawing.Point(462, 735);
            this.txtSpaceIdentifierNumber.Name = "txtSpaceIdentifierNumber";
            this.txtSpaceIdentifierNumber.Size = new System.Drawing.Size(112, 26);
            this.txtSpaceIdentifierNumber.TabIndex = 33;
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Enabled = false;
            this.btnUpdateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservation.Location = new System.Drawing.Point(165, 782);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(339, 43);
            this.btnUpdateReservation.TabIndex = 35;
            this.btnUpdateReservation.Text = "Update Reservation Information";
            this.btnUpdateReservation.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 848);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 29);
            this.label14.TabIndex = 36;
            this.label14.Text = "Monthly Contract?";
            // 
            // txtMonthyContract
            // 
            this.txtMonthyContract.Enabled = false;
            this.txtMonthyContract.Location = new System.Drawing.Point(246, 851);
            this.txtMonthyContract.Name = "txtMonthyContract";
            this.txtMonthyContract.Size = new System.Drawing.Size(112, 26);
            this.txtMonthyContract.TabIndex = 37;
            // 
            // txtReservationId
            // 
            this.txtReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationId.Location = new System.Drawing.Point(39, 229);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.Size = new System.Drawing.Size(360, 35);
            this.txtReservationId.TabIndex = 34;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(363, 632);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(266, 42);
            this.btnDeleteReservation.TabIndex = 38;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 931);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.txtMonthyContract);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.txtReservationId);
            this.Controls.Add(this.txtSpaceIdentifierNumber);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnModifyReservation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.txtLicensePlateOnFile);
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtConfirmationId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.headerBox);
            this.Name = "ManagerPage";
            this.Text = "Manager Page";
            this.Load += new System.EventHandler(this.ManagerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerBox;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmationId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.TextBox txtLicensePlateOnFile;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnModifyReservation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtSpaceIdentifierNumber;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMonthyContract;
        private System.Windows.Forms.TextBox txtReservationId;
        private System.Windows.Forms.Button btnDeleteReservation;
    }
}

