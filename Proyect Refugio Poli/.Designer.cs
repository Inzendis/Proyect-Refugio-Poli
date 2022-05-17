namespace Proyecto_Poli_Refugio
{
    partial class PolyRefugeFormMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPetInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currentAnimalsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountOfPetsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPetToolStripMenuItem,
            this.modifyAPetToolStripMenuItem,
            this.displayPetInfoToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewPetToolStripMenuItem
            // 
            this.addNewPetToolStripMenuItem.Name = "addNewPetToolStripMenuItem";
            this.addNewPetToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewPetToolStripMenuItem.Text = "Add New Pet";
            this.addNewPetToolStripMenuItem.Click += new System.EventHandler(this.addNewPetToolStripMenuItem_Click);
            // 
            // modifyAPetToolStripMenuItem
            // 
            this.modifyAPetToolStripMenuItem.Name = "modifyAPetToolStripMenuItem";
            this.modifyAPetToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modifyAPetToolStripMenuItem.Text = "Modify a Pet";
            this.modifyAPetToolStripMenuItem.Click += new System.EventHandler(this.modifyAPetToolStripMenuItem_Click);
            // 
            // displayPetInfoToolStripMenuItem
            // 
            this.displayPetInfoToolStripMenuItem.Name = "displayPetInfoToolStripMenuItem";
            this.displayPetInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.displayPetInfoToolStripMenuItem.Text = "Display Pet Info";
            this.displayPetInfoToolStripMenuItem.Click += new System.EventHandler(this.displayPetInfoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.helpContentsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currentAnimalsTextBox
            // 
            this.currentAnimalsTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currentAnimalsTextBox.Location = new System.Drawing.Point(12, 113);
            this.currentAnimalsTextBox.Multiline = true;
            this.currentAnimalsTextBox.Name = "currentAnimalsTextBox";
            this.currentAnimalsTextBox.ReadOnly = true;
            this.currentAnimalsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentAnimalsTextBox.Size = new System.Drawing.Size(246, 337);
            this.currentAnimalsTextBox.TabIndex = 1;
            this.currentAnimalsTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of pets:";
            // 
            // amountOfPetsLabel
            // 
            this.amountOfPetsLabel.AutoSize = true;
            this.amountOfPetsLabel.Location = new System.Drawing.Point(93, 97);
            this.amountOfPetsLabel.Name = "amountOfPetsLabel";
            this.amountOfPetsLabel.Size = new System.Drawing.Size(0, 13);
            this.amountOfPetsLabel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Poli_Refugio.Properties.Resources.LOGO_PUPR;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PolyRefugeFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(271, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amountOfPetsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentAnimalsTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PolyRefugeFormMain";
            this.Text = "Poly Refugio";
            this.Activated += new System.EventHandler(this.EnterApp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPetInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox currentAnimalsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountOfPetsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

