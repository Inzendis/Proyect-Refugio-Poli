namespace Proyect_Refugio_Poli
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
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Name";
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(78, 35);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.petNameTextBox.TabIndex = 1;
            this.petNameTextBox.TextChanged += new System.EventHandler(this.petNameTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(669, 369);
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
            // AddNewPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}