using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap_Demo_1 // Chequerboard
{
    public partial class Form1 : Form //inheritance
    {
        public Form1() //constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            //Button button = new Button(); // create button object
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My button";
            //this.Controls.Add(button);

            GenerateButtons();// Refactor,extract,extract method. Set as method.
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8]; // create button object array
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {

                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]);

                }

                top += 50;
                left = 0;

            }
        }
    }
}
