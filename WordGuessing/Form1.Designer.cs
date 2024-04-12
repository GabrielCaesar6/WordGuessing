namespace WordGuessing
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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            DisplayWordlbl = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            GuessBtn = new Button();
            TypetxtBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(511, 44);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 16;
            label1.Text = "Wrong Guess Word";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSeaGreen;
            pictureBox2.Location = new Point(447, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(333, 62);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // DisplayWordlbl
            // 
            DisplayWordlbl.AutoSize = true;
            DisplayWordlbl.BackColor = Color.DarkSeaGreen;
            DisplayWordlbl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayWordlbl.ForeColor = Color.White;
            DisplayWordlbl.Location = new Point(205, 61);
            DisplayWordlbl.Name = "DisplayWordlbl";
            DisplayWordlbl.Size = new Size(33, 25);
            DisplayWordlbl.TabIndex = 14;
            DisplayWordlbl.Text = "...";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSeaGreen;
            pictureBox1.Location = new Point(20, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 101);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(447, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 324);
            listBox1.TabIndex = 12;
            // 
            // GuessBtn
            // 
            GuessBtn.BackColor = Color.DarkSeaGreen;
            GuessBtn.FlatStyle = FlatStyle.Flat;
            GuessBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GuessBtn.ForeColor = Color.White;
            GuessBtn.Location = new Point(151, 223);
            GuessBtn.Name = "GuessBtn";
            GuessBtn.Size = new Size(136, 44);
            GuessBtn.TabIndex = 11;
            GuessBtn.Text = "Guess";
            GuessBtn.UseVisualStyleBackColor = false;
            GuessBtn.Click += GuessBtn_Click;
            // 
            // TypetxtBox
            // 
            TypetxtBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TypetxtBox.Location = new Point(63, 153);
            TypetxtBox.Name = "TypetxtBox";
            TypetxtBox.Size = new Size(318, 38);
            TypetxtBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 466);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(DisplayWordlbl);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(GuessBtn);
            Controls.Add(TypetxtBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label DisplayWordlbl;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button GuessBtn;
        private TextBox TypetxtBox;
    }
}