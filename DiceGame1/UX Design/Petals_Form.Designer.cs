namespace ay0900356_PictureBox_Dice
{
    partial class Petals_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Petals_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.roll_button = new System.Windows.Forms.Button();
            this.check_buton = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.guess_updown = new System.Windows.Forms.NumericUpDown();
            this.guess_label = new System.Windows.Forms.Label();
            this.feedback_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.correct_label = new System.Windows.Forms.Label();
            this.run_label = new System.Windows.Forms.Label();
            this.total_textbox = new System.Windows.Forms.TextBox();
            this.correct_textbox = new System.Windows.Forms.TextBox();
            this.run_textbox = new System.Windows.Forms.TextBox();
            this.streak_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guess_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // roll_button
            // 
            this.roll_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roll_button.Location = new System.Drawing.Point(360, 574);
            this.roll_button.Name = "roll_button";
            this.roll_button.Size = new System.Drawing.Size(251, 72);
            this.roll_button.TabIndex = 2;
            this.roll_button.Text = "Roll Dice";
            this.roll_button.UseVisualStyleBackColor = true;
            this.roll_button.Click += new System.EventHandler(this.roll_button_Click);
            // 
            // check_buton
            // 
            this.check_buton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_buton.Location = new System.Drawing.Point(641, 574);
            this.check_buton.Name = "check_buton";
            this.check_buton.Size = new System.Drawing.Size(251, 72);
            this.check_buton.TabIndex = 3;
            this.check_buton.Text = "Check Answer";
            this.check_buton.UseVisualStyleBackColor = true;
            this.check_buton.Click += new System.EventHandler(this.check_buton_Click);
            // 
            // Rules
            // 
            this.Rules.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rules.Location = new System.Drawing.Point(76, 574);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(251, 72);
            this.Rules.TabIndex = 4;
            this.Rules.Text = "Rules";
            this.Rules.UseVisualStyleBackColor = true;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // guess_updown
            // 
            this.guess_updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_updown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.guess_updown.Location = new System.Drawing.Point(379, 350);
            this.guess_updown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.guess_updown.Name = "guess_updown";
            this.guess_updown.Size = new System.Drawing.Size(89, 44);
            this.guess_updown.TabIndex = 5;
            // 
            // guess_label
            // 
            this.guess_label.AutoSize = true;
            this.guess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_label.Location = new System.Drawing.Point(90, 352);
            this.guess_label.Name = "guess_label";
            this.guess_label.Size = new System.Drawing.Size(267, 37);
            this.guess_label.TabIndex = 6;
            this.guess_label.Text = "Enter your guess:";
            // 
            // feedback_label
            // 
            this.feedback_label.AutoSize = true;
            this.feedback_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_label.Location = new System.Drawing.Point(90, 420);
            this.feedback_label.Name = "feedback_label";
            this.feedback_label.Size = new System.Drawing.Size(93, 33);
            this.feedback_label.TabIndex = 7;
            this.feedback_label.Text = "label2";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(199, 18);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(587, 76);
            this.title_label.TabIndex = 8;
            this.title_label.Text = "Petals Around the Rose";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(637, 361);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(135, 29);
            this.total_label.TabIndex = 9;
            this.total_label.Text = "Total Rolls:";
            // 
            // correct_label
            // 
            this.correct_label.AutoSize = true;
            this.correct_label.Location = new System.Drawing.Point(637, 409);
            this.correct_label.Name = "correct_label";
            this.correct_label.Size = new System.Drawing.Size(117, 29);
            this.correct_label.TabIndex = 10;
            this.correct_label.Text = "# Correct:";
            // 
            // run_label
            // 
            this.run_label.AutoSize = true;
            this.run_label.Location = new System.Drawing.Point(637, 504);
            this.run_label.Name = "run_label";
            this.run_label.Size = new System.Drawing.Size(142, 29);
            this.run_label.TabIndex = 11;
            this.run_label.Text = "Best Streak:";
            // 
            // total_textbox
            // 
            this.total_textbox.Enabled = false;
            this.total_textbox.Location = new System.Drawing.Point(777, 358);
            this.total_textbox.Name = "total_textbox";
            this.total_textbox.Size = new System.Drawing.Size(101, 35);
            this.total_textbox.TabIndex = 12;
            // 
            // correct_textbox
            // 
            this.correct_textbox.Enabled = false;
            this.correct_textbox.Location = new System.Drawing.Point(777, 406);
            this.correct_textbox.Name = "correct_textbox";
            this.correct_textbox.Size = new System.Drawing.Size(101, 35);
            this.correct_textbox.TabIndex = 13;
            // 
            // run_textbox
            // 
            this.run_textbox.Enabled = false;
            this.run_textbox.Location = new System.Drawing.Point(777, 501);
            this.run_textbox.Name = "run_textbox";
            this.run_textbox.Size = new System.Drawing.Size(101, 35);
            this.run_textbox.TabIndex = 14;
            // 
            // streak_textbox
            // 
            this.streak_textbox.Enabled = false;
            this.streak_textbox.Location = new System.Drawing.Point(777, 453);
            this.streak_textbox.Name = "streak_textbox";
            this.streak_textbox.Size = new System.Drawing.Size(101, 35);
            this.streak_textbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Streak:";
            // 
            // Petals_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(965, 691);
            this.Controls.Add(this.streak_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.run_textbox);
            this.Controls.Add(this.correct_textbox);
            this.Controls.Add(this.total_textbox);
            this.Controls.Add(this.run_label);
            this.Controls.Add(this.correct_label);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.feedback_label);
            this.Controls.Add(this.guess_label);
            this.Controls.Add(this.guess_updown);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.check_buton);
            this.Controls.Add(this.roll_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Petals_Form";
            this.Text = "Petals Around the Rose";
            this.Load += new System.EventHandler(this.Petals_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guess_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roll_button;
        private System.Windows.Forms.Button check_buton;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.NumericUpDown guess_updown;
        private System.Windows.Forms.Label guess_label;
        private System.Windows.Forms.Label feedback_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label correct_label;
        private System.Windows.Forms.Label run_label;
        private System.Windows.Forms.TextBox total_textbox;
        private System.Windows.Forms.TextBox correct_textbox;
        private System.Windows.Forms.TextBox run_textbox;
        private System.Windows.Forms.TextBox streak_textbox;
        private System.Windows.Forms.Label label2;
    }
}

