﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Refugio_Poli
{//Christian Santiago Valentin #120535
    public partial class PolyRefugeFormMain : Form
    {

        List<AnimalInfo> animalList = new List<AnimalInfo>();
        private AddNewPet addpet;
        private SearchForm searchform;
        private ReportForm reportform;
        
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
            reportform = new ReportForm(animalList);
            reportform.Show();  
        }
    }
}
