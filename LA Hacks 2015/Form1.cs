using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace LA_Hacks_2015
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Hide();
            InitializeComponent();
            this.Cursor = Cursors.Hand;

            using (var soundPlayer = new SoundPlayer(@"C:\Users\Ruthie\Documents\Spring 2015\LA HACKS\ironMaiden.mp3"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }


            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();


            Thread.Sleep(5000);

            t.Abort();
            this.Show();

        }



        public void SplashStart()
        {
            Application.Run(new SlashScreen());
        }

        private void Start_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void introButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t2");
            timer.Start();
            level_1_Button.Enabled = true;
            //level_1_Button.Enabled = true;
        }

        private void level_1_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t3");
            //level_2_Button.Enabled = true;
        }

        private void level_2_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t5");
            //level_2_Button.Enabled = true;
        }

        private void level_3_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t8");
            //level_2_Button.Enabled = true;
        }

        private void level_4_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t11");
            //level_2_Button.Enabled = true;
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backtoMM2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t1");
            timer.Stop();
        }

        private void Skip2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t3");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void level_2_Button_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gotot4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t4");
        }

        private void labelgohome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t1");
        }


        //---------------------------------------------------------------
        //START OF PICTURE BOX PROCEDURES
        private void sol3Test1_1_MouseDown(object sender, MouseEventArgs e)
        {
            sol3Test1_1.DoDragDrop(sol3Test1_1.Image, DragDropEffects.Copy);
        }

        private void blankTest1_3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void blankTest1_3_DragDrop(object sender, DragEventArgs e)
        {
            blankTest1_3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            sol1Test1_1.Hide();
        }
        //----------------------------------------------------------------
        //END OF PICTURE BOX PROCEDURES

        //---------------------------------------------------------------
        //START OF PICTURE BOX PROCEDURES
        private void sol4Test1_1_MouseDown(object sender, MouseEventArgs e)
        {
            sol4Test1_1.DoDragDrop(sol4Test1_1.Image, DragDropEffects.Copy);
        }

        private void blankTest1_4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void blankTest1_4_DragDrop(object sender, DragEventArgs e)
        {
            blankTest1_4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            sol2Test1_1.Hide();
        }
        //----------------------------------------------------------------
        //END OF PICTURE BOX PROCEDURES

        //---------------------------------------------------------------
        //START OF PICTURE BOX PROCEDURES
        private void sol1Test1_1_MouseDown(object sender, MouseEventArgs e)
        {
            sol1Test1_1.DoDragDrop(sol1Test1_1.Image, DragDropEffects.Copy);
        }

        private void blankTest1_1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void blankTest1_1_DragDrop(object sender, DragEventArgs e)
        {
            blankTest1_1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            sol3Test1_1.Hide();
        }
        //----------------------------------------------------------------
        //END OF PICTURE BOX PROCEDURES
        //RESET BUTTON

        //---------------------------------------------------------------
        //START OF PICTURE BOX PROCEDURES
        private void sol2Test1_1_MouseDown(object sender, MouseEventArgs e)
        {
            sol2Test1_1.DoDragDrop(sol2Test1_1.Image, DragDropEffects.Copy);
        }

        private void blankTest1_2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void blankTest1_2_DragDrop(object sender, DragEventArgs e)
        {
            blankTest1_2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            sol4Test1_1.Hide();
        }
        //----------------------------------------------------------------
        //END OF PICTURE BOX PROCEDURES

        private void Form1_Load(object sender, EventArgs e)
        {
            blankTest1_1.AllowDrop = true;
            blankTest1_2.AllowDrop = true;
            blankTest1_3.AllowDrop = true;
            blankTest1_4.AllowDrop = true;
        }

        private void resetTest1_1_Click(object sender, EventArgs e)
        {
            //REST BUTTON1
            sol3Test1_1.Location = new Point(604, 234); //set the answer back to it's original location
            sol3Test1_1.Visible = true;    //make the answer box visible again
            blankTest1_3.Image = null; //reset the picturebox to have no image

            //RESET BUTTON2
            sol4Test1_1.Location = new Point(604, 290); //set the answer back to it's original location
            sol4Test1_1.Visible = true;    //make the answer box visible again
            blankTest1_4.Image = null; //reset the picturebox to have no image

            //RESET BUTTON3
            sol1Test1_1.Location = new Point(604, 351); //set the answer back to it's original location
            sol1Test1_1.Visible = true;    //make the answer box visible again
            blankTest1_1.Image = null; //reset the picturebox to have no image

            //RESET BUTTON4
            sol2Test1_1.Location = new Point(604, 415); //set the answer back to it's original location
            sol2Test1_1.Visible = true;    //make the answer box visible again
            blankTest1_2.Image = null; //reset the picturebox to have no image

            //RESET THE TEXT
            test1Text.Text = "Great Job! Now let's see what you've got, Kid!"
            + " Now it's time to put your newfound knowledge to the test!\n\n"
            + "I want you to match the boxes to the right. For example, if"
            + " you see a word that can be used as a string then I want you"
            + " to drag it in the string box. Or if you see a number, drag it in the int box. Good luck!";
        }

        private void submitTest1_1_Click(object sender, EventArgs e)
        {
            bool test = true;

            //check to see if the icons are in the correct location
            if (sol3Test1_1.Width > 890 || sol3Test1_1.Width < 1046 && sol3Test1_1.Height >= 357 || sol3Test1_1.Height <= 377 && test)
            {
                test = true;
            }
            else
                test = false;

            if (sol4Test1_1.Width > 890 || sol4Test1_1.Width < 1046 && sol4Test1_1.Height >= 421 || sol4Test1_1.Height < 441 && test)
            {
                test = true;

            }
            else
                test = false;

            if (sol1Test1_1.Width > 890 || sol1Test1_1.Width < 1046 && sol1Test1_1.Height >= 240 || sol1Test1_1.Height <= 261 && test)
            {
                test = true;
            }
            else
                test = false;

            if (sol2Test1_1.Width > 890 || sol2Test1_1.Width < 1046 && sol2Test1_1.Height >= 276 || sol2Test1_1.Height <= 296 && test)
            {
                test = true;
            }
            else
                test = false;

            //if any of them were false then the user failed
            if (!test)
            {
                test1Text.Font.SizeInPoints.Equals(60.0);
                test1Text.Text = "You've got this, please review the material again!";
                return;
            }

            thumbsUp.Visible = true;
            test1Text.Font.SizeInPoints.Equals(60.0);
            test1Text.Text = "Congratulations, I knew you could do it!";
        }

        // If user pushes next during intro
        private void nextButton2_Click(object sender, EventArgs e)
        {
            if (duration < 4)
            {
                duration = 4;
            }
            else if (duration >= 4 && duration < 9)
            {
                duration = 9;
            }
            else if (duration >= 9 && duration < 14)
            {
                duration = 14;
            }
            else if (duration >= 14 && duration < 19)
            {
                duration = 19;
            }
            else if (duration >= 19 && duration < 24)
            {
                duration = 24;
            }
            else if (duration >= 24 && duration < 29)
            {
                duration = 29;
            }
            else if (duration >= 29 && duration < 34)
            {
                duration = 34;
            }
            else if (duration >= 34 && duration < 39)
            {
                duration = 39;
            }
            else if (duration >= 39)
            {
                tabControl1.SelectTab("t3");
                timer.Stop();
            }
        }

        // Plays for duration of intro
        int duration = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration++;
            if (duration >= 4 && duration < 9) // Slide 2
            {
                t2.BackgroundImage = Properties.Resources.Panel2;
                introSpeechPanel.Location = new Point(864, 43);
                introSpeechPanel.BackgroundImage = Properties.Resources.speakingBubble;
                bubbleTextIntro.Text = "Especially with a\n bomb attached\n to your chest";
                introSpeechPanel.Size = new Size(250, 233);
            }
            else if (duration >= 9 && duration < 14) // Slide 3
            {
                t2.BackgroundImage = Properties.Resources.Panel3;
                introSpeechPanel.Location = new Point(298, 38);
                introSpeechPanel.Size = new Size(305, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                bubbleTextIntro.Text = "Your mad Dr. Virus!\n When I get out this I'm\n coming for you!";
                bubbleTextIntro.Size = new Size(61, 69);
                
            }
            else if (duration >= 14 && duration < 19) // slide 4
            {
                t2.BackgroundImage = Properties.Resources.Panel4;
                introSpeechPanel.Location = new Point(488, 64);
                introSpeechPanel.Size = new Size(245, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speakingBubble;
                bubbleTextIntro.Text = "Sure you will,\n Lets see you hack\n your way out of \n this one!";
                bubbleTextIntro.Size = new Size(55, 62);
            }
            else if (duration >= 19 && duration < 24) // slide 5
            {
                t2.BackgroundImage = Properties.Resources.Panel5;
                introSpeechPanel.Location = new Point(50,90);
                introSpeechPanel.Size = new Size(291, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                bubbleTextIntro.Text = "Must ...\n Break ...\n Out of here!!";
                bubbleTextIntro.Size = new Size(95, 68);

                if (duration >= 21 && duration < 24)
                {
                    introSpeechPanel.Location = new Point(644, 122);
                    introSpeechPanel.Size = new Size(291, 233);
                    introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                    bubbleTextIntro.Text = "Ugh... It's\n useless, time for\n plan B...";
                    bubbleTextIntro.Size = new Size(139, 54);
                    bubbleTextIntro.Location = new Point(73, 66);
                }
            }
            else if (duration >= 24 && duration < 29) // slide 6
            {
                t2.BackgroundImage = Properties.Resources.Panel6;
                introSpeechPanel.Location = new Point(300, 64);
                introSpeechPanel.Size = new Size(291, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                bubbleTextIntro.Text = "HHEEELLLLPPPP!!!";
                bubbleTextIntro.Size = new Size(157, 18);
                bubbleTextIntro.Location = new Point(44, 86);
            }
            else if (duration >= 29 && duration < 34) // slide 7
            {
                t2.BackgroundImage = Properties.Resources.Panel7;
                introSpeechPanel.Location = new Point(161, 171);
                introSpeechPanel.Size = new Size(252, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speakingBubble;
                bubbleTextIntro.Text = "Sounds like\n someone needs\n help in that old \n factory";
                bubbleTextIntro.Size = new Size(128, 72);
                bubbleTextIntro.Location = new Point(65, 60);

                if (duration >= 31 && duration < 34)
                {
                    Skip2.Location = new Point(622, 64);
                    introSpeechPanel.Location = new Point(632, 543);
                    introSpeechPanel.Size = new Size(289, 233);
                    introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                    bubbleTextIntro.Text = "Sounds like\n someone needs\n help in that old \n factory";
                    bubbleTextIntro.Size = new Size(141, 54);
                    bubbleTextIntro.Location = new Point(67, 75);
                }

            }
            else if (duration >= 34 && duration < 39)  // slide 8
            {
                t2.BackgroundImage = Properties.Resources.Panel8;
                introSpeechPanel.Location = new Point(298, 64);
                introSpeechPanel.Size = new Size(246, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speakingBubble;
                bubbleTextIntro.Text = "Hackman!!\n What are you\n doing here?\n Are you okay?";
                bubbleTextIntro.Size = new Size(439, 18);
                bubbleTextIntro.Location = new Point(68, 60);

                if (duration >= 36 && duration < 39)
                {
                    introSpeechPanel.Location = new Point(707, 52);
                    introSpeechPanel.Size = new Size(305, 233);
                    introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                    bubbleTextIntro.Text = "Hey kid, there's a\n bomb strapped to\n my chest. You have\n disable the bomb.\n You know how to code?";
                    bubbleTextIntro.Size = new Size(808, 18);
                    bubbleTextIntro.Location = new Point(51, 52);
                }
            }
            else if (duration >= 39 && duration < 44) // slide 9
            {
                t2.BackgroundImage = Properties.Resources.Panel9;
                introSpeechPanel.Location = new Point(383, 41);
                introSpeechPanel.Size = new Size(239, 233);
                introSpeechPanel.BackgroundImage = Properties.Resources.speakingBubble;
                bubbleTextIntro.Text = "Well, sorta,\n kinda, not\n really...No";
                bubbleTextIntro.Size = new Size(439, 18);
                bubbleTextIntro.Location = new Point(80, 65);

                if (duration >= 41 && duration < 44)
                {
                    introSpeechPanel.Location = new Point(764, 40);
                    introSpeechPanel.Size = new Size(307, 233);
                    introSpeechPanel.BackgroundImage = Properties.Resources.speechBub;
                    bubbleTextIntro.Text = "Then I'm going\n to teach you!";
                    bubbleTextIntro.Location = new Point(89, 70);
                }
            }
            else if (duration >= 44)
            {
                tabControl1.SelectTab("t3");
                timer.Stop();
            }
        }

        /*
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\Ruthie\Documents\Spring 2015\LA HACKS\ironMaiden.mp3"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        */
     
    }
}


        
        //----------------------------------------------------------------
        //END OF PICTURE BOX PROCEDURES
    

