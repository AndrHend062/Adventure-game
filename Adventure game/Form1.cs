//adventure game andrew henderson
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Adventure_game
{
    public partial class Form1 : Form
    {        Random randGen = new  Random() ;
        int scene = 0;
        int day = 0;
        int Starve = 0 ;

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
                else if (scene == 5) { scene = 99; }
                else if (scene == 8) { scene = 99; }
                else if (scene == 11) { scene = 99; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 10) { scene = 100; }
                else if (scene == 7) { scene = 100; }
                else if (scene == 16) { scene = 100; }
                else if (scene == 18) { scene = 100; }
                else if (scene == 6)
                {
                    if (rand > 90) { scene = 8; }
                    else { scene = 9; }
                }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { scene = 100; }
                else if (scene == 2) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 17) { scene = 15; }
                else if (scene == 11) { scene = 1; }
                else if (scene == 99) { scene = 0; }
                else if (scene == 100) { scene = 0; }
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
                else if (scene == 100) { scene = 101; }
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
                    outputLabel.Text = "you are a bear what do you want to do \n go to river or the woods";
                    redLabel.Text = "river ";
                    blueLabel.Text = "woods ";
                    break;

                case 1:
                    outputLabel.Text = "you approach a river \n do you try and catch fish " +
                        "or cross the river";
                      redLabel.Text = "cross ";
                    blueLabel.Text = "catch fish ";
                    break;

                case 2:
                    outputLabel.Text = "you wander in the wood you see a deer " +
                        "\n do you charge or sneak up on it ";
                      redLabel.Text = "sneek  ";
                    blueLabel.Text = "charge ";
                    break;

                case 3:
                    outputLabel.Text = "you cross the river and you see a pack of monkeys charging" +
                        " you do you run or attack";
                      redLabel.Text = "run ";
                    blueLabel.Text = "attack ";
                    break;

                case 4:
                    outputLabel.Text = "you catch 3 fish  \n do you stay " +
                        "and catch more or cross";
                      redLabel.Text = "cross ";
                    blueLabel.Text = "catch more ";
                    break;

                case 5:
                    outputLabel.Text = "they are faster than you and" +
                        " you are overwelmed and die ";
                      redLabel.Text = "river ";
                    blueLabel.Text = "woods ";
                    break;

                case 6:
                    outputLabel.Text = "you stand on your back legs. \n" +
                        " do you windmill menuver or dropkick ";
                    redLabel.Text = "windmill ";
                    blueLabel.Text = "dropkick ";
                    break;
                case 7:
                    outputLabel.Text = "you catch 3 more fish you survive";
                    redLabel.Text = "continue  ";
                    blueLabel.Text = " ";
                    break;
                    

                case 8:
                    outputLabel.Text = "you get overwhlmed by monkeys and die  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    break;
                    

                case 9:
                    outputLabel.Text = "you defeat all the monkeys /n do you hunt or sleep ";
                    redLabel.Text = "hunt ";
                    blueLabel.Text = "sleep ";
                    break;
                    

                case 10:
                    outputLabel.Text = "you have a great sleep  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    break;
                    

                case 11:
                    outputLabel.Text = "you stay up all night and die from exaution ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    break;
                    

                case 12:
                    outputLabel.Text = "you kill the dear and survive \n do you go to the river or stay and serach for dear or sleep  ";
                    redLabel.Text = "serach ";
                    blueLabel.Text = "river ";
                    greenLabel.Text = "sleep";
                    break;
                    

                case 13:
                    outputLabel.Text = "you spot a Sheep. it does not see you yet  what do you do \n sleep or attack ";
                    redLabel.Text = "sleep ";
                    blueLabel.Text = "attack ";
                    break;
                    

                case 14:
                    outputLabel.Text = "you have a good nights sleep ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    break;

                 case 15:
                    outputLabel.Text = "you die from the wolf in disguise  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    break;

                 case 16:
                    outputLabel.Text = "you have a good nights sleep ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    break;

                 case 17:
                    outputLabel.Text = "you spot a Sheep. it does not see you yet what do you do \n attack or sleep ";
                    redLabel.Text = "attack ";
                    blueLabel.Text = "sleep ";
                    break;

                 case 18:
                    outputLabel.Text = "you have a bad nights sleep with no food \n ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    Starve++; 
                    break;

                 case 19:
                    outputLabel.Text = "WIP ";
                    break;

                 case 20:
                    outputLabel.Text = "the dear gets spooked and runs away do you \n go to the river or look for more dear  ";
                    redLabel.Text = "river ";
                    blueLabel.Text = "more dear ";
                    break;

                 case 99: //loser restart 
                    outputLabel.Text = "you died do you want to try again ";
                    redLabel.Text = "yes ";
                    blueLabel.Text = "no ";
                    break; 

                 case 100: // win restart 
                    outputLabel.Text = "you survived do you want to continue to next day ";
                    redLabel.Text = "yes ";
                    blueLabel.Text = "no ";
                    day++;
                    break;

                 case 101: //closing 
                    outputLabel.Text = " ";
                    Thread.Sleep(100);
                    this.Close();
                    break;

            }

        }
    }
}
