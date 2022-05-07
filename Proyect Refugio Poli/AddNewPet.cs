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
            if (petNameTextBox.Text != String.Empty && petPictureBox.Text != String.Empty)
            {
                list.Add(animalInfo);
                this.Close();
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
    }
    
}
