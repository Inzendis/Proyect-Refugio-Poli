namespace Proyecto_Poli_Refugio
{
    partial class DisplayPetInfo
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
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextBox.Location = new System.Drawing.Point(46, 50);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(319, 324);
            this.infoTextBox.TabIndex = 0;
            // 
            // petPictureBox
            // 
            this.petPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petPictureBox.Location = new System.Drawing.Point(524, 40);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(216, 207);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petPictureBox.TabIndex = 4;
            this.petPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(666, 347);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(74, 27);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DisplayPetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 393);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.petPictureBox);
            this.Controls.Add(this.infoTextBox);
            this.Name = "DisplayPetInfo";
            this.Text = "DisplayPetInfo";
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.Button closeButton;
    }
}