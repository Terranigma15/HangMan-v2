
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newgameBox_yes = new System.Windows.Forms.RadioButton();
            this.newGamebox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newgameBox_no = new System.Windows.Forms.RadioButton();
            this.prompt_box = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.newGamebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(61, 71);
            this.userInput.MaxLength = 3;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(40, 23);
            this.userInput.TabIndex = 1;
            this.userInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.check_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-186, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
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
            this.newgameBox_yes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // newGamebox
            // 
            this.newGamebox.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-23, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 39);
            this.panel1.TabIndex = 7;
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
            this.newgameBox_no.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangMan";
            this.Text = "Hang Man";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HangMan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.newGamebox.ResumeLayout(false);
            this.newGamebox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton newgameBox_yes;
        private System.Windows.Forms.GroupBox newGamebox;
        private System.Windows.Forms.RadioButton newgameBox_no;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label prompt_box;
    }
}

