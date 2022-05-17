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
      Class form: DisplayPetInfo
      Description: Shows the data of an AnimalInfo object from a List of AnimalObject passed through reference parameter in the parameter constructor.
      Developed by: Christian Santiago Valentin #120535
                    Rafael Charneco Gonzalez #120490
     */
    public partial class DisplayPetInfo : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        private int index;
        public DisplayPetInfo()
        {
            InitializeComponent();
        }

        //Constructor with parameters List of AnimalInfo object
        public DisplayPetInfo(List<AnimalInfo> pets, int aIndex)
        {
            InitializeComponent();
            list = pets;
            index = aIndex;
        }

        //EnterApp event, when display opens it will contain all the information within a TextBox and display the pet's photo
        private void EnterApp(object sender, EventArgs e)
        {
            infoTextBox.Text = $"Pet Name: {list[index].PetName}\r\nPet Type: {list[index].PetType}\r\n" +
                $"Color: {list[index].PetColor}\r\nGender: {list[index].Gender}\r\nSterilized: {list[index].IsSterilized}\r\nPedigree: {list[index].Pedigree}\r\n" +
                $"Date: {list[index].DateEntry}\r\nVaccine 1: {list[index].Vaccine[0]}\r\nVaccine 2: {list[index].Vaccine[1]}\r\nVaccine 3: {list[index].Vaccine[2]}";
            // display image in picture box  
            petPictureBox.Image = new Bitmap(list[index].PetPhotoName);
            // image file path  
            petPictureBox.Text = list[index].PetPhotoName;
            closeButton.Focus();
            closeButton.Select();
        }

        //Close button on click event
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
