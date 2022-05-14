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
     ReportForm 
     Displays all the pets logged within the given date.
     Doesn't show picture directory or picture.
     Uses DataGridView to display data populated with a new list of AnimalInfo containing only pets with same entry date.
     */
    public partial class ReportForm : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        private string dateToSearch;
       
        public ReportForm()
        {
            InitializeComponent();
        }
        //Parameter Constructor
        public ReportForm(List<AnimalInfo> alist, string aDate)
        {
            InitializeComponent();
            list = alist;
            dateToSearch = aDate;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DataGridView Update event when form is activated/entered
        private void DataGridView_Update(object sender, EventArgs e)
        {
            List<AnimalInfo> listToShow = new List<AnimalInfo>();
            

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].DateEntry == dateToSearch)
                {
                    listToShow.Add(list[i]);          // New list adding only the animals with same entry date chosen.
                   
                }
            }

            animalDataGridView.DataSource = listToShow; // Populates DataGridView data
            for (int i = 0; i < listToShow.Count; i++) // Fills the columns of Vaccine 1 to 3 with a list inside list of AnimalInfo
            {
                animalDataGridView.Rows[i].Cells["Vaccine1"].Value = listToShow[i].Vaccine[0];
                animalDataGridView.Rows[i].Cells["Vaccine2"].Value = listToShow[i].Vaccine[1];
                animalDataGridView.Rows[i].Cells["Vaccine3"].Value = listToShow[i].Vaccine[2];
            }
 

        }
    }
}
