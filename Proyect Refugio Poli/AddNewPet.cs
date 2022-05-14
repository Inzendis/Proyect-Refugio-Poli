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
        private void PetTypeCheck(object sender, EventArgs e)
        {
            bool found = false; 
                try
                {
                    if (petTypeComboBox.Text != string.Empty)
                    {
                        foreach (string petType in petTypeComboBox.Items)
                        {
                            if (petType == (string)petTypeComboBox.SelectedItem)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found == false)
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
        private void GenderCheck(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                if (genderComboBox.Text != string.Empty)
                {
                    foreach(string petGender in genderComboBox.Items)
                    {
                        if (petGender == (string)genderComboBox.SelectedItem)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        throw new FormatException();
                    }             
                }
               

            }catch(FormatException)
            {
                MessageBox.Show("Invalid gender answer.", "Error");
                genderComboBox.Focus();
                genderComboBox.SelectAll();
            }
        }

        private void IsSterilized(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                if (sterilizedComboBox.Text != string.Empty)
                {
                    foreach (string answer in sterilizedComboBox.Items)
                    {
                        if (answer == (string)sterilizedComboBox.SelectedItem)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
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


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (petNameTextBox.Text != String.Empty && petPictureBox.Text != String.Empty && petColorTextBox.Text != string.Empty && genderComboBox.Text != string.Empty
                && sterilizedComboBox.Text != string.Empty && pedrigreeTextBox.Text != string.Empty && vaccine1TextBox.Text != string.Empty && vaccine2TextBox.Text != string.Empty
                && vaccine3TextBox.Text != string.Empty)
            {
                animalInfo.PetName = petNameTextBox.Text;
                animalInfo.PetType = petTypeComboBox.Text;
                animalInfo.PetColor = petColorTextBox.Text;
                animalInfo.Gender = genderComboBox.Text;
                if (sterilizedComboBox.Text == "Yes")
                    animalInfo.IsSterilized = true;
                else
                    animalInfo.IsSterilized = false;
                animalInfo.Pedigree = pedrigreeTextBox.Text;
                animalInfo.DateEntry = dateTimePicker.Text; // Please fix
                animalInfo.Vaccine.Add(vaccine1TextBox.Text);
                animalInfo.Vaccine.Add(vaccine2TextBox.Text);
                animalInfo.Vaccine.Add(vaccine3TextBox.Text);
                list.Add(animalInfo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Missing information.", "Error");
            }
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

                animalInfo.PetPhotoName = open.FileName;
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
