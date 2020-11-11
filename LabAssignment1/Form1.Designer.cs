namespace LabAssignment1
{
    partial class kWLabelInd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kWLabelInd));
            this.kWLabelRes = new System.Windows.Forms.Label();
            this.kWTextBox = new System.Windows.Forms.TextBox();
            this.chargeLabel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kWOffLabel = new System.Windows.Forms.Label();
            this.kWOffTxtBox = new System.Windows.Forms.TextBox();
            this.peakHoursLabel = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.listCustomers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblI1 = new System.Windows.Forms.Label();
            this.lblSum1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblI2 = new System.Windows.Forms.Label();
            this.lblSum2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kWLabelRes
            // 
            this.kWLabelRes.AutoSize = true;
            this.kWLabelRes.BackColor = System.Drawing.SystemColors.ControlText;
            this.kWLabelRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kWLabelRes.Location = new System.Drawing.Point(33, 58);
            this.kWLabelRes.Name = "kWLabelRes";
            this.kWLabelRes.Size = new System.Drawing.Size(90, 15);
            this.kWLabelRes.TabIndex = 0;
            this.kWLabelRes.Text = "Enter kWh Used";
            // 
            // kWTextBox
            // 
            this.kWTextBox.Location = new System.Drawing.Point(129, 55);
            this.kWTextBox.Name = "kWTextBox";
            this.kWTextBox.Size = new System.Drawing.Size(100, 23);
            this.kWTextBox.TabIndex = 2;
            this.kWTextBox.Tag = "kWh";
            this.kWTextBox.Enter += new System.EventHandler(this.kWTextBox_Enter);
            // 
            // chargeLabel
            // 
            this.chargeLabel.AutoSize = true;
            this.chargeLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chargeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chargeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chargeLabel.Location = new System.Drawing.Point(129, 108);
            this.chargeLabel.Name = "chargeLabel";
            this.chargeLabel.Size = new System.Drawing.Size(164, 27);
            this.chargeLabel.TabIndex = 2;
            this.chargeLabel.Text = "                              ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 112);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(373, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(373, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerLabel.Location = new System.Drawing.Point(7, 27);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(116, 15);
            this.CustomerLabel.TabIndex = 10;
            this.CustomerLabel.Text = "Enter Customer Type";
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerTextBox.Location = new System.Drawing.Point(129, 24);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(100, 23);
            this.CustomerTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(235, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "(R for Residential, C for Commercial, I for Industrial)";
            // 
            // kWOffLabel
            // 
            this.kWOffLabel.AutoSize = true;
            this.kWOffLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kWOffLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kWOffLabel.Location = new System.Drawing.Point(12, 87);
            this.kWOffLabel.Name = "kWOffLabel";
            this.kWOffLabel.Size = new System.Drawing.Size(111, 15);
            this.kWOffLabel.TabIndex = 13;
            this.kWOffLabel.Text = "Enter Off-Peak kWh";
            // 
            // kWOffTxtBox
            // 
            this.kWOffTxtBox.Location = new System.Drawing.Point(129, 84);
            this.kWOffTxtBox.Name = "kWOffTxtBox";
            this.kWOffTxtBox.Size = new System.Drawing.Size(100, 23);
            this.kWOffTxtBox.TabIndex = 3;
            this.kWOffTxtBox.Tag = "Off Peak kWh";
            // 
            // peakHoursLabel
            // 
            this.peakHoursLabel.AutoSize = true;
            this.peakHoursLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peakHoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.peakHoursLabel.Location = new System.Drawing.Point(235, 58);
            this.peakHoursLabel.Name = "peakHoursLabel";
            this.peakHoursLabel.Size = new System.Drawing.Size(196, 15);
            this.peakHoursLabel.TabIndex = 14;
            this.peakHoursLabel.Text = "(Peak Hours Only - Enter \'0\' if none)";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(129, 164);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 23);
            this.txtAccount.TabIndex = 5;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAccount.Location = new System.Drawing.Point(24, 167);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(99, 15);
            this.lblAccount.TabIndex = 16;
            this.lblAccount.Text = "Account Number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCustomerName.Location = new System.Drawing.Point(29, 196);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(94, 15);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(129, 193);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtCharge
            // 
            this.txtCharge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCharge.Location = new System.Drawing.Point(129, 222);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.ReadOnly = true;
            this.txtCharge.Size = new System.Drawing.Size(100, 23);
            this.txtCharge.TabIndex = 19;
            this.txtCharge.TabStop = false;
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCharge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCharge.Location = new System.Drawing.Point(31, 225);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(92, 15);
            this.lblCharge.TabIndex = 20;
            this.lblCharge.Text = "Charge Amount";
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCount1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCount1.Location = new System.Drawing.Point(65, 309);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(139, 25);
            this.lblCount1.TabIndex = 21;
            this.lblCount1.Text = "# of Customers";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblR1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblR1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblR1.Location = new System.Drawing.Point(65, 351);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(142, 25);
            this.lblR1.TabIndex = 22;
            this.lblR1.Text = "Total R Charges";
            // 
            // listCustomers
            // 
            this.listCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCustomers.FormattingEnabled = true;
            this.listCustomers.ItemHeight = 24;
            this.listCustomers.Location = new System.Drawing.Point(454, 149);
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.Size = new System.Drawing.Size(338, 196);
            this.listCustomers.TabIndex = 25;
            this.listCustomers.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(373, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(373, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDelete.Location = new System.Drawing.Point(305, 236);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(143, 15);
            this.lblDelete.TabIndex = 29;
            this.lblDelete.Text = "Select Customer to Delete";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblC1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblC1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblC1.Location = new System.Drawing.Point(61, 380);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(143, 25);
            this.lblC1.TabIndex = 30;
            this.lblC1.Text = "Total C Charges";
            // 
            // lblI1
            // 
            this.lblI1.AutoSize = true;
            this.lblI1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblI1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblI1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblI1.Location = new System.Drawing.Point(71, 409);
            this.lblI1.Name = "lblI1";
            this.lblI1.Size = new System.Drawing.Size(136, 25);
            this.lblI1.TabIndex = 32;
            this.lblI1.Text = "Total I Charges";
            // 
            // lblSum1
            // 
            this.lblSum1.AutoSize = true;
            this.lblSum1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSum1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSum1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSum1.Location = new System.Drawing.Point(35, 453);
            this.lblSum1.Name = "lblSum1";
            this.lblSum1.Size = new System.Drawing.Size(172, 25);
            this.lblSum1.TabIndex = 34;
            this.lblSum1.Text = "Sum of All Charges";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCount2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount2.Location = new System.Drawing.Point(210, 309);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(74, 27);
            this.lblCount2.TabIndex = 35;
            this.lblCount2.Text = "            ";
            this.lblCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblR2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblR2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblR2.Location = new System.Drawing.Point(210, 351);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(74, 27);
            this.lblR2.TabIndex = 36;
            this.lblR2.Text = "            ";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblC2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblC2.Location = new System.Drawing.Point(210, 380);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(74, 27);
            this.lblC2.TabIndex = 37;
            this.lblC2.Text = "            ";
            // 
            // lblI2
            // 
            this.lblI2.AutoSize = true;
            this.lblI2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblI2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblI2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblI2.Location = new System.Drawing.Point(210, 409);
            this.lblI2.Name = "lblI2";
            this.lblI2.Size = new System.Drawing.Size(74, 27);
            this.lblI2.TabIndex = 38;
            this.lblI2.Text = "            ";
            // 
            // lblSum2
            // 
            this.lblSum2.AutoSize = true;
            this.lblSum2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSum2.Location = new System.Drawing.Point(211, 453);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(74, 27);
            this.lblSum2.TabIndex = 39;
            this.lblSum2.Text = "            ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(528, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Customers:";
            // 
            // kWLabelInd
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(794, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSum2);
            this.Controls.Add(this.lblI2);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblSum1);
            this.Controls.Add(this.lblI1);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listCustomers);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.peakHoursLabel);
            this.Controls.Add(this.kWOffTxtBox);
            this.Controls.Add(this.kWOffLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerTextBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chargeLabel);
            this.Controls.Add(this.kWTextBox);
            this.Controls.Add(this.kWLabelRes);
            this.Name = "kWLabelInd";
            this.Text = "Enter kWh Used";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kWLabelInd_FormClosing);
            this.Load += new System.EventHandler(this.kWLabelInd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kWLabelRes;
        private System.Windows.Forms.TextBox kWTextBox;
        private System.Windows.Forms.Label chargeLabel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kWOffLabel;
        private System.Windows.Forms.TextBox kWOffTxtBox;
        private System.Windows.Forms.Label peakHoursLabel;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.ListBox listCustomers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblI1;
        private System.Windows.Forms.Label lblSum1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblI2;
        private System.Windows.Forms.Label lblSum2;
        private System.Windows.Forms.Label label2;
    }
}

