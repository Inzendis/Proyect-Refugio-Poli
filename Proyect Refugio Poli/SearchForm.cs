using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Refugio_Poli
{
    public partial class SearchForm : Form
    {
        private string nameSearch;
        //private bool close= false;
        private DisplayPetInfo displaypet;
        private List<AnimalInfo> list = new List<AnimalInfo>();
        int senderInput;

        public int getIndex()
        {
            var index = list.FindIndex(x => x.PetName == NameSearch); // What happens if the names repeats.
            return index;
        }
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(List<AnimalInfo> animal, int aSenderInput)
        {
            InitializeComponent();
            list = animal;
            senderInput = aSenderInput;
            
        }


        public string NameSearch { get => nameSearch; set => nameSearch = value; }

        private void searchPetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameSearch = searchPetNameTextBox.Text;
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            NameSearch = searchPetNameTextBox.Text;
            
                if (getIndex() == -1)
                {
                    MessageBox.Show("Error", "Animal not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(senderInput == 3 && getIndex() >= 0)
                {
                    displaypet = new DisplayPetInfo(list, getIndex());
                    displaypet.Show();
                    this.Close();
                }
             

        }

        private void enterButton_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                enterButton.PerformClick();
            }
        }
    }
}
