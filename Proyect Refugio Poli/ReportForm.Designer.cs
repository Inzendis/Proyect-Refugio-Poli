namespace Proyecto_Poli_Refugio
{
    partial class ReportForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petPhotoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSterilizedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pedigreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaccine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaccine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaccine3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(856, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // animalDataGridView
            // 
            this.animalDataGridView.AutoGenerateColumns = false;
            this.animalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petNameDataGridViewTextBoxColumn,
            this.petPhotoNameDataGridViewTextBoxColumn,
            this.petTypeDataGridViewTextBoxColumn,
            this.petColorDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.isSterilizedDataGridViewCheckBoxColumn,
            this.pedigreeDataGridViewTextBoxColumn,
            this.Vaccine1,
            this.Vaccine2,
            this.Vaccine3});
            this.animalDataGridView.DataSource = this.animalInfoBindingSource;
            this.animalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.animalDataGridView.Location = new System.Drawing.Point(35, 12);
            this.animalDataGridView.Name = "animalDataGridView";
            this.animalDataGridView.ReadOnly = true;
            this.animalDataGridView.Size = new System.Drawing.Size(823, 414);
            this.animalDataGridView.TabIndex = 2;
            // 
            // petNameDataGridViewTextBoxColumn
            // 
            this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
            this.petNameDataGridViewTextBoxColumn.HeaderText = "Pet Name";
            this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
            this.petNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petPhotoNameDataGridViewTextBoxColumn
            // 
            this.petPhotoNameDataGridViewTextBoxColumn.DataPropertyName = "PetPhotoName";
            this.petPhotoNameDataGridViewTextBoxColumn.HeaderText = "Pet Photo Name";
            this.petPhotoNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.petPhotoNameDataGridViewTextBoxColumn.Name = "petPhotoNameDataGridViewTextBoxColumn";
            this.petPhotoNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.petPhotoNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // petTypeDataGridViewTextBoxColumn
            // 
            this.petTypeDataGridViewTextBoxColumn.DataPropertyName = "PetType";
            this.petTypeDataGridViewTextBoxColumn.HeaderText = "Pet Type";
            this.petTypeDataGridViewTextBoxColumn.Name = "petTypeDataGridViewTextBoxColumn";
            this.petTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petColorDataGridViewTextBoxColumn
            // 
            this.petColorDataGridViewTextBoxColumn.DataPropertyName = "PetColor";
            this.petColorDataGridViewTextBoxColumn.HeaderText = "Pet Color";
            this.petColorDataGridViewTextBoxColumn.Name = "petColorDataGridViewTextBoxColumn";
            this.petColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isSterilizedDataGridViewCheckBoxColumn
            // 
            this.isSterilizedDataGridViewCheckBoxColumn.DataPropertyName = "IsSterilized";
            this.isSterilizedDataGridViewCheckBoxColumn.HeaderText = "IsSterilized";
            this.isSterilizedDataGridViewCheckBoxColumn.Name = "isSterilizedDataGridViewCheckBoxColumn";
            this.isSterilizedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pedigreeDataGridViewTextBoxColumn
            // 
            this.pedigreeDataGridViewTextBoxColumn.DataPropertyName = "Pedigree";
            this.pedigreeDataGridViewTextBoxColumn.HeaderText = "Pedigree";
            this.pedigreeDataGridViewTextBoxColumn.Name = "pedigreeDataGridViewTextBoxColumn";
            this.pedigreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Vaccine1
            // 
            this.Vaccine1.HeaderText = "Vaccine 1";
            this.Vaccine1.Name = "Vaccine1";
            this.Vaccine1.ReadOnly = true;
            // 
            // Vaccine2
            // 
            this.Vaccine2.HeaderText = "Vaccine 2";
            this.Vaccine2.Name = "Vaccine2";
            this.Vaccine2.ReadOnly = true;
            // 
            // Vaccine3
            // 
            this.Vaccine3.HeaderText = "Vaccine 3";
            this.Vaccine3.Name = "Vaccine3";
            this.Vaccine3.ReadOnly = true;
            // 
            // animalInfoBindingSource
            // 
            this.animalInfoBindingSource.DataSource = typeof(Proyecto_Poli_Refugio.AnimalInfo);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 479);
            this.Controls.Add(this.animalDataGridView);
            this.Controls.Add(this.exitButton);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.DataGridView_Update);
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource animalInfoBindingSource;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView animalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petPhotoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSterilizedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedigreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaccine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaccine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaccine3;
    }
}