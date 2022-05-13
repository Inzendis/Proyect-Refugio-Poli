namespace Proyecto_Poli_Refugio
{
    partial class AddNewPet
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
            this.saveButton = new System.Windows.Forms.Button();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.petTypeComboBox = new System.Windows.Forms.ComboBox();
            this.petColorTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.sterilizedComboBox = new System.Windows.Forms.ComboBox();
            this.pedrigreeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vaccine1TextBox = new System.Windows.Forms.TextBox();
            this.vaccine2TextBox = new System.Windows.Forms.TextBox();
            this.vaccine3TextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Name:";
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(69, 35);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.petNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(517, 360);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 48);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // petPictureBox
            // 
            this.petPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petPictureBox.Location = new System.Drawing.Point(502, 38);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(216, 207);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petPictureBox.TabIndex = 3;
            this.petPictureBox.TabStop = false;
            this.petPictureBox.Click += new System.EventHandler(this.petPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pet Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pet Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Is sterilized:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pedigree:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vaccine 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Vaccine 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Vaccine 3:";
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
            this.petTypeComboBox.Location = new System.Drawing.Point(69, 69);
            this.petTypeComboBox.Name = "petTypeComboBox";
            this.petTypeComboBox.Size = new System.Drawing.Size(112, 21);
            this.petTypeComboBox.TabIndex = 13;
            // 
            // petColorTextBox
            // 
            this.petColorTextBox.Location = new System.Drawing.Point(69, 99);
            this.petColorTextBox.Name = "petColorTextBox";
            this.petColorTextBox.Size = new System.Drawing.Size(112, 20);
            this.petColorTextBox.TabIndex = 14;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.genderComboBox.Location = new System.Drawing.Point(69, 125);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(112, 21);
            this.genderComboBox.TabIndex = 15;
            this.genderComboBox.TextUpdate += new System.EventHandler(this.GenderCheck);
            this.genderComboBox.Leave += new System.EventHandler(this.GenderCheck);
            // 
            // sterilizedComboBox
            // 
            this.sterilizedComboBox.FormattingEnabled = true;
            this.sterilizedComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.sterilizedComboBox.Location = new System.Drawing.Point(69, 152);
            this.sterilizedComboBox.Name = "sterilizedComboBox";
            this.sterilizedComboBox.Size = new System.Drawing.Size(112, 21);
            this.sterilizedComboBox.TabIndex = 16;
            this.sterilizedComboBox.TextUpdate += new System.EventHandler(this.IsSterilized);
            this.sterilizedComboBox.TextChanged += new System.EventHandler(this.IsSterilized);
            // 
            // pedrigreeTextBox
            // 
            this.pedrigreeTextBox.Location = new System.Drawing.Point(69, 179);
            this.pedrigreeTextBox.Name = "pedrigreeTextBox";
            this.pedrigreeTextBox.Size = new System.Drawing.Size(112, 20);
            this.pedrigreeTextBox.TabIndex = 17;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(69, 208);
            this.dateTimePicker.MaxDate = new System.DateTime(2025, 5, 7, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker.TabIndex = 18;
            this.dateTimePicker.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // vaccine1TextBox
            // 
            this.vaccine1TextBox.Location = new System.Drawing.Point(69, 242);
            this.vaccine1TextBox.Name = "vaccine1TextBox";
            this.vaccine1TextBox.Size = new System.Drawing.Size(112, 20);
            this.vaccine1TextBox.TabIndex = 19;
            // 
            // vaccine2TextBox
            // 
            this.vaccine2TextBox.Location = new System.Drawing.Point(69, 271);
            this.vaccine2TextBox.Name = "vaccine2TextBox";
            this.vaccine2TextBox.Size = new System.Drawing.Size(112, 20);
            this.vaccine2TextBox.TabIndex = 20;
            // 
            // vaccine3TextBox
            // 
            this.vaccine3TextBox.Location = new System.Drawing.Point(69, 297);
            this.vaccine3TextBox.Name = "vaccine3TextBox";
            this.vaccine3TextBox.Size = new System.Drawing.Size(112, 20);
            this.vaccine3TextBox.TabIndex = 21;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(626, 360);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 48);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddNewPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.vaccine3TextBox);
            this.Controls.Add(this.vaccine2TextBox);
            this.Controls.Add(this.vaccine1TextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pedrigreeTextBox);
            this.Controls.Add(this.sterilizedComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.petColorTextBox);
            this.Controls.Add(this.petTypeComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petPictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.petNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewPet";
            this.Text = "AddNewPet";
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox petTypeComboBox;
        private System.Windows.Forms.TextBox petColorTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox sterilizedComboBox;
        private System.Windows.Forms.TextBox pedrigreeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox vaccine1TextBox;
        private System.Windows.Forms.TextBox vaccine2TextBox;
        private System.Windows.Forms.TextBox vaccine3TextBox;
        private System.Windows.Forms.Button closeButton;
    }
}