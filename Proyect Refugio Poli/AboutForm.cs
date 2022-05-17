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
      Class form: AboutForm
      Description: Contains the developers of this application
      Developed by: Christian Santiago Valentin #120535
                    Rafael Charneco Gonzalez #120490
     */
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
