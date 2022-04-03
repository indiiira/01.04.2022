using System;
using System.IO;
using System.Windows.Forms;

namespace _01._04._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }


        private void start_Click(object sender, EventArgs e)
        {

            Game g = new Game();
            g.Show();
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine(reg.Text);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}

