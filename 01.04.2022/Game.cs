using _01._04._2022.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace _01._04._2022
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            AssignIconsToSquares();
            this.Width = 400;
            button1.Width = 40;
            button1.Left = 40;
            button1.Text = "";
            button1.BackColor = Color.Aqua;

            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;
            button1.Click += timer_Click;
            timer1.Tick += timer1_Tick;
        }
        Random random = new Random();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
        {
             "!", "s", "s", "s", "s", "s", "s",
              "s", "s", "s", "s", "s", "s", "s",
               "s", "s", "s", "s", "s", "s", "s",
                "s", "s", "s", "s"
        };
        string[] nums = {   "!", "s", "s", "s", "s", "s", "s",
              "s", "s", "s", "s", "s", "s", "s",
               "s", "s", "s", "s", "s", "s", "s",
                "s", "s", "s", "s" };
        //Image images = Resources.image;
        //List<Image> pic = new List<Image>(){};
        //pic.Add(Image(Properties.Resources.image));
        //Bitmap bmp = new Bitmap(_01._04._2022.Properties.Resources.image);
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
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
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in panelgame.Controls)
            {
                Label iconLabel = control as Label;
              int i= 0;
                int j = 24;
               
                    int randomNumber = random.Next(j);
                    j--;
                    iconLabel.Text = nums[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    Shuffle(nums);
                
            }

        }
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;
        int vote = 0;
        
        private void label1_Click(object sender, EventArgs e)
        {
            //foreach (Control contr in panelgame.Controls)
            //{
            //    Label iconLabel = contr as Label;
            //    if (Convert.ToString(iconLabel) != "!")
            //    {
            //        AssignIconsToSquare();
            //        vote++;

            //    }
            //}

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                Label iconLabel = firstClicked as Label;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
            int v = 0;
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;
            if ((secondClicked.Text) == "!")
            {
                v++;
                MessageBox.Show("Поздравляю вы нашли паучка!!!");
                AssignIconsToSquare();
            }
        }
            int koef = 1;


        // обработчик события Tick таймера
        //void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (button1.Left == (this.Width - button1.Width - 10))
        //    {
        //        koef = -1;
        //    }
        //    else if (button1.Left == 0)
        //    {
        //        koef = 1;
        //    }
        //    button1.Left += 10 * koef;
        //}
        // обработчик нажатия на кнопку
        int h;
        int m;
        int s=15;
        void timer_Click(object sender, EventArgs e)
        {
            //if (timer1.Enabled == true)
            //{
            //    timer1.Stop();
            //}
            //else
            //{
            //    timer1.Start();
            //}



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
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                this.Opacity =20; //We show the window
                System.Threading.Thread.Sleep(100);
              
                this.Opacity = 20; //We hide the window
                Scream newForm = new Scream();
                newForm.Show();
              
            }
            time1.Text = Convert.ToString(h);
            time2.Text = Convert.ToString(m);
            time3.Text = Convert.ToString(s);

        }

       
    }
    }

    
