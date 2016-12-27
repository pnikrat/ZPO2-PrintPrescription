namespace PrintPrescription
{
    partial class PrescriptionForm
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
            this.printerList = new System.Windows.Forms.ComboBox();
            this.printerListLabel = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.prescriptionNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.prescriptionNumberLabel = new System.Windows.Forms.Label();
            this.patientNameBox = new System.Windows.Forms.TextBox();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.peselBox = new System.Windows.Forms.TextBox();
            this.peselLabel = new System.Windows.Forms.Label();
            this.nfzNumberBox = new System.Windows.Forms.NumericUpDown();
            this.nfzNumberLabel = new System.Windows.Forms.Label();
            this.priviligesCheckBox = new System.Windows.Forms.CheckBox();
            this.illnessCheckBox = new System.Windows.Forms.CheckBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.printStartButton = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nfzNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // printerList
            // 
            this.printerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerList.FormattingEnabled = true;
            this.printerList.Location = new System.Drawing.Point(160, 35);
            this.printerList.Name = "printerList";
            this.printerList.Size = new System.Drawing.Size(345, 21);
            this.printerList.TabIndex = 0;
            this.printerList.TabStop = false;
            // 
            // printerListLabel
            // 
            this.printerListLabel.AutoSize = true;
            this.printerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printerListLabel.Location = new System.Drawing.Point(12, 36);
            this.printerListLabel.Name = "printerListLabel";
            this.printerListLabel.Size = new System.Drawing.Size(122, 16);
            this.printerListLabel.TabIndex = 1;
            this.printerListLabel.Text = "Wybrana drukarka:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(160, 9);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(182, 20);
            this.doctorTextBox.TabIndex = 2;
            this.doctorTextBox.TabStop = false;
            this.doctorTextBox.Text = "Przemysław Nikratowicz";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doctorLabel.Location = new System.Drawing.Point(12, 10);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(51, 16);
            this.doctorLabel.TabIndex = 3;
            this.doctorLabel.Text = "Lekarz:";
            // 
            // errorLabel
            // 
            this.errorLabel.Location = new System.Drawing.Point(12, 68);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(493, 58);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prescriptionNumberBox
            // 
            this.prescriptionNumberBox.Location = new System.Drawing.Point(160, 129);
            this.prescriptionNumberBox.Mask = "0000000000000000000000";
            this.prescriptionNumberBox.Name = "prescriptionNumberBox";
            this.prescriptionNumberBox.PromptChar = '0';
            this.prescriptionNumberBox.ResetOnSpace = false;
            this.prescriptionNumberBox.Size = new System.Drawing.Size(150, 20);
            this.prescriptionNumberBox.TabIndex = 1;
            this.prescriptionNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prescriptionNumberBox.Leave += new System.EventHandler(this.prescriptionNumberBox_Leave);
            // 
            // prescriptionNumberLabel
            // 
            this.prescriptionNumberLabel.AutoSize = true;
            this.prescriptionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prescriptionNumberLabel.Location = new System.Drawing.Point(12, 130);
            this.prescriptionNumberLabel.Name = "prescriptionNumberLabel";
            this.prescriptionNumberLabel.Size = new System.Drawing.Size(99, 16);
            this.prescriptionNumberLabel.TabIndex = 6;
            this.prescriptionNumberLabel.Text = "Numer recepty:";
            // 
            // patientNameBox
            // 
            this.patientNameBox.Location = new System.Drawing.Point(160, 156);
            this.patientNameBox.Name = "patientNameBox";
            this.patientNameBox.Size = new System.Drawing.Size(150, 20);
            this.patientNameBox.TabIndex = 2;
            this.patientNameBox.Leave += new System.EventHandler(this.patientNameBox_Leave);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientNameLabel.Location = new System.Drawing.Point(12, 157);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(105, 16);
            this.patientNameLabel.TabIndex = 8;
            this.patientNameLabel.Text = "Imię i nazwisko*:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(160, 182);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(150, 20);
            this.cityBox.TabIndex = 3;
            this.cityBox.Leave += new System.EventHandler(this.cityBox_Leave);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityLabel.Location = new System.Drawing.Point(12, 183);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(94, 16);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "Miejscowość*:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageLabel.Location = new System.Drawing.Point(12, 210);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(101, 16);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Wiek (w latach):";
            // 
            // peselBox
            // 
            this.peselBox.Location = new System.Drawing.Point(160, 236);
            this.peselBox.Name = "peselBox";
            this.peselBox.Size = new System.Drawing.Size(150, 20);
            this.peselBox.TabIndex = 5;
            this.peselBox.Leave += new System.EventHandler(this.peselBox_Leave);
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselLabel.Location = new System.Drawing.Point(12, 237);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(59, 16);
            this.peselLabel.TabIndex = 14;
            this.peselLabel.Text = "PESEL*:";
            // 
            // nfzNumberBox
            // 
            this.nfzNumberBox.Location = new System.Drawing.Point(454, 129);
            this.nfzNumberBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nfzNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nfzNumberBox.Name = "nfzNumberBox";
            this.nfzNumberBox.Size = new System.Drawing.Size(51, 20);
            this.nfzNumberBox.TabIndex = 6;
            this.nfzNumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nfzNumberBox.Leave += new System.EventHandler(this.nfzNumberBox_Leave);
            // 
            // nfzNumberLabel
            // 
            this.nfzNumberLabel.AutoSize = true;
            this.nfzNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nfzNumberLabel.Location = new System.Drawing.Point(329, 130);
            this.nfzNumberLabel.Name = "nfzNumberLabel";
            this.nfzNumberLabel.Size = new System.Drawing.Size(89, 16);
            this.nfzNumberLabel.TabIndex = 16;
            this.nfzNumberLabel.Text = "Oddział NFZ:";
            // 
            // priviligesCheckBox
            // 
            this.priviligesCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.priviligesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priviligesCheckBox.Location = new System.Drawing.Point(328, 157);
            this.priviligesCheckBox.Name = "priviligesCheckBox";
            this.priviligesCheckBox.Size = new System.Drawing.Size(177, 20);
            this.priviligesCheckBox.TabIndex = 7;
            this.priviligesCheckBox.Text = "Uprawnienia";
            this.priviligesCheckBox.UseVisualStyleBackColor = true;
            this.priviligesCheckBox.Leave += new System.EventHandler(this.priviligesCheckBox_Leave);
            // 
            // illnessCheckBox
            // 
            this.illnessCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.illnessCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.illnessCheckBox.Location = new System.Drawing.Point(328, 183);
            this.illnessCheckBox.Name = "illnessCheckBox";
            this.illnessCheckBox.Size = new System.Drawing.Size(177, 20);
            this.illnessCheckBox.TabIndex = 8;
            this.illnessCheckBox.Text = "Ch. przewlekłe";
            this.illnessCheckBox.UseVisualStyleBackColor = true;
            this.illnessCheckBox.Leave += new System.EventHandler(this.illnessCheckBox_Leave);
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.AcceptsReturn = true;
            this.prescriptionTextBox.Location = new System.Drawing.Point(13, 312);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(492, 239);
            this.prescriptionTextBox.TabIndex = 9;
            this.prescriptionTextBox.Leave += new System.EventHandler(this.prescriptionTextBox_Leave);
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prescriptionLabel.Location = new System.Drawing.Point(12, 293);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(94, 16);
            this.prescriptionLabel.TabIndex = 20;
            this.prescriptionLabel.Text = "Treść recepty:";
            // 
            // printStartButton
            // 
            this.printStartButton.Location = new System.Drawing.Point(377, 592);
            this.printStartButton.Name = "printStartButton";
            this.printStartButton.Size = new System.Drawing.Size(128, 23);
            this.printStartButton.TabIndex = 10;
            this.printStartButton.Text = "Drukuj receptę";
            this.printStartButton.UseVisualStyleBackColor = true;
            this.printStartButton.Click += new System.EventHandler(this.printStartButton_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(258, 210);
            this.ageBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ageBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(52, 20);
            this.ageBox.TabIndex = 4;
            this.ageBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageBox.Leave += new System.EventHandler(this.ageBox_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 636);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.printStartButton);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.illnessCheckBox);
            this.Controls.Add(this.priviligesCheckBox);
            this.Controls.Add(this.nfzNumberLabel);
            this.Controls.Add(this.nfzNumberBox);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.peselBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientNameBox);
            this.Controls.Add(this.prescriptionNumberLabel);
            this.Controls.Add(this.prescriptionNumberBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.printerListLabel);
            this.Controls.Add(this.printerList);
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularz recepty";
            ((System.ComponentModel.ISupportInitialize)(this.nfzNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox printerList;
        private System.Windows.Forms.Label printerListLabel;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.MaskedTextBox prescriptionNumberBox;
        private System.Windows.Forms.Label prescriptionNumberLabel;
        private System.Windows.Forms.TextBox patientNameBox;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox peselBox;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.NumericUpDown nfzNumberBox;
        private System.Windows.Forms.Label nfzNumberLabel;
        private System.Windows.Forms.CheckBox priviligesCheckBox;
        private System.Windows.Forms.CheckBox illnessCheckBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.Button printStartButton;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

