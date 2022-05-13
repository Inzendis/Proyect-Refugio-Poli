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
{//Christian Santiago Valentin #120535
    public partial class PolyRefugeFormMain : Form
    {

        List<AnimalInfo> animalList = new List<AnimalInfo>();
        private AddNewPet addpet;
        private SearchForm searchform;
        private SearchDate searchdate;
        private AboutForm aboutform;
        private HelpContents helpcontents;
        
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
            animalList.Sort((x, y) => x.PetName.CompareTo(y.PetName));
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

        private void modifyAPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchform = new SearchForm(animalList, 2);
            searchform.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchdate = new SearchDate(animalList);
            searchdate.Show();  
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpcontents = new HelpContents();
            helpcontents.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutform = new AboutForm();
            aboutform.Show();
        }

       
    }
}
