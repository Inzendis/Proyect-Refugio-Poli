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
    public partial class ModifyForm : Form
    {
        private List<AnimalInfo> Modlist = new List<AnimalInfo>();
        int animalIndex;
        public ModifyForm()
        {
            InitializeComponent();
        }

        public ModifyForm(List<AnimalInfo> list, int index)
        {
            InitializeComponent();
            Modlist = list;
            animalIndex = index;
            previousPetName.Text = Modlist[animalIndex].PetName;
            petPictureBox.Text = Modlist[animalIndex].PetPhotoName;
            previousPetColorLabel.Text = Modlist[animalIndex].PetColor;
            previousPetTypeLabel.Text = Modlist[animalIndex].PetType;
            previousPetGenderLabel.Text = Modlist[animalIndex].Gender;
            if(Modlist[animalIndex].IsSterilized)
            {
                previousIsSterilizedLabel.Text = "Yes";
            }
            else
            {
                previousIsSterilizedLabel.Text = "No";
            }
            previousPedigreeLabel.Text = Modlist[animalIndex].Pedigree;
            previousDateLabel.Text = Modlist[animalIndex].DateEntry;
            previousVaccine1Label.Text = Modlist[animalIndex].Vaccine[0];
            previousVaccine2Label.Text = Modlist[animalIndex].Vaccine[1];
            previousVaccine3Label.Text = Modlist[animalIndex].Vaccine[2];
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (petNameTextBox.Text != string.Empty)
                Modlist[animalIndex].PetName = petNameTextBox.Text;

            if (petTypeComboBox.Text != string.Empty)
                Modlist[animalIndex].PetType = petTypeComboBox.Text;

            if (petColorTextBox.Text != string.Empty)
                Modlist[animalIndex].PetColor = petColorTextBox.Text;

            if (genderComboBox.Text != string.Empty)
                Modlist[animalIndex].Gender = genderComboBox.Text;

            if (sterilizedComboBox.Text != string.Empty)
            {
                if (sterilizedComboBox.Text == "Yes")
                {
                    Modlist[animalIndex].IsSterilized = true;
                }
                else if (sterilizedComboBox.Text == "No")
                {
                    Modlist[animalIndex].IsSterilized = false;

                }
            }

            if(pedrigreeTextBox.Text != string.Empty)
            {
                Modlist[animalIndex].Pedigree = pedrigreeTextBox.Text;
            }

            if(dateTimePicker.Text != "5/7/2022")
            {
                Modlist[animalIndex].DateEntry = dateTimePicker.Text;
            }

            if (vaccine1TextBox.Text != string.Empty)
            {
                Modlist[animalIndex].Vaccine[0] = vaccine1TextBox.Text;
            }

            if (vaccine2TextBox.Text != string.Empty)
            {
                Modlist[animalIndex].Vaccine[1] = vaccine1TextBox.Text;
            }

            if (vaccine3TextBox.Text != string.Empty)
            {
                Modlist[animalIndex].Vaccine[2] = vaccine1TextBox.Text;
            }

            if (petPictureBox.Text != Modlist[animalIndex].PetPhotoName)
            {
                Modlist[animalIndex].PetPhotoName = petPictureBox.Text;
            }

            this.Close();
        }

        private void petPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                petPictureBox.Image = new Bitmap(open.FileName);
                // image file path  
                petPictureBox.Text = open.FileName;
            }

        }
    }
}
