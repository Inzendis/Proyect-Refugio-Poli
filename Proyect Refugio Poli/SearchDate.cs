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
    public partial class SearchDate : Form
    {
        private List<AnimalInfo> list = new List<AnimalInfo>();
        private ReportForm reportform;
        public SearchDate()
        {
            InitializeComponent();
        }

        public SearchDate(List<AnimalInfo> aList)
        {
            InitializeComponent();
            list = aList;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void searchDateButton_Click(object sender, EventArgs e)
        {
            string date = searchDatePicker.Text;
            reportform = new ReportForm(list, date);
            reportform.Show();
            this.Close();
        }
    }
}
