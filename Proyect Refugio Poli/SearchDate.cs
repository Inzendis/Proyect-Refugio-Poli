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
     SearchDate form
     Asks for a date to be used in ReportForm
     */
    public partial class SearchDate : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        private ReportForm reportform;
        public SearchDate()
        {
            InitializeComponent();
        }

        //Parameter constructor
        public SearchDate(List<AnimalInfo> aList)
        {
            InitializeComponent();
            list = aList;
            searchDateButton.Select();
            searchDateButton.Focus();
        }


        // Search Date button click event
        private void searchDateButton_Click(object sender, EventArgs e)
        {
                string date = searchDatePicker.Text;
                reportform = new ReportForm(list, date);
                reportform.Show();
                this.Close();      
        }

        //Enter key pressed which will cause a click on search date button
        private void enterButton_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               searchDateButton.PerformClick();
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
