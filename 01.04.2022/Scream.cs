using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._04._2022
{
    public partial class Scream : Form
    {
        public Scream()
        {
            InitializeComponent();
        }
        

        private void Scream_Load_1(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            this.Left = 1;
            this.Top = 1;
            this.Opacity =1; //This line added 

            this.Width = Screen.PrimaryScreen.Bounds.Width ;
            this.Height = Screen.PrimaryScreen.Bounds.Height ;

            this.BackgroundImage = Properties.Resources.image; //We set the image once here

            this.TopMost = true;
        }
    }
}
