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
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            Modlist[animalIndex].PetName = petNameTextBox.Text;

            this.Close();
        }
    }
}
