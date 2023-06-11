using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace start
{
    public partial class Form2 : Form
    {
        int second ;

        public Form2()
        {
            InitializeComponent();  
        }




        //SET default TIME value FOR Difficulty
        private void Difficulty()
        {
            if (radioButton1.Checked == true)
            {
                second = 14;//FOR EASY MODE
            }

            else if (radioButton2.Checked == true)
            {
                second = 11;//FOR MEDIUM MODE
            }

            else if (radioButton3.Checked == true)
            {
                second = 8;//FOR HARD MODE
            }
        }



        //Default TIME  (can use for reset time to default time)
        private void fulltime()
        {
            Difficulty();
            timer1.Start();
            time.Text = second.ToString();//GET Value (second) for appear in Design page
        }



        //SET VALUE of TIME BONUS
        private void Reward()
        {
            if (radioButton1.Checked == true)
            {
                second = second + 8;//FOR EASY MODE
            }

            else if (radioButton2.Checked == true)
            {
                second = second + 7;//FOR MEDIUM MODE
            }

            else if (radioButton3.Checked == true)
            {
                second = second + 6;//FOR HARD MODE
            }

        }

        //SET POSITION (horizontally center form)
        private void welcome()
        {
            label9.Left = (this.Width - label9.Width) / 2; //WELCOME 
            label2.Left = (this.Width - label2.Width) / 2; //@BabeGotBytes 
        }


        //Bigger FORM 
        //Changes POSITION OF Right & Bottom OBJECTs to fit with bigger form
        //Changes & Smaller Aliens
        //RANDOM position of Aliens INSIDE the Form
        private void resizes()
        {
            
            Random r = new Random();

            //RANDOM position of First Aliens
            int x = r.Next(150, 600);
            int y = r.Next(50, 250);
            pictureBox2.Top = y;
            pictureBox2.Left = x;

            //Set for Second Aliens
            if (score.Text == "10")
            {
                Reward();
                
                Size = new Size(760, 380); //SET Bigger Size
                
                //Can't REZIABLE after set size already
                MaximumSize = new Size(760, 380);
                MinimumSize = new Size(760, 380);
                welcome();
                //Changes POSITION OF Right & Bottom OBJECTs fit with bigger form
                button1.Location = new Point(630, 25);
                button3.Location = new Point(25, 280);
                button5.Location = new Point(550, 280);
                time.Location = new Point(115, 295);
                score.Location = new Point(645, 290);

                //RANDOM position of Second Aliens
                x = r.Next(150, 630);
                y = r.Next(50, 290);
                pictureBox2.Top = y;
                pictureBox2.Left = x;


                pictureBox2.Image = Properties.Resources.a2; //SET NEW Aliens
                pictureBox2.Size = new Size(90, 75); //Smaller Aliens

            }

            //Set for Third Aliens
            else if (score.Text == "20")
            {
                Reward();
               
                Size = new Size(780, 400);
                MaximumSize = new Size(780, 400);
                MinimumSize = new Size(780, 400);
                welcome();
                button1.Location = new Point(650, 25);
                button3.Location = new Point(25, 300);
                button5.Location = new Point(570, 300);
                time.Location = new Point(115, 315);
                score.Location = new Point(665, 310);

                x = r.Next(150, 650);
                y = r.Next(50, 310);
                pictureBox2.Top = y;
                pictureBox2.Left = x;

                pictureBox2.Image = Properties.Resources.a3;
                pictureBox2.Size = new Size(60, 80);

            }

            else if (score.Text == "30")
            {
                Reward();
                
                Size = new Size(800, 420);
                MaximumSize = new Size(800, 420);
                MinimumSize = new Size(800, 420);
                welcome();
                button1.Location = new Point(670, 25);
                button3.Location = new Point(25, 320);
                button5.Location = new Point(590, 320);
                time.Location = new Point(115, 335);
                score.Location = new Point(685, 330);

                x = r.Next(150, 670);
                y = r.Next(50, 330);
                pictureBox2.Top = y;
                pictureBox2.Left = x;

                pictureBox2.Image = Properties.Resources.a4;
                pictureBox2.Size = new Size(70, 60);

            }

            else if (score.Text == "40")
            {
                Reward();
                
                Size = new Size(820, 440);
                MaximumSize = new Size(820, 440);
                MinimumSize = new Size(820, 440);
                welcome();
                button1.Location = new Point(690, 25);
                button3.Location = new Point(25, 340);
                button5.Location = new Point(610, 340);
                time.Location = new Point(115, 355);
                score.Location = new Point(705, 350);

                x = r.Next(150, 690);
                y = r.Next(50, 350);
                pictureBox2.Top = y;
                pictureBox2.Left = x;

                pictureBox2.Image = Properties.Resources.a5;
                pictureBox2.Size = new Size(40, 50);

            }

            else if (score.Text == "50")
            {
                Reward();
                
                Size = new Size(840, 460);
                MaximumSize = new Size(840, 460);
                MinimumSize = new Size(840, 460);
                welcome();
                button1.Location = new Point(710, 25);
                button3.Location = new Point(25, 360);
                button5.Location = new Point(630, 360);
                time.Location = new Point(115, 375);
                score.Location = new Point(725, 370);

                x = r.Next(150, 710);
                y = r.Next(50, 370);
                pictureBox2.Top = y;
                pictureBox2.Left = x;

                pictureBox2.Image = Properties.Resources.a6;
                pictureBox2.Size = new Size(30, 40);

            }
        }





        //FORM2 (set default form before click START)
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            
            pictureBox2.Visible = false; 
            score.Text = "0";
            label9.Text = "WELCOME " + Class1.name; //GET VALUE (name) FROM Form1
            welcome();
        }

       


        //START BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e); //RESTART Form2

            DialogResult result = new DialogResult();

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked == true ) //Click one of Difficulty
            {

                //SET Default Operation for First Aliens
                
                fulltime();
                Size = new Size(670, 360);
                MaximumSize = new Size(670, 360);
                MinimumSize = new Size(670, 360);
                welcome();
                button1.Location = new Point(540, 25);
                button3.Location = new Point(25, 260);
                button5.Location = new Point(460, 260);
                time.Location = new Point(115, 275);
                score.Location = new Point(555, 270);

                pictureBox2.Image = Properties.Resources.a1;
                pictureBox2.Size = new Size(110, 115);
                pictureBox2.Visible = true;

                //SET Start button and Difficulty disable
                button2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                label1.Visible = false;
            }

            else 
            {
                timer1.Stop();
                result = MessageBox.Show("Please Choose Difficulty"
                    , "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }



        //EXIT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        //Aliens
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            score.Text = Convert.ToString(Convert.ToInt32(score.Text) + 1); //SCORE+1 after Click Aliens
            resizes();

        }

       

    
        //SET TIME (Operation)
        private void timer1_Tick_1(object sender, EventArgs e)
        {
   
            if (second > 0) // then Countdown time
            {
                second--;
                time.Text = second.ToString();
            }

            else // Time Ran Out (second = 0;)
            {
                //GAME OVER
                label1.Text = "GAME OVER\nSCORE : " + score.Text; //Show current Score
                label1.Left = (this.Width - label1.Width) / 2;
                label1.Top = (this.Height - label1.Height) / 2;
                label1.Visible = true;

                timer1.Stop();
                pictureBox2.Visible = false; //Aliens disappear

                //RESET Difficulty
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                //Can choose new Difficulty
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                //Can Click RESTART
                button2.Enabled = true;

            }
        }



        private void score_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
