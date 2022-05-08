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
    public partial class ReportForm : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        int count = 0;
        public ReportForm()
        {
            InitializeComponent();
        }
        public ReportForm(List<AnimalInfo> alist)
        {
            InitializeComponent();
            list = alist;
            count = list.Count();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_Update(object sender, EventArgs e)
        {
            for (int i = 1; i <= count; i++)
            {
               // animalDataGridView.Rows.Add(list[i].PetName, list[i].PetPhotoName, list[i].PetType, list[i].PetColor, list[i].Gender, list[i].IsSterilized, list[i].Pedigree, list[i].DateEntry);
            }
        }
    }
}
