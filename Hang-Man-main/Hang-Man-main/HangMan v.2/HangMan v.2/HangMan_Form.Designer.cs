
namespace HangMan
{
    partial class HangMan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMan));
            this.statusDisplay = new System.Windows.Forms.PictureBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.newgameBox_yes = new System.Windows.Forms.RadioButton();
            this.newGamebox = new System.Windows.Forms.GroupBox();
            this.newGamePanel = new System.Windows.Forms.Panel();
            this.newgameBox_no = new System.Windows.Forms.RadioButton();
            this.prompt_box = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusDisplay)).BeginInit();
            this.newGamebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusDisplay
            // 
            this.statusDisplay.Location = new System.Drawing.Point(375, 71);
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.Size = new System.Drawing.Size(400, 300);
            this.statusDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusDisplay.TabIndex = 0;
            this.statusDisplay.TabStop = false;
            this.statusDisplay.Visible = false;
       
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(61, 71);
            this.userInput.MaxLength = 3;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(40, 23);
            this.userInput.TabIndex = 1;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.SystemColors.Control;
            this.check_btn.Location = new System.Drawing.Point(211, 71);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(101, 23);
            this.check_btn.TabIndex = 2;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // newgameBox_yes
            // 
            this.newgameBox_yes.AutoSize = true;
            this.newgameBox_yes.Location = new System.Drawing.Point(7, 22);
            this.newgameBox_yes.Name = "newgameBox_yes";
            this.newgameBox_yes.Size = new System.Drawing.Size(42, 19);
            this.newgameBox_yes.TabIndex = 5;
            this.newgameBox_yes.TabStop = true;
            this.newgameBox_yes.Text = "Yes";
            this.newgameBox_yes.UseVisualStyleBackColor = true;
            this.newgameBox_yes.CheckedChanged += new System.EventHandler(this.newgameBox_yes_CheckedChanged);
            // 
            // newGamebox
            // 
            this.newGamebox.Controls.Add(this.newGamePanel);
            this.newGamebox.Controls.Add(this.newgameBox_no);
            this.newGamebox.Controls.Add(this.newgameBox_yes);
            this.newGamebox.Location = new System.Drawing.Point(54, 293);
            this.newGamebox.Name = "newGamebox";
            this.newGamebox.Size = new System.Drawing.Size(258, 62);
            this.newGamebox.TabIndex = 6;
            this.newGamebox.TabStop = false;
            this.newGamebox.Text = "New Game?";
            this.newGamebox.Visible = false;
            // 
            // newGamePanel
            // 
            this.newGamePanel.Location = new System.Drawing.Point(-23, 80);
            this.newGamePanel.Name = "newGamePanel";
            this.newGamePanel.Size = new System.Drawing.Size(10, 39);
            this.newGamePanel.TabIndex = 7;
            // 
            // newgameBox_no
            // 
            this.newgameBox_no.AutoSize = true;
            this.newgameBox_no.Location = new System.Drawing.Point(139, 22);
            this.newgameBox_no.Name = "newgameBox_no";
            this.newgameBox_no.Size = new System.Drawing.Size(41, 19);
            this.newgameBox_no.TabIndex = 6;
            this.newgameBox_no.TabStop = true;
            this.newgameBox_no.Text = "No";
            this.newgameBox_no.UseVisualStyleBackColor = true;
            this.newgameBox_no.CheckedChanged += new System.EventHandler(this.newgameBox_no_CheckedChanged);
            // 
            // prompt_box
            // 
            this.prompt_box.AutoSize = true;
            this.prompt_box.Location = new System.Drawing.Point(101, 183);
            this.prompt_box.Name = "prompt_box";
            this.prompt_box.Size = new System.Drawing.Size(172, 15);
            this.prompt_box.TabIndex = 7;
            this.prompt_box.Text = "Guess a number between 1-100";
            this.prompt_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prompt_box);
            this.Controls.Add(this.newGamebox);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.statusDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangMan";
            this.Text = "Hang Man";
            this.Load += new System.EventHandler(this.HangMan_load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HangMan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.statusDisplay)).EndInit();
            this.newGamebox.ResumeLayout(false);
            this.newGamebox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox statusDisplay;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.RadioButton newgameBox_yes;
        private System.Windows.Forms.GroupBox newGamebox;
        private System.Windows.Forms.RadioButton newgameBox_no;
        private System.Windows.Forms.Panel newGamePanel;
        private System.Windows.Forms.Label prompt_box;
    }
}

