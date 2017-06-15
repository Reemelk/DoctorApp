namespace DocApp.Forms
{
    partial class NewPatientForm
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
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.createPatientButton = new System.Windows.Forms.Button();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mrRadioButton = new System.Windows.Forms.RadioButton();
            this.mrsRadioButton = new System.Windows.Forms.RadioButton();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(34, 74);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(244, 20);
            this.lastnameTextBox.TabIndex = 0;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(34, 129);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(244, 20);
            this.firstnameTextBox.TabIndex = 1;
            // 
            // createPatientButton
            // 
            this.createPatientButton.Location = new System.Drawing.Point(97, 236);
            this.createPatientButton.Name = "createPatientButton";
            this.createPatientButton.Size = new System.Drawing.Size(98, 32);
            this.createPatientButton.TabIndex = 2;
            this.createPatientButton.Text = "Create patient";
            this.createPatientButton.UseVisualStyleBackColor = true;
            this.createPatientButton.Click += new System.EventHandler(this.createPatientButton_Click);
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.Location = new System.Drawing.Point(34, 186);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.DOBDateTimePicker.TabIndex = 3;
            // 
            // mrRadioButton
            // 
            this.mrRadioButton.AutoSize = true;
            this.mrRadioButton.Location = new System.Drawing.Point(34, 23);
            this.mrRadioButton.Name = "mrRadioButton";
            this.mrRadioButton.Size = new System.Drawing.Size(53, 17);
            this.mrRadioButton.TabIndex = 4;
            this.mrRadioButton.TabStop = true;
            this.mrRadioButton.Tag = "Mr";
            this.mrRadioButton.Text = "Mister";
            this.mrRadioButton.UseVisualStyleBackColor = true;
            // 
            // mrsRadioButton
            // 
            this.mrsRadioButton.AutoSize = true;
            this.mrsRadioButton.Location = new System.Drawing.Point(193, 23);
            this.mrsRadioButton.Name = "mrsRadioButton";
            this.mrsRadioButton.Size = new System.Drawing.Size(60, 17);
            this.mrsRadioButton.TabIndex = 5;
            this.mrsRadioButton.TabStop = true;
            this.mrsRadioButton.Tag = "Mrs";
            this.mrsRadioButton.Text = "Madam";
            this.mrsRadioButton.UseVisualStyleBackColor = true;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(31, 58);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(53, 13);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Lastname";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(31, 113);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(52, 13);
            this.firstnameLabel.TabIndex = 7;
            this.firstnameLabel.Text = "Firstname";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(31, 170);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(68, 13);
            this.DOBLabel.TabIndex = 8;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 286);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.mrsRadioButton);
            this.Controls.Add(this.mrRadioButton);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.createPatientButton);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Name = "NewPatientForm";
            this.Text = "NewPatientForm";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Button createPatientButton;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.RadioButton mrRadioButton;
        private System.Windows.Forms.RadioButton mrsRadioButton;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label DOBLabel;
    }
}