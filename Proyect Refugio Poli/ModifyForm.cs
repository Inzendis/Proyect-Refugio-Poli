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
     ModifyForm 
     After searching through SearchForm, ModifyForm will get the list and index at which the pet was found.
     When the parameter constructor is called, all the textboxes will be filled with the pet's current information.
     If any of the information is changed, on save button click the changes will be applied.
     */
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

            //Filling the text boxes with current pet's information
            petNameTextBox.Text = Modlist[animalIndex].PetName;

            petPictureBox.Image = new Bitmap(Modlist[animalIndex].PetPhotoName);
            petPictureBox.Text = Modlist[animalIndex].PetPhotoName;

            petColorTextBox.Text = Modlist[animalIndex].PetColor;
            petTypeComboBox.Text = Modlist[animalIndex].PetType;
            genderComboBox.Text = Modlist[animalIndex].Gender;
            if(Modlist[animalIndex].IsSterilized)
            {
                sterilizedComboBox.Text = "Yes";
            }
            else
            {
                sterilizedComboBox.Text = "No";
            }
            pedrigreeTextBox.Text = Modlist[animalIndex].Pedigree;
            dateTimePicker.Text = Modlist[animalIndex].DateEntry;
            vaccine1TextBox.Text = Modlist[animalIndex].Vaccine[0];
            vaccine2TextBox.Text = Modlist[animalIndex].Vaccine[1];
            vaccine3TextBox.Text = Modlist[animalIndex].Vaccine[2];
        }

        //Save button on click event
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //If any of the texboxes or picture is empty, the save will not occur.
            if (petNameTextBox.Text != String.Empty && petPictureBox.Text != String.Empty && petColorTextBox.Text != string.Empty && genderComboBox.Text != string.Empty
                && sterilizedComboBox.Text != string.Empty && pedrigreeTextBox.Text != string.Empty && vaccine1TextBox.Text != string.Empty && vaccine2TextBox.Text != string.Empty
                && vaccine3TextBox.Text != string.Empty)
            {
                Modlist[animalIndex].PetName = petNameTextBox.Text;
                Modlist[animalIndex].PetType = petTypeComboBox.Text;
                Modlist[animalIndex].PetColor = petColorTextBox.Text;
                Modlist[animalIndex].Gender = genderComboBox.Text;

                if (sterilizedComboBox.Text == "Yes")
                {
                    Modlist[animalIndex].IsSterilized = true;
                }
                else if (sterilizedComboBox.Text == "No")
                {
                    Modlist[animalIndex].IsSterilized = false;
                }
                Modlist[animalIndex].Pedigree = pedrigreeTextBox.Text;
                Modlist[animalIndex].DateEntry = dateTimePicker.Text;

                Modlist[animalIndex].Vaccine[0] = vaccine1TextBox.Text;
                Modlist[animalIndex].Vaccine[1] = vaccine2TextBox.Text;
                Modlist[animalIndex].Vaccine[2] = vaccine3TextBox.Text;
                Modlist[animalIndex].PetPhotoName = petPictureBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Missing information.", "Error");
            }
        }

        //Checks that only combo box options are selected in PetType
        private void PetTypeCheck(object sender, EventArgs e)
        {
            try
            {
                if (petTypeComboBox.Text != string.Empty)
                {

                    if (petTypeComboBox.SelectedIndex <= -1)
                    {
                        throw new FormatException();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid pet type answer.", "Error");
                petTypeComboBox.Focus();
                petTypeComboBox.SelectAll();
            }
        }

        //Checks that only combo box options are selected in Gender
        private void GenderCheck(object sender, EventArgs e)
        {
            try
            {
                if (genderComboBox.Text != string.Empty)
                {

                    if (genderComboBox.SelectedIndex <= -1)
                    {
                        throw new FormatException();
                    }

                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid gender answer.", "Error");
                genderComboBox.Focus();
                genderComboBox.SelectAll();
            }
        }

        //Checks that only combo box options are selected in IsSterilized
        private void IsSterilized(object sender, EventArgs e)
        {
            try
            {
                if (sterilizedComboBox.Text != string.Empty)
                {
                    if (sterilizedComboBox.SelectedIndex <= -1)
                    {
                        throw new FormatException();
                    }

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid sterilized answer.", "Error");
                sterilizedComboBox.Focus();
                sterilizedComboBox.SelectAll();
            }
        }
        //Adds picture on click and file selected
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
