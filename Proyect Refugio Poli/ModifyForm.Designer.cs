namespace Proyecto_Poli_Refugio
{
    partial class ModifyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.petTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.petColorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sterilizedComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pedrigreeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vaccine3TextBox = new System.Windows.Forms.TextBox();
            this.vaccine2TextBox = new System.Windows.Forms.TextBox();
            this.vaccine1TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Name:";
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(72, 53);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.petNameTextBox.TabIndex = 2;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(666, 377);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(92, 48);
            this.saveChangesButton.TabIndex = 3;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pet Type:";
            // 
            // petTypeComboBox
            // 
            this.petTypeComboBox.FormattingEnabled = true;
            this.petTypeComboBox.Items.AddRange(new object[] {
            "dog",
            "cat",
            "rabbit",
            "rodent",
            "bird"});
            this.petTypeComboBox.Location = new System.Drawing.Point(70, 108);
            this.petTypeComboBox.Name = "petTypeComboBox";
            this.petTypeComboBox.Size = new System.Drawing.Size(112, 21);
            this.petTypeComboBox.TabIndex = 14;
            this.petTypeComboBox.Leave += new System.EventHandler(this.PetTypeCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pet Color:";
            // 
            // petColorTextBox
            // 
            this.petColorTextBox.Location = new System.Drawing.Point(70, 166);
            this.petColorTextBox.Name = "petColorTextBox";
            this.petColorTextBox.Size = new System.Drawing.Size(110, 20);
            this.petColorTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.genderComboBox.Location = new System.Drawing.Point(68, 214);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(112, 21);
            this.genderComboBox.TabIndex = 22;
            this.genderComboBox.Leave += new System.EventHandler(this.GenderCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Is sterilized:";
            // 
            // sterilizedComboBox
            // 
            this.sterilizedComboBox.FormattingEnabled = true;
            this.sterilizedComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.sterilizedComboBox.Location = new System.Drawing.Point(68, 266);
            this.sterilizedComboBox.Name = "sterilizedComboBox";
            this.sterilizedComboBox.Size = new System.Drawing.Size(112, 21);
            this.sterilizedComboBox.TabIndex = 25;
            this.sterilizedComboBox.Leave += new System.EventHandler(this.IsSterilized);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Pedigree:";
            // 
            // pedrigreeTextBox
            // 
            this.pedrigreeTextBox.Location = new System.Drawing.Point(68, 324);
            this.pedrigreeTextBox.Name = "pedrigreeTextBox";
            this.pedrigreeTextBox.Size = new System.Drawing.Size(112, 20);
            this.pedrigreeTextBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(52, 377);
            this.dateTimePicker.MaxDate = new System.DateTime(2025, 5, 7, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker.TabIndex = 30;
            this.dateTimePicker.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // vaccine3TextBox
            // 
            this.vaccine3TextBox.Location = new System.Drawing.Point(290, 166);
            this.vaccine3TextBox.Name = "vaccine3TextBox";
            this.vaccine3TextBox.Size = new System.Drawing.Size(112, 20);
            this.vaccine3TextBox.TabIndex = 37;
            // 
            // vaccine2TextBox
            // 
            this.vaccine2TextBox.Location = new System.Drawing.Point(290, 111);
            this.vaccine2TextBox.Name = "vaccine2TextBox";
            this.vaccine2TextBox.Size = new System.Drawing.Size(112, 20);
            this.vaccine2TextBox.TabIndex = 36;
            // 
            // vaccine1TextBox
            // 
            this.vaccine1TextBox.Location = new System.Drawing.Point(290, 49);
            this.vaccine1TextBox.Name = "vaccine1TextBox";
            this.vaccine1TextBox.Size = new System.Drawing.Size(112, 20);
            this.vaccine1TextBox.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Vaccine 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Vaccine 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Vaccine 1:";
            // 
            // petPictureBox
            // 
            this.petPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petPictureBox.Location = new System.Drawing.Point(480, 23);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(216, 207);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petPictureBox.TabIndex = 41;
            this.petPictureBox.TabStop = false;
            this.petPictureBox.Click += new System.EventHandler(this.petPictureBox_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.petPictureBox);
            this.Controls.Add(this.vaccine3TextBox);
            this.Controls.Add(this.vaccine2TextBox);
            this.Controls.Add(this.vaccine1TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pedrigreeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sterilizedComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.petColorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.petTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.petNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox petTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox petColorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sterilizedComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pedrigreeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox vaccine3TextBox;
        private System.Windows.Forms.TextBox vaccine2TextBox;
        private System.Windows.Forms.TextBox vaccine1TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox petPictureBox;
    }
}