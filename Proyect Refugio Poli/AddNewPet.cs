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
      Class form: AddNewPet
      Description: Receives AnimalInfo list through reference in parameter constructor
      Asks for all the information needed of AnimalInfo.
      Developed by: Christian Santiago Valentin #120535
                    Rafael Charneco Gonzalez #120490
     */
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
               

            }catch(FormatException)
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

        // Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            //If any of the fields are not filled, do not add
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
                animalInfo.DateEntry = dateTimePicker.Text; 
                animalInfo.Vaccine.Add(vaccine1TextBox.Text);
                animalInfo.Vaccine.Add(vaccine2TextBox.Text);
                animalInfo.Vaccine.Add(vaccine3TextBox.Text);
                list.Add(animalInfo);
                this.Close();
            }
            else // Fields are not filled completely
            {
                MessageBox.Show("Missing information.", "Error");
            }
        }

        //Adds picture on click and file selected
        private void petPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                petPictureBox.Image = new Bitmap(open.FileName);
                // image file path  
                petPictureBox.Text = open.FileName;

                animalInfo.PetPhotoName = open.FileName;
            }
            if (animalInfo.PetPhotoName != string.Empty)
            {
                ClickToSelectLabel.Visible = false;
            }
            
        }

        //Close button click event
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
