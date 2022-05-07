namespace Proyect_Refugio_Poli
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
            this.menuStrip1.SuspendLayout();
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
            this.addNewPetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewPetToolStripMenuItem.Text = "Add New Pet";
            this.addNewPetToolStripMenuItem.Click += new System.EventHandler(this.addNewPetToolStripMenuItem_Click);
            // 
            // modifyAPetToolStripMenuItem
            // 
            this.modifyAPetToolStripMenuItem.Name = "modifyAPetToolStripMenuItem";
            this.modifyAPetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyAPetToolStripMenuItem.Text = "Modify a Pet";
            this.modifyAPetToolStripMenuItem.Click += new System.EventHandler(this.modifyAPetToolStripMenuItem_Click);
            // 
            // displayPetInfoToolStripMenuItem
            // 
            this.displayPetInfoToolStripMenuItem.Name = "displayPetInfoToolStripMenuItem";
            this.displayPetInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayPetInfoToolStripMenuItem.Text = "Display Pet Info";
            this.displayPetInfoToolStripMenuItem.Click += new System.EventHandler(this.displayPetInfoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currentAnimalsTextBox
            // 
            this.currentAnimalsTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currentAnimalsTextBox.Location = new System.Drawing.Point(522, 45);
            this.currentAnimalsTextBox.Multiline = true;
            this.currentAnimalsTextBox.Name = "currentAnimalsTextBox";
            this.currentAnimalsTextBox.ReadOnly = true;
            this.currentAnimalsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentAnimalsTextBox.Size = new System.Drawing.Size(220, 359);
            this.currentAnimalsTextBox.TabIndex = 1;
            this.currentAnimalsTextBox.TabStop = false;
            // 
            // PolyRefugeFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentAnimalsTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PolyRefugeFormMain";
            this.Text = "Poly Refugio";
            this.Activated += new System.EventHandler(this.EnterApp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

