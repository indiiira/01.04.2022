using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _01._04._2022
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            AssignIconsToSquares();
            Width = 20;


            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;

            timer1.Tick += timer1_Tick;
        }

        private readonly Random random = new Random();
        private readonly List<string> icons = new List<string>()
        {
             "!", "s", "s", "s", "s", "s", "s",
              "s", "s", "s", "s", "s", "s", "s",
               "s", "s", "s", "s", "s", "s", "s",
                "s", "s", "s", "s"
        };
        private readonly string[] nums = {   "!", "s", "s", "s", "s", "s", "s",
              "s", "s", "s", "s", "s", "s", "s",
               "s", "s", "s", "s", "s", "s", "s",
                "s", "s", "s", "s" };

        private void AssignIconsToSquares()
        {

            foreach (Control control in panelgame.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }

        }


        public static void Shuffle(string[] arr)
        {
            // создаем экземпляр класса Random для генерирования случайных чисел
            Random rand = new Random();

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                string tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
        private void AssignIconsToSquare()
        {

            foreach (Control control in panelgame.Controls)
            {
                Label iconLabel = control as Label;

                int j = 24;

                int randomNumber = random.Next(j);
                j--;
                iconLabel.Text = nums[randomNumber];
                iconLabel.ForeColor = iconLabel.BackColor;
                Shuffle(nums);

            }

        }

        private Label firstClicked = null;
        private Label secondClicked = null;
        private int v = 0;
        private void label1_Click(object sender, EventArgs e)
        {


            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                Label iconLabel = firstClicked;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;
            if ((secondClicked.Text) == "!")
            {
                v++;
                MessageBox.Show("Поздравляю вы нашли паучка!!!");
                AssignIconsToSquare();
            }


        }

        private readonly int koef = 1;




        // обработчик нажатия на кнопку
        private int h;
        private int m;
        private int s = 50;

        private void timer_Click(object sender, EventArgs e)
        {



            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if ((h == 0 && m == 0 && s == 0) & (v == 10))
            {
                timer1.Stop();





                using (StreamWriter w = File.AppendText("log.txt"))

                {
                    w.WriteLine("Баллы " + v);
                }
                MessageBox.Show("Поздравляю вы выиграли!!!");

            }
            else if ((h == 0 && m == 0 && s == 0) & (v != 10))
            {
                timer1.Stop();
                Opacity = 20; //We show the window
                System.Threading.Thread.Sleep(100);

                Opacity = 20; //We hide the window
                Scream newForm = new Scream();
                newForm.Show();
                using (StreamWriter w = File.AppendText("log.txt"))

                {
                    w.WriteLine("Баллы " + v);
                }
            }
            time1.Text = Convert.ToString(h);
            time2.Text = Convert.ToString(m);
            time3.Text = Convert.ToString(s);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();

        }


    }
}


