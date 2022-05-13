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
    public partial class DisplayPetInfo : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        private int index;
        public DisplayPetInfo()
        {
            InitializeComponent();
        }

        public DisplayPetInfo(List<AnimalInfo> animal, int aIndex)
        {
            InitializeComponent();
            list = animal;
            index = aIndex;
            infoTextBox.Text = $"Pet Name: {list[index].PetName}\r\nPet Type: {list[index].PetType}\r\n" +
                $"Color: {list[index].PetColor}\r\nGender: {list[index].Gender}\r\nSterilized: {list[index].IsSterilized}\r\nPedigree: {list[index].Pedigree}\r\n" +
                $"Date: {list[index].DateEntry}\r\nVaccine 1: {list[index].Vaccine[0]}\r\nVaccine 2:{list[index].Vaccine[1]}\r\nVaccine 3:{list[index].Vaccine[2]}";

         
            // display image in picture box  
            petPictureBox.Image = new Bitmap(list[index].PetPhotoName);
            // image file path  
            petPictureBox.Text = list[index].PetPhotoName;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
