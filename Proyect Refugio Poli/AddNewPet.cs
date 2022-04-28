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
    public partial class AddNewPet : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        private AnimalInfo animalInfo = new AnimalInfo();
  
       
        public AddNewPet()
        {
            InitializeComponent();
        }

        public AddNewPet(List<AnimalInfo> animal)
        {
            InitializeComponent();
            list = animal;
        }

        private void petNameTextBox_TextChanged(object sender, EventArgs e)
        {
            animalInfo.PetName = petNameTextBox.Text;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            list.Add(animalInfo);
            this.Close();
        }
    }
}
