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
    /*
      Project: Proyecto Refugio Poli
      Class form: PolyRefugeFormMain
      Description: Instanciates a list of pets called animalList of object AnimalInfo. 
      Contains the events of menu clicks.
      animalList is passed as a referenced parameter in the paramater constructors of:
      AddNewPet, SearchForm, SearchDate, AboutForm, and HelpContents
      ModifyForm, DisplayPetInfo, and ReportForm 
      Developed by: Christian Santiago Valentin #120535
                    Rafael Charneco Gonzalez #120490
     */
    public partial class PolyRefugeFormMain : Form
    {

        List<AnimalInfo> animalList = new List<AnimalInfo>();
        private AddNewPet addpet;
        private SearchForm searchform;
        private SearchDate searchdate;
        private AboutForm aboutform;
        private HelpContents helpcontents;
        
        // Method to update the amount of pets and pets' names in main form.
        private void CurrentAnimals()
        {
            amountOfPetsLabel.Focus();
            amountOfPetsLabel.Select();
            if (animalList.Count > 0)
            {
                currentAnimalsTextBox.Text = string.Empty;
                amountOfPetsLabel.Text = $"{animalList.Count}";
                foreach (AnimalInfo info in animalList)
                {
                    currentAnimalsTextBox.Text += $"{info.PetName}\t{info.DateEntry}\r\n";
                }
            }
            else
            {
                amountOfPetsLabel.Text = $"0";
            }
        }
        // Constructor
        public PolyRefugeFormMain()
        {
            InitializeComponent();
            addpet = null;
            searchform = null;
            searchdate = null;
            aboutform = null;
            helpcontents = null;
            
        }

        //Event that occurs when entering or return to main form.
        private void EnterApp(object sender, EventArgs e)
        {
            animalList.Sort((x, y) => x.PetName.CompareTo(y.PetName)); // Sorts the list with pets' names in alphabetical order
            CurrentAnimals();
        }

        //Add a Pet form on menu click
        private void addNewPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpet = new AddNewPet(animalList);
            addpet.Show();   
        }

        //Display a pet form on menu click
        private void displayPetInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Searchform is used first to get pet
            searchform = new SearchForm(animalList,3);
            searchform.Show();
        }

        //Modify a pet form on menu click
        private void modifyAPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Searchform is used first to get pet
            searchform = new SearchForm(animalList, 2);
            searchform.Show();
        }

        //Report a pet form on menu click
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Searchdate form is used first to get pets on date
            searchdate = new SearchDate(animalList);
            searchdate.Show();  
        }

        //Exit on menu click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Help Contents on menu click
        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpcontents = new HelpContents();
            helpcontents.Show();
        }

        //About on menu click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutform = new AboutForm();
            aboutform.Show();
        }

        
    }
}
