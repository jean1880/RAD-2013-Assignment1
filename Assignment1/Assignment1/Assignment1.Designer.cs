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
            this.errorBox = new System.Windows.Forms.TextBox();
            this.languageSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstName.Location = new System.Drawing.Point(342, 33);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(84, 20);
            this.firstName.TabIndex = 0;
            // 
            // totalHours
            // 
            this.totalHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalHours.Location = new System.Drawing.Point(342, 85);
            this.totalHours.Name = "totalHours";
            this.totalHours.Size = new System.Drawing.Size(174, 20);
            this.totalHours.TabIndex = 3;
            // 
            // employeeID
            // 
            this.employeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeID.Location = new System.Drawing.Point(342, 59);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(174, 20);
            this.employeeID.TabIndex = 2;
            // 
            // totalSales
            // 
            this.totalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSales.Location = new System.Drawing.Point(342, 111);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(174, 20);
            this.totalSales.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastName.Location = new System.Drawing.Point(432, 33);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(84, 20);
            this.lastName.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(342, 14);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(73, 16);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(432, 13);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(73, 16);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // employNameLabel
            // 
            this.employNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employNameLabel.AutoSize = true;
            this.employNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employNameLabel.ForeColor = System.Drawing.Color.White;
            this.employNameLabel.Location = new System.Drawing.Point(158, 33);
            this.employNameLabel.Name = "employNameLabel";
            this.employNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employNameLabel.Size = new System.Drawing.Size(118, 18);
            this.employNameLabel.TabIndex = 7;
            this.employNameLabel.Text = "Employee Name";
            this.employNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIDLabel.Location = new System.Drawing.Point(158, 59);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.employeeIDLabel.Size = new System.Drawing.Size(104, 18);
            this.employeeIDLabel.TabIndex = 8;
            this.employeeIDLabel.Text = "Employee ID #";
            this.employeeIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.ForeColor = System.Drawing.Color.White;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(158, 85);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hoursWorkedLabel.Size = new System.Drawing.Size(143, 18);
            this.hoursWorkedLabel.TabIndex = 9;
            this.hoursWorkedLabel.Text = "Total Hours Worked";
            this.hoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hoursWorkedLabel.UseMnemonic = false;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.ForeColor = System.Drawing.Color.White;
            this.totalSalesLabel.Location = new System.Drawing.Point(158, 111);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalSalesLabel.Size = new System.Drawing.Size(133, 18);
            this.totalSalesLabel.TabIndex = 10;
            this.totalSalesLabel.Text = "Store\'s Total Sales";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // languageSelection
            // 
            this.languageSelection.Controls.Add(this.frenchButton);
            this.languageSelection.Controls.Add(this.englishButton);
            this.languageSelection.ForeColor = System.Drawing.Color.White;
            this.languageSelection.Location = new System.Drawing.Point(7, 81);
            this.languageSelection.Name = "languageSelection";
            this.languageSelection.Size = new System.Drawing.Size(145, 93);
            this.languageSelection.TabIndex = 11;
            this.languageSelection.TabStop = false;
            this.languageSelection.Text = "Languages";
            // 
            // frenchButton
            // 
            this.frenchButton.AutoSize = true;
            this.frenchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchButton.ForeColor = System.Drawing.Color.White;
            this.frenchButton.Location = new System.Drawing.Point(19, 55);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(83, 22);
            this.frenchButton.TabIndex = 1;
            this.frenchButton.Text = "Français";
            this.frenchButton.UseVisualStyleBackColor = true;
            this.frenchButton.CheckedChanged += new System.EventHandler(this.frenchButton_CheckedChanged);
            // 
            // englishButton
            // 
            this.englishButton.AutoSize = true;
            this.englishButton.Checked = true;
            this.englishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.ForeColor = System.Drawing.Color.White;
            this.englishButton.Location = new System.Drawing.Point(19, 22);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(74, 22);
            this.englishButton.TabIndex = 0;
            this.englishButton.TabStop = true;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.CheckedChanged += new System.EventHandler(this.englishButton_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(342, 180);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(10, 180);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "&Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.DarkGray;
            this.nextButton.Enabled = false;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(441, 180);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "&Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // salesBonus
            // 
            this.salesBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salesBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesBonus.Enabled = false;
            this.salesBonus.Location = new System.Drawing.Point(342, 138);
            this.salesBonus.Name = "salesBonus";
            this.salesBonus.ReadOnly = true;
            this.salesBonus.Size = new System.Drawing.Size(174, 20);
            this.salesBonus.TabIndex = 15;
            // 
            // salesBonusLabel
            // 
            this.salesBonusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesBonusLabel.AutoSize = true;
            this.salesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBonusLabel.ForeColor = System.Drawing.Color.White;
            this.salesBonusLabel.Location = new System.Drawing.Point(158, 138);
            this.salesBonusLabel.Name = "salesBonusLabel";
            this.salesBonusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salesBonusLabel.Size = new System.Drawing.Size(162, 18);
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
            this.pictureBox1.Image = global::Assignment1.Properties.Resources.logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox.Enabled = false;
            this.errorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(-4, 210);
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.ShortcutsEnabled = false;
            this.errorBox.Size = new System.Drawing.Size(534, 26);
            this.errorBox.TabIndex = 18;
            this.errorBox.TabStop = false;
            this.errorBox.Text = "test";
            this.errorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errorBox.Visible = false;
            // 
            // employeeEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(528, 235);
            this.Controls.Add(this.errorBox);
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
        private System.Windows.Forms.TextBox errorBox;

    }
}

