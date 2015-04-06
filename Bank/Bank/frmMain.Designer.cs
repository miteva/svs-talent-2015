namespace Bank
{
    partial class frmMain
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
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodPeriod = new System.Windows.Forms.TextBox();
            this.txtInterestPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblBalanceCurrency = new System.Windows.Forms.Label();
            this.lblLimitAmount = new System.Windows.Forms.Label();
            this.lblPeriodUnit = new System.Windows.Forms.Label();
            this.lblLimitCurrency = new System.Windows.Forms.Label();
            this.lblPeriodPeriod = new System.Windows.Forms.Label();
            this.lblInterestPercent = new System.Windows.Forms.Label();
            this.lblInterestUnit = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbPeriodUnit = new System.Windows.Forms.ComboBox();
            this.cmbInterestUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(79, 166);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(181, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(455, 330);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(162, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(141, 33);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(141, 106);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Limit";
            // 
            // txtPeriodPeriod
            // 
            this.txtPeriodPeriod.Location = new System.Drawing.Point(517, 28);
            this.txtPeriodPeriod.Name = "txtPeriodPeriod";
            this.txtPeriodPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodPeriod.TabIndex = 6;
            // 
            // txtInterestPercent
            // 
            this.txtInterestPercent.Location = new System.Drawing.Point(517, 128);
            this.txtInterestPercent.Name = "txtInterestPercent";
            this.txtInterestPercent.Size = new System.Drawing.Size(100, 20);
            this.txtInterestPercent.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Period: Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Period.Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Interest: Percent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Interest: Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(517, 233);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 16;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(517, 265);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 17;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(53, 239);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "lblId";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(53, 272);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(54, 13);
            this.lblNumber.TabIndex = 19;
            this.lblNumber.Text = "lblNumber";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(53, 304);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(59, 13);
            this.lblCurrency.TabIndex = 20;
            this.lblCurrency.Text = "lblCurrency";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Location = new System.Drawing.Point(53, 330);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(92, 13);
            this.lblBalanceAmount.TabIndex = 21;
            this.lblBalanceAmount.Text = "lblBalanceAmount";
            // 
            // lblBalanceCurrency
            // 
            this.lblBalanceCurrency.AutoSize = true;
            this.lblBalanceCurrency.Location = new System.Drawing.Point(53, 354);
            this.lblBalanceCurrency.Name = "lblBalanceCurrency";
            this.lblBalanceCurrency.Size = new System.Drawing.Size(98, 13);
            this.lblBalanceCurrency.TabIndex = 22;
            this.lblBalanceCurrency.Text = "lblBalanceCurrency";
            // 
            // lblLimitAmount
            // 
            this.lblLimitAmount.AutoSize = true;
            this.lblLimitAmount.Location = new System.Drawing.Point(167, 239);
            this.lblLimitAmount.Name = "lblLimitAmount";
            this.lblLimitAmount.Size = new System.Drawing.Size(74, 13);
            this.lblLimitAmount.TabIndex = 23;
            this.lblLimitAmount.Text = "lblLimitAmount";
            // 
            // lblPeriodUnit
            // 
            this.lblPeriodUnit.AutoSize = true;
            this.lblPeriodUnit.Location = new System.Drawing.Point(265, 265);
            this.lblPeriodUnit.Name = "lblPeriodUnit";
            this.lblPeriodUnit.Size = new System.Drawing.Size(66, 13);
            this.lblPeriodUnit.TabIndex = 24;
            this.lblPeriodUnit.Text = "lblPeriodUnit";
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(167, 272);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(80, 13);
            this.lblLimitCurrency.TabIndex = 25;
            this.lblLimitCurrency.Text = "lblLimitCurrency";
            // 
            // lblPeriodPeriod
            // 
            this.lblPeriodPeriod.AutoSize = true;
            this.lblPeriodPeriod.Location = new System.Drawing.Point(265, 240);
            this.lblPeriodPeriod.Name = "lblPeriodPeriod";
            this.lblPeriodPeriod.Size = new System.Drawing.Size(77, 13);
            this.lblPeriodPeriod.TabIndex = 26;
            this.lblPeriodPeriod.Text = "lblPeriodPeriod";
            // 
            // lblInterestPercent
            // 
            this.lblInterestPercent.AutoSize = true;
            this.lblInterestPercent.Location = new System.Drawing.Point(265, 288);
            this.lblInterestPercent.Name = "lblInterestPercent";
            this.lblInterestPercent.Size = new System.Drawing.Size(89, 13);
            this.lblInterestPercent.TabIndex = 27;
            this.lblInterestPercent.Text = "lblInterestPercent";
            // 
            // lblInterestUnit
            // 
            this.lblInterestUnit.AutoSize = true;
            this.lblInterestUnit.Location = new System.Drawing.Point(265, 315);
            this.lblInterestUnit.Name = "lblInterestUnit";
            this.lblInterestUnit.Size = new System.Drawing.Size(71, 13);
            this.lblInterestUnit.TabIndex = 28;
            this.lblInterestUnit.Text = "lblInterestUnit";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(265, 335);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 13);
            this.lblStartDate.TabIndex = 29;
            this.lblStartDate.Text = "lblStartDate";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(265, 354);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(59, 13);
            this.lblEndDate.TabIndex = 30;
            this.lblEndDate.Text = "lblEndDate";
            // 
            // cmbPeriodUnit
            // 
            this.cmbPeriodUnit.FormattingEnabled = true;
            this.cmbPeriodUnit.Location = new System.Drawing.Point(517, 80);
            this.cmbPeriodUnit.Name = "cmbPeriodUnit";
            this.cmbPeriodUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodUnit.TabIndex = 31;
            // 
            // cmbInterestUnit
            // 
            this.cmbInterestUnit.FormattingEnabled = true;
            this.cmbInterestUnit.Location = new System.Drawing.Point(517, 178);
            this.cmbInterestUnit.Name = "cmbInterestUnit";
            this.cmbInterestUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbInterestUnit.TabIndex = 32;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 397);
            this.Controls.Add(this.cmbInterestUnit);
            this.Controls.Add(this.cmbPeriodUnit);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblInterestUnit);
            this.Controls.Add(this.lblInterestPercent);
            this.Controls.Add(this.lblPeriodPeriod);
            this.Controls.Add(this.lblLimitCurrency);
            this.Controls.Add(this.lblPeriodUnit);
            this.Controls.Add(this.lblLimitAmount);
            this.Controls.Add(this.lblBalanceCurrency);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterestPercent);
            this.Controls.Add(this.txtPeriodPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriodPeriod;
        private System.Windows.Forms.TextBox txtInterestPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label lblBalanceCurrency;
        private System.Windows.Forms.Label lblLimitAmount;
        private System.Windows.Forms.Label lblPeriodUnit;
        private System.Windows.Forms.Label lblLimitCurrency;
        private System.Windows.Forms.Label lblPeriodPeriod;
        private System.Windows.Forms.Label lblInterestPercent;
        private System.Windows.Forms.Label lblInterestUnit;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cmbPeriodUnit;
        private System.Windows.Forms.ComboBox cmbInterestUnit;
    }
}

