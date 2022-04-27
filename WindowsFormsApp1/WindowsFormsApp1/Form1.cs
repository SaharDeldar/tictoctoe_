using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button[,] Dynamicbutten;
        int ply ,i,j;
        public Form1()
        {
            InitializeComponent();

            Dynamicbutten = new Button[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    CreateDynamicButton();

                   
                }
            }


            //button1.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button2.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button3.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button4.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button5.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button6.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button7.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button8.Click += new System.EventHandler(this.Dynamicbutten_click);
            //button9.Click += new System.EventHandler(this.Dynamicbutten_click);

            newgame();
        }
        private void CreateDynamicButton()
        {
            Button Dynamicbutten = new Button();
            Dynamicbutten.Click += new EventHandler(Dynamicbutten_click);
            
            Dynamicbutten.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
            tableLayoutPanel1.Controls.Add(Dynamicbutten, i, j);
        }


        private void Dynamicbutten_click(object sender,EventArgs e)
        {
            MessageBox.Show("Dynamicbutten is clicked");
        }



        private void button9_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.ForeColor = Color.DarkGreen;
                    this_button.BackColor = Color.LightGreen;

                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.ForeColor = Color.Red;
                    this_button.BackColor = Color.Pink;
                    ply = 1;
                }
                chekgame();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newgame();
        }
        private void newgame()
        {
            ply = 1;
           
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 3; j++)
                {

                    Dynamicbutten[i, j].Text = "";
                    Dynamicbutten[i, j].BackColor = Color.Purple;
                }
            }
        }
        private void chekgame()
        {
           if(Dynamicbutten[0,0].Text== "X" && Dynamicbutten[0,1].Text== "X" && Dynamicbutten[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
          else if (Dynamicbutten[1, 0].Text == "X" && Dynamicbutten[1, 1].Text == "X" && Dynamicbutten[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (Dynamicbutten[2, 0].Text == "X" && Dynamicbutten[2, 1].Text == "X" && Dynamicbutten[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }

            else if (Dynamicbutten[0, 0].Text == "X" && Dynamicbutten[1, 0].Text == "X" && Dynamicbutten[2,0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 1].Text == "X" && Dynamicbutten[1, 1].Text == "X" && Dynamicbutten[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (Dynamicbutten[2, 0].Text == "X" && Dynamicbutten[2, 1].Text == "X" && Dynamicbutten[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }

            else if (Dynamicbutten[0, 0].Text == "X" && Dynamicbutten[1, 1].Text == "X" && Dynamicbutten[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 2].Text == "X" && Dynamicbutten[1, 1].Text == "X" && Dynamicbutten[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 0].Text == "O" && Dynamicbutten[0, 1].Text == "O" && Dynamicbutten[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[1, 0].Text == "O" && Dynamicbutten[1, 1].Text == "O" && Dynamicbutten[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[2, 0].Text == "O" && Dynamicbutten[2, 1].Text == "O" && Dynamicbutten[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 0].Text == "O" && Dynamicbutten[1, 0].Text == "O" && Dynamicbutten[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 1].Text == "O" && Dynamicbutten[1, 1].Text == "O" && Dynamicbutten[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[2, 0].Text == "O" && Dynamicbutten[2, 1].Text == "O" && Dynamicbutten[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }

            else if (Dynamicbutten[0, 0].Text == "O" && Dynamicbutten[1, 1].Text == "O" && Dynamicbutten[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 2].Text == "O" && Dynamicbutten[1, 1].Text == "O" && Dynamicbutten[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (Dynamicbutten[0, 0].Text != "" && Dynamicbutten[0, 1].Text != "" && Dynamicbutten[0, 2].Text != "" && Dynamicbutten[1, 0].Text != "" && Dynamicbutten[1, 1].Text != "" && Dynamicbutten[1, 2].Text != "" && Dynamicbutten[2, 0].Text != "" && Dynamicbutten[2, 1].Text != "" && Dynamicbutten[2, 2].Text != "")
            {
                MessageBox.Show("مساوی امتیازات برابر هستند");
                newgame();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          //  if (radioButton2.Text="O")
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
} 
