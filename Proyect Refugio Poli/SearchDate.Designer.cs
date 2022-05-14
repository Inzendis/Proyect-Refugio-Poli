namespace Proyecto_Poli_Refugio
{
    partial class SearchDate
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
            this.closeButton = new System.Windows.Forms.Button();
            this.searchDateButton = new System.Windows.Forms.Button();
            this.searchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(232, 141);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(65, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchDateButton
            // 
            this.searchDateButton.Location = new System.Drawing.Point(136, 68);
            this.searchDateButton.Name = "searchDateButton";
            this.searchDateButton.Size = new System.Drawing.Size(65, 28);
            this.searchDateButton.TabIndex = 1;
            this.searchDateButton.Text = "Search";
            this.searchDateButton.UseVisualStyleBackColor = true;
            this.searchDateButton.Click += new System.EventHandler(this.searchDateButton_Click);
            this.searchDateButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterButton_KeyDown);
            // 
            // searchDatePicker
            // 
            this.searchDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDatePicker.Location = new System.Drawing.Point(39, 70);
            this.searchDatePicker.MaxDate = new System.DateTime(2026, 5, 7, 0, 0, 0, 0);
            this.searchDatePicker.MinDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.searchDatePicker.Name = "searchDatePicker";
            this.searchDatePicker.Size = new System.Drawing.Size(80, 20);
            this.searchDatePicker.TabIndex = 2;
            this.searchDatePicker.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // SearchDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 181);
            this.Controls.Add(this.searchDatePicker);
            this.Controls.Add(this.searchDateButton);
            this.Controls.Add(this.closeButton);
            this.Name = "SearchDate";
            this.Text = "SearchDate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchDateButton;
        private System.Windows.Forms.DateTimePicker searchDatePicker;
    }
}