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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            //Form2 frm2 = new Form2();
            //frm2.Show();
           
        }
        //string lines = reg.Text;

        private void start_Click(object sender, EventArgs e)
        {
            //Program.f1.time_Click(sender, e);
            Game g = new Game();
            g.Show();
        }
    }

      
}

