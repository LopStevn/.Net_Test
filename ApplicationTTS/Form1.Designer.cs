namespace ApplicationTTS
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btn_Play = new Button();
            txt_word = new TextBox();
            label4 = new Label();
            txt_file1 = new TextBox();
            txt_file2 = new TextBox();
            txt_file3 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(126, 136);
            button1.Name = "button1";
            button1.Size = new Size(141, 35);
            button1.TabIndex = 0;
            button1.Text = "MP3 File 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(126, 256);
            button2.Name = "button2";
            button2.Size = new Size(141, 35);
            button2.TabIndex = 1;
            button2.Text = "MP3 File 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(126, 316);
            button3.Name = "button3";
            button3.Size = new Size(141, 35);
            button3.TabIndex = 2;
            button3.Text = "MP3 File 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_Play
            // 
            btn_Play.Location = new Point(253, 427);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(136, 35);
            btn_Play.TabIndex = 3;
            btn_Play.Text = "PLAY";
            btn_Play.UseVisualStyleBackColor = true;
            btn_Play.Click += btn_Play_Click;
            // 
            // txt_word
            // 
            txt_word.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_word.Location = new Point(301, 202);
            txt_word.Name = "txt_word";
            txt_word.Size = new Size(216, 25);
            txt_word.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(213, 21);
            label4.Name = "label4";
            label4.Size = new Size(236, 31);
            label4.TabIndex = 8;
            label4.Text = "TTS APPLICATION";
            // 
            // txt_file1
            // 
            txt_file1.BorderStyle = BorderStyle.FixedSingle;
            txt_file1.Enabled = false;
            txt_file1.ForeColor = Color.Black;
            txt_file1.Location = new Point(301, 143);
            txt_file1.Name = "txt_file1";
            txt_file1.Size = new Size(216, 25);
            txt_file1.TabIndex = 9;
            // 
            // txt_file2
            // 
            txt_file2.Enabled = false;
            txt_file2.Location = new Point(301, 262);
            txt_file2.Name = "txt_file2";
            txt_file2.Size = new Size(216, 25);
            txt_file2.TabIndex = 10;
            // 
            // txt_file3
            // 
            txt_file3.Enabled = false;
            txt_file3.Location = new Point(301, 322);
            txt_file3.Name = "txt_file3";
            txt_file3.Size = new Size(216, 25);
            txt_file3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 63);
            label1.Name = "label1";
            label1.Size = new Size(311, 23);
            label1.TabIndex = 12;
            label1.Text = "Combine text with other audio files!";
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(126, 196);
            button4.Name = "button4";
            button4.Size = new Size(141, 35);
            button4.TabIndex = 13;
            button4.Text = "Write your word";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(628, 474);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(txt_file3);
            Controls.Add(txt_file2);
            Controls.Add(txt_file1);
            Controls.Add(label4);
            Controls.Add(txt_word);
            Controls.Add(btn_Play);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "TTS Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_Play;
        private TextBox txt_word;
        private Label label4;
        private TextBox txt_file1;
        private TextBox txt_file2;
        private TextBox txt_file3;
        private Label label1;
        private Button button4;
    }
}
