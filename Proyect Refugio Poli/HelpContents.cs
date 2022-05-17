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
      Class form: HelpContents
      Description: Contains an explanation of each functionality of the app.
      Developed by: Christian Santiago Valentin #120535
                    Rafael Charneco Gonzalez #120490
     */
    public partial class HelpContents : Form
    {
        public HelpContents()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
