namespace DocApp.Forms
{
    partial class NewMedicineForm
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
            this.createMedicineButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.nameMedicineTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createMedicineButton
            // 
            this.createMedicineButton.Location = new System.Drawing.Point(98, 255);
            this.createMedicineButton.Name = "createMedicineButton";
            this.createMedicineButton.Size = new System.Drawing.Size(146, 36);
            this.createMedicineButton.TabIndex = 0;
            this.createMedicineButton.Text = "Create medicine";
            this.createMedicineButton.UseVisualStyleBackColor = true;
            this.createMedicineButton.Click += new System.EventHandler(this.createMedicineButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(93, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Name of Medicine";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 92);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // nameMedicineTextBox
            // 
            this.nameMedicineTextBox.Location = new System.Drawing.Point(15, 36);
            this.nameMedicineTextBox.Multiline = true;
            this.nameMedicineTextBox.Name = "nameMedicineTextBox";
            this.nameMedicineTextBox.Size = new System.Drawing.Size(323, 35);
            this.nameMedicineTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 108);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(322, 127);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // NewMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 303);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameMedicineTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.createMedicineButton);
            this.Name = "NewMedicineForm";
            this.Text = "NewMedicineForm";
            this.Load += new System.EventHandler(this.NewMedicineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createMedicineButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox nameMedicineTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}