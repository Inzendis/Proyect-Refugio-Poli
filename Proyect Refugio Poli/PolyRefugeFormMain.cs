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
    public partial class PolyRefugeFormMain : Form
    {

        List<AnimalInfo> animalList = new List<AnimalInfo>();
        private AddNewPet addpet;
        private SearchForm searchform;
        private int SenderInput()
        {
            return 0;
        }

        private void CurrentAnimals()
        {

            if (animalList.Count > 0)
                currentAnimalsTextBox.Text = string.Empty;
                foreach (AnimalInfo info in animalList)
                {
                    currentAnimalsTextBox.Text += $"{info.PetName}\t{info.DateEntry}\r\n";
                }
        }
        public PolyRefugeFormMain()
        {
            InitializeComponent();
            addpet = null;
            searchform = null;
            
        }

        private void EnterApp(object sender, EventArgs e)
        {
            CurrentAnimals();
        }

        private void addNewPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpet = new AddNewPet(animalList);
            addpet.Show();
            
        }

        private void displayPetInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchform = new SearchForm(animalList,3);
            searchform.Show();

        }
    }
}
