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
            panel1 = new Panel();
            showPass = new CheckBox();
            logButton = new Button();
            passTB = new TextBox();
            userTB = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(showPass);
            panel1.Controls.Add(logButton);
            panel1.Controls.Add(passTB);
            panel1.Controls.Add(userTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(43, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 287);
            panel1.TabIndex = 0;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(98, 223);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 19);
            showPass.TabIndex = 4;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // logButton
            // 
            logButton.Location = new Point(28, 179);
            logButton.Name = "logButton";
            logButton.Size = new Size(178, 38);
            logButton.TabIndex = 3;
            logButton.Text = "Login";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += button1_Click;
            // 
            // passTB
            // 
            passTB.Location = new Point(28, 141);
            passTB.Name = "passTB";
            passTB.Size = new Size(178, 23);
            passTB.TabIndex = 2;
            passTB.Text = "Password";
            passTB.UseSystemPasswordChar = true;
            // 
            // userTB
            // 
            userTB.Location = new Point(28, 112);
            userTB.Name = "userTB";
            userTB.Size = new Size(178, 23);
            userTB.TabIndex = 1;
            userTB.Text = "Username";
            userTB.TextChanged += userTB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 388);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CheckBox showPass;
        private Button logButton;
        private TextBox passTB;
        private TextBox userTB;
    }
}