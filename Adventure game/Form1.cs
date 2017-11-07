using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_game
{
    public partial class Form1 : Form
    {        Random randGen = new  Random() ;
        int scene = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            int rand = randGen.Next(1, 10);
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 4) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 6)
                {
                    if (rand > 90) { scene = 8; }
                    else { scene = 9; }
                }
                else if (scene == 9) { scene = 11; }
                else if (scene == 2) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 17) { scene = 15; }
                else if (scene == 11) { scene = 1; }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 4) { scene = 7; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 2) { scene = 20; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 12) { scene = 1; }
                else if (scene == 20) { scene = 17; }
                else if (scene == 17) { scene = 18; }
            }
            else if (e.KeyCode == Keys.N)  //green button press
            {
                if (scene == 12) { scene = 13; }
              
            }
            else if (e.KeyCode == Keys.Space)  //yellow button press
            {
              
            }

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "you are a bear what do you want to do ";
                    break;

                case 1:
                    outputLabel.Text = "you approach a river \n do you try and catch fish " +
                        "or cross the river";
                    break;

                case 2:
                    outputLabel.Text = "you wander in the wood you see a deer " +
                        "do you charge or sneak up on it ";
                    break;

                case 3:
                    outputLabel.Text = "you cross the river and you see a pack of monkeys charging" +
                        " you do you run or attack";
                    break;

                case 4:
                    outputLabel.Text = "you catch 3 fish  \n do you stay " +
                        "and catch more or cross";
                    break;

                case 5:
                    outputLabel.Text = "they are faster than you and" +
                        " you are overwelmed and die ";
                    break;

                case 6:
                    outputLabel.Text = "you stand on your back legs. \n" +
                        " do you windmill menuver or dropkick ";
                    break;
                case 7:
                    outputLabel.Text = "you catch 3 more fish you win";
                    break;
                case 8:
                    outputLabel.Text = "you get overwhlmed by monkeys and die  ";
                    break;
                case 9:
                    outputLabel.Text = "you defeat all the monkeys /n do you hunt or sleep ";
                    break;
                case 10:
                    outputLabel.Text = "you have a great sleep and you win ";
                    break;
                case 11:
                    outputLabel.Text = "you stay up all night and die from exaution ";
                    break;
                case 12:
                    outputLabel.Text = "you kill the dear and survive \n de you go to the river or stay and serach for dear or slee  ";
                    break;
                case 13:
                    outputLabel.Text = "WIP ";
                    break;

            }







        }
    }
}
