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
            infoTextBox.Text = $"{list[index].PetName}\r\n";
        }

       
    }
}
