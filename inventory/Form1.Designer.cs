namespace inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            showPass = new CheckBox();
            passTB = new TextBox();
            userTB = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.BackColor = Color.CornflowerBlue;
            showPass.FlatStyle = FlatStyle.Flat;
            showPass.Location = new Point(116, 258);
            showPass.Name = "showPass";
            showPass.Size = new Size(105, 19);
            showPass.TabIndex = 9;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = false;
            showPass.CheckedChanged += showPass_CheckedChanged_1;
            // 
            // passTB
            // 
            passTB.BackColor = Color.LightGray;
            passTB.BorderStyle = BorderStyle.None;
            passTB.Location = new Point(83, 171);
            passTB.Name = "passTB";
            passTB.PlaceholderText = "Password";
            passTB.Size = new Size(141, 16);
            passTB.TabIndex = 7;
            passTB.UseSystemPasswordChar = true;
            // 
            // userTB
            // 
            userTB.BackColor = Color.LightGray;
            userTB.BorderStyle = BorderStyle.None;
            userTB.Location = new Point(83, 137);
            userTB.Name = "userTB";
            userTB.PlaceholderText = "Username";
            userTB.Size = new Size(143, 16);
            userTB.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(54, 207);
            button1.Name = "button1";
            button1.Size = new Size(170, 23);
            button1.TabIndex = 13;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(244, -9);
            label1.Name = "label1";
            label1.Size = new Size(32, 39);
            label1.TabIndex = 14;
            label1.Text = "x";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 363);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(showPass);
            Controls.Add(passTB);
            Controls.Add(userTB);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox showPass;
        private Button logButton;
        private TextBox passTB;
        private TextBox userTB;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
    }
}