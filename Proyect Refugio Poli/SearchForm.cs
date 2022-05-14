using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Poli_Refugio
{
    public partial class SearchForm : Form
    {
      
        private DisplayPetInfo displaypet;
        private ModifyForm modifyform;
        private List<AnimalInfo> list = new List<AnimalInfo>();
        int senderInput;

        // Returns the selected pet's index in combo box
        public int selected()
        {
            enterButton.Focus();
            enterButton.Select();
            return animalComboBox.SelectedIndex;
        }
        public SearchForm()
        {
            InitializeComponent();
        }

        //Parameter constructor that receives a list of AnimalInfo object and the menu option clicked.
        public SearchForm(List<AnimalInfo> animal, int aSenderInput)
        {
            InitializeComponent();
            list = animal;
            senderInput = aSenderInput;
            for (int i = 0; i < list.Count; i++)
            {
                animalComboBox.Items.Add(list[i].PetName + ' ' + list[i].DateEntry + ' '+ list[i].Pedigree); // Combo box within search to avoid incorrect searches.
            }
            
        }


        // Enter button click event
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (selected() > -1)
            {
                switch (senderInput)
                {
                    case 2: // aSenderInput is 2, meaning ModifyForm was selected.
                        modifyform = new ModifyForm(list, selected());
                        modifyform.Show();
                        this.Close();
                        break;
                    case 3: // aSenderInput is 3, meaning DisplayPetInfo was selected.
                        displaypet = new DisplayPetInfo(list, selected());
                        displaypet.Show();
                        this.Close();
                        break;

                }
            }
        }

        //Enter key pressed event that causes click event on Enter button
        private void enterButton_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                enterButton.PerformClick();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
