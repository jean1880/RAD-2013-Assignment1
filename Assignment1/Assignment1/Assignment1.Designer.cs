namespace Assignment1
{
    partial class employeeEarnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeEarnings));
            this.firstName = new System.Windows.Forms.TextBox();
            this.totalHours = new System.Windows.Forms.TextBox();
            this.employeeID = new System.Windows.Forms.TextBox();
            this.totalSales = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.employNameLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.languageSelection = new System.Windows.Forms.GroupBox();
            this.frenchButton = new System.Windows.Forms.RadioButton();
            this.englishButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.salesBonus = new System.Windows.Forms.TextBox();
            this.salesBonusLabel = new System.Windows.Forms.Label();
            this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languageSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(304, 33);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(84, 20);
            this.firstName.TabIndex = 0;
            // 
            // totalHours
            // 
            this.totalHours.Location = new System.Drawing.Point(304, 85);
            this.totalHours.Name = "totalHours";
            this.totalHours.Size = new System.Drawing.Size(174, 20);
            this.totalHours.TabIndex = 3;
            // 
            // employeeID
            // 
            this.employeeID.Location = new System.Drawing.Point(304, 59);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(174, 20);
            this.employeeID.TabIndex = 2;
            // 
            // totalSales
            // 
            this.totalSales.Location = new System.Drawing.Point(304, 111);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(174, 20);
            this.totalSales.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(394, 33);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(84, 20);
            this.lastName.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(304, 14);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(394, 13);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // employNameLabel
            // 
            this.employNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employNameLabel.AutoSize = true;
            this.employNameLabel.Location = new System.Drawing.Point(158, 36);
            this.employNameLabel.Name = "employNameLabel";
            this.employNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employNameLabel.TabIndex = 7;
            this.employNameLabel.Text = "Employee Name";
            this.employNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(158, 62);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.employeeIDLabel.Size = new System.Drawing.Size(77, 13);
            this.employeeIDLabel.TabIndex = 8;
            this.employeeIDLabel.Text = "Employee ID #";
            this.employeeIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(158, 88);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hoursWorkedLabel.Size = new System.Drawing.Size(103, 13);
            this.hoursWorkedLabel.TabIndex = 9;
            this.hoursWorkedLabel.Text = "Total Hours Worked";
            this.hoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hoursWorkedLabel.UseMnemonic = false;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Location = new System.Drawing.Point(158, 114);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalSalesLabel.Size = new System.Drawing.Size(95, 13);
            this.totalSalesLabel.TabIndex = 10;
            this.totalSalesLabel.Text = "Store\'s Total Sales";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // languageSelection
            // 
            this.languageSelection.Controls.Add(this.frenchButton);
            this.languageSelection.Controls.Add(this.englishButton);
            this.languageSelection.Location = new System.Drawing.Point(7, 81);
            this.languageSelection.Name = "languageSelection";
            this.languageSelection.Size = new System.Drawing.Size(145, 73);
            this.languageSelection.TabIndex = 11;
            this.languageSelection.TabStop = false;
            this.languageSelection.Text = "Languages";
            // 
            // frenchButton
            // 
            this.frenchButton.AutoSize = true;
            this.frenchButton.Location = new System.Drawing.Point(19, 44);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(65, 17);
            this.frenchButton.TabIndex = 1;
            this.frenchButton.Text = "Français";
            this.frenchButton.UseVisualStyleBackColor = true;
            this.frenchButton.CheckedChanged += new System.EventHandler(this.frenchButton_CheckedChanged);
            // 
            // englishButton
            // 
            this.englishButton.AutoSize = true;
            this.englishButton.Checked = true;
            this.englishButton.Location = new System.Drawing.Point(19, 22);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(59, 17);
            this.englishButton.TabIndex = 0;
            this.englishButton.TabStop = true;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.CheckedChanged += new System.EventHandler(this.englishButton_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(322, 166);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(39, 166);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(403, 166);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // salesBonus
            // 
            this.salesBonus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salesBonus.Enabled = false;
            this.salesBonus.Location = new System.Drawing.Point(304, 138);
            this.salesBonus.Name = "salesBonus";
            this.salesBonus.ReadOnly = true;
            this.salesBonus.Size = new System.Drawing.Size(174, 20);
            this.salesBonus.TabIndex = 15;
            // 
            // salesBonusLabel
            // 
            this.salesBonusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesBonusLabel.AutoSize = true;
            this.salesBonusLabel.Location = new System.Drawing.Point(158, 141);
            this.salesBonusLabel.Name = "salesBonusLabel";
            this.salesBonusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salesBonusLabel.Size = new System.Drawing.Size(115, 13);
            this.salesBonusLabel.TabIndex = 16;
            this.salesBonusLabel.Text = "Employee Sales Bonus";
            this.salesBonusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printForm
            // 
            this.printForm.DocumentName = "document";
            this.printForm.Form = this;
            this.printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm.PrinterSettings")));
            this.printForm.PrintFileName = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // employeeEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(490, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salesBonusLabel);
            this.Controls.Add(this.salesBonus);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.languageSelection);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.totalHours);
            this.Controls.Add(this.firstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "employeeEarnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Earnings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.languageSelection.ResumeLayout(false);
            this.languageSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox totalHours;
        private System.Windows.Forms.TextBox employeeID;
        private System.Windows.Forms.TextBox totalSales;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label employNameLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.GroupBox languageSelection;
        private System.Windows.Forms.RadioButton frenchButton;
        private System.Windows.Forms.RadioButton englishButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox salesBonus;
        private System.Windows.Forms.Label salesBonusLabel;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

