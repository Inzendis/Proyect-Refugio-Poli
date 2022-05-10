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
        private string dateToSearch;
       
        public ReportForm()
        {
            InitializeComponent();
        }
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

        //DataGridView
        private void DataGridView_Update(object sender, EventArgs e)
        {
            List<AnimalInfo> listToShow = new List<AnimalInfo>();
            

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].DateEntry == dateToSearch)
                {
                    listToShow.Add(list[i]);
                   
                }
            }

            animalDataGridView.DataSource = listToShow;
            for (int i = 0; i < listToShow.Count; i++)
            {
                animalDataGridView.Rows[i].Cells["Vaccine1"].Value = listToShow[i].Vaccine[0];
                animalDataGridView.Rows[i].Cells["Vaccine2"].Value = listToShow[i].Vaccine[1];
                animalDataGridView.Rows[i].Cells["Vaccine3"].Value = listToShow[i].Vaccine[2];
            }
 

        }
    }
}
