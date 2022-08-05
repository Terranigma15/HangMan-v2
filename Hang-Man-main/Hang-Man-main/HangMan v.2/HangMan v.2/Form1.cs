using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangMan : Form
    {

        int fail_count = 0;

        String userinput;
        Image[] images = new Image[8];
        int answer;
        bool valid = true;
        Random random = new Random();
        bool lockEntr = false;
        public HangMan()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            images[0] = Properties.Resources.hangman01;
            images[1] = Properties.Resources.hangman02;
            images[2] = Properties.Resources.hangman03;
            images[3] = Properties.Resources.hangman04;
            images[4] = Properties.Resources.hangman05;
            images[5] = Properties.Resources.dead;
            images[6] = Properties.Resources.yay;


            random = new Random();
            answer = random.Next(1, 100);
            check_btn.Focus();
            KeyPreview = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userinput = userInput.Text;

        }



        private void button1_Click(object sender, EventArgs e)
        {

            valid = true;

            if (fail_count == 5)
            {
                check_btn.Enabled = false;

            }

            if (userinput != null || userinput != "")
            {
                int check;
                if ( (!int.TryParse(userinput, out check))  ||  ((check > 100 || check < 0))  )
                {
                    MessageBox.Show("Invalid Input");
                    resetGame();
                }

                if (valid == true)
                {
                    int userInt = int.Parse(userinput);
                    pictureBox1.Visible = true;
                   
                    if (userInt == answer)
                    {
                        prompt_box.Text = "Congrats you got the number";
                        pictureBox1.Image = images[6];
                        prepNewGame();
                     
                    }
                    else
                    {

                       // pictureBox1.Visible = true;

                        if (fail_count < 5)
                        {
                            pictureBox1.Image = images[fail_count];
                            guessCheck(userInt);
                            fail_count++;
                        }
                        else if (fail_count == 5)
                        {
                            prompt_box.Text = "You failed!";
                            pictureBox1.Image = images[fail_count];
                            prepNewGame();
                        }




                        /*switch (fail_count)
                        {
                            case 1:
                                pictureBox1.Image = images[0];
                                less_or_greater(userInt);
                                break;
                            case 2:
                                pictureBox1.Image = images[1];
                                less_or_greater(userInt);
                                break;
                            case 3:
                                pictureBox1.Image = images[2];
                                less_or_greater(userInt);
                                break;
                            case 4:
                                pictureBox1.Image = images[3];
                                less_or_greater(userInt);
                                break;
                            case 5:
                                pictureBox1.Image = images[4];
                                less_or_greater(userInt);
                                break;
                            case 6:
                              
                                pictureBox1.Image = images[7];
                                prompt_box.Text = "You failed!";
                                newGamebox.Visible = !newGamebox.Visible;
                                break;

                        }*/
                    }
                }





            }



        }

        /// <summary>
        ///  checks user input against randomly generated number and updates prompt label
        /// </summary>
        /// <param name="user"></param>
        void guessCheck(int userInpt)
        {

            if (userInpt > answer)
            {
                prompt_box.Text = "Should be lower than " + userInpt;
            }
            else
            {
                prompt_box.Text = "Should be higher than " + userInpt;
            }


        }

        void prepNewGame ()
        {
            
            newGamebox.Visible = !newGamebox.Visible;
            lockEntr = true;
        }
        void resetGame()
        {
            check_btn.Enabled = true;
            newgameBox_yes.Checked = false;
            valid = false;
            userInput.Text = "";
            pictureBox1.Visible = false;
            prompt_box.Text = "Guess a number between 0 - 100";
            fail_count = 0;
            newGamebox.Hide();
            lockEntr = false;
           
            answer = random.Next(1, 100);
        }





        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resetGame();
        
        }

        private void HangMan_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && lockEntr == false)
            {
                button1_Click(sender, e);

            }
        }
    }
}
