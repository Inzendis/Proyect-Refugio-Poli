namespace Proyect_Refugio_Poli
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
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextBox.Location = new System.Drawing.Point(46, 50);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(210, 324);
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
            // DisplayPetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}