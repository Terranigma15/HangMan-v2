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

        int fail_count = 0,answer,check;
        
        bool lockEntr = false;
        
        Random random = new Random();
        
        String userinput;
       
        List<Object> resources = new List<Object>();



        public HangMan()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        /// <summary>
        /// fills resource list with game images.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HangMan_load(object sender, EventArgs e)
        {
            
            var resourcesToLoad = new List<String> { "hangman01","hangman02", "hangman03", "hangman04", "hangman05","dead","yay"};

            for (var i = 0; i < resourcesToLoad.Count; i++)
            {
                var resourceName = resourcesToLoad[i];
             
               
               resources.Add(Properties.Resources.ResourceManager.GetObject(resourceName));
              
               
            }
           
         
            random = new Random();
            answer = random.Next(1, 100);
            check_btn.Focus();

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            userinput = userInput.Text;

        }



        private void check_btn_Click(object sender, EventArgs e)
        {

            if (userinput != null || userinput != "")
            {
                
                
                if ( (!int.TryParse(userinput, out check))  ||  ((check > 100 || check < 0))  )
                {
                    MessageBox.Show("Invalid Input");
                    userInput.Text = " ";
                    
                }
                else 
                {
                   int userInt = int.Parse(userinput);
                    
                    statusDisplay.Visible = true;
                   
                    if (userInt == answer)
                    {
                        prompt_box.Text = "Congrats you got the number";

                        statusDisplay.Image = resources.ElementAt(6) as Image;

                    }
                    else
                    {

                        if (fail_count < 5)
                        {  
                            guessCheck(userInt);
                            
                            statusDisplay.Image = resources.ElementAt(fail_count) as Image;

                            fail_count++;
                        }
                        else if (fail_count == 5)
                        {
                            prompt_box.Text = "You failed!";
                           
                            statusDisplay.Image = resources.ElementAt(5) as Image;

                            check_btn.Enabled = false;

                            newGamebox.Visible = !newGamebox.Visible;
                        }


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
               
                prompt_box.Text = ($"Should be lower than {userInpt}");
            }
            else
            {
                prompt_box.Text = ($"Should be higher than {userInpt}");
            
            }


        }

       
        void resetGame()
        {
            check_btn.Enabled = true;
            newgameBox_yes.Checked = false;
            userInput.Text = "";
            statusDisplay.Visible = false;
            prompt_box.Text = "Guess a number between 1 - 100";
            fail_count = 0;
            lockEntr = false;
            answer = random.Next(1, 100);
        }





        private void newgameBox_no_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            
        }

       

        private void newgameBox_yes_CheckedChanged(object sender, EventArgs e)
        {
            resetGame();
        
        }

        private void HangMan_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && lockEntr == false)
            {
                check_btn_Click(sender, e);

            }
        }

     
    }
}
