﻿namespace TeamBWindowsFormEmployeePage
{
    partial class EmployeePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.radMembershipNumber = new System.Windows.Forms.RadioButton();
            this.radReservationNumber = new System.Windows.Forms.RadioButton();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lstInformation = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckSpaces = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerBox
            // 
            this.headerBox.Image = global::TeamBWindowsFormEmployeePage.Properties.Resources.parkalot;
            this.headerBox.Location = new System.Drawing.Point(0, -2);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(597, 165);
            this.headerBox.TabIndex = 0;
            this.headerBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Reservation By:";
            // 
            // radMembershipNumber
            // 
            this.radMembershipNumber.AutoSize = true;
            this.radMembershipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMembershipNumber.Location = new System.Drawing.Point(286, 200);
            this.radMembershipNumber.Name = "radMembershipNumber";
            this.radMembershipNumber.Size = new System.Drawing.Size(219, 29);
            this.radMembershipNumber.TabIndex = 2;
            this.radMembershipNumber.TabStop = true;
            this.radMembershipNumber.Text = "Membership Number";
            this.radMembershipNumber.UseVisualStyleBackColor = true;
            // 
            // radReservationNumber
            // 
            this.radReservationNumber.AutoSize = true;
            this.radReservationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReservationNumber.Location = new System.Drawing.Point(286, 237);
            this.radReservationNumber.Name = "radReservationNumber";
            this.radReservationNumber.Size = new System.Drawing.Size(214, 29);
            this.radReservationNumber.TabIndex = 3;
            this.radReservationNumber.TabStop = true;
            this.radReservationNumber.Text = "Reservation Number";
            this.radReservationNumber.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(99, 231);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(112, 35);
            this.txtNumber.TabIndex = 4;
            // 
            // lstInformation
            // 
            this.lstInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInformation.FormattingEnabled = true;
            this.lstInformation.ItemHeight = 25;
            this.lstInformation.Location = new System.Drawing.Point(26, 345);
            this.lstInformation.Name = "lstInformation";
            this.lstInformation.Size = new System.Drawing.Size(541, 79);
            this.lstInformation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmation #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Space #";
            // 
            // btnCheckSpaces
            // 
            this.btnCheckSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSpaces.Location = new System.Drawing.Point(75, 483);
            this.btnCheckSpaces.Name = "btnCheckSpaces";
            this.btnCheckSpaces.Size = new System.Drawing.Size(285, 43);
            this.btnCheckSpaces.TabIndex = 11;
            this.btnCheckSpaces.Text = "Are Spaces Available?";
            this.btnCheckSpaces.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(424, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 43);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 569);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckSpaces);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInformation);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.radReservationNumber);
            this.Controls.Add(this.radMembershipNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerBox);
            this.Name = "EmployeePage";
            this.Text = "Employee Page";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radMembershipNumber;
        private System.Windows.Forms.RadioButton radReservationNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ListBox lstInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckSpaces;
        private System.Windows.Forms.Button btnClear;
    }
}

