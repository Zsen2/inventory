namespace inventory
{
    partial class ManageUsers
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
            panel1 = new Panel();
            panel2 = new Panel();
            exit = new Label();
            label2 = new Label();
            label1 = new Label();
            userTB = new TextBox();
            passTB = new TextBox();
            fullNameTB = new TextBox();
            numTB = new TextBox();
            addButton = new Button();
            editButton = new Button();
            DelButton = new Button();
            homeButton = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 167);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(exit);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 167);
            panel2.TabIndex = 1;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.DarkRed;
            exit.Location = new Point(1141, -15);
            exit.Margin = new Padding(4, 0, 4, 0);
            exit.Name = "exit";
            exit.Size = new Size(48, 58);
            exit.TabIndex = 1;
            exit.Text = "x";
            exit.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(396, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(415, 69);
            label2.TabIndex = 0;
            label2.Text = "Manage Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(383, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(415, 69);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // userTB
            // 
            userTB.Location = new Point(61, 333);
            userTB.Margin = new Padding(4, 5, 4, 5);
            userTB.Multiline = true;
            userTB.Name = "userTB";
            userTB.Size = new Size(191, 47);
            userTB.TabIndex = 1;
            userTB.Text = "Username";
            // 
            // passTB
            // 
            passTB.Location = new Point(61, 393);
            passTB.Margin = new Padding(4, 5, 4, 5);
            passTB.Multiline = true;
            passTB.Name = "passTB";
            passTB.Size = new Size(191, 47);
            passTB.TabIndex = 2;
            passTB.Text = "Password";
            // 
            // fullNameTB
            // 
            fullNameTB.Location = new Point(61, 453);
            fullNameTB.Margin = new Padding(4, 5, 4, 5);
            fullNameTB.Multiline = true;
            fullNameTB.Name = "fullNameTB";
            fullNameTB.Size = new Size(191, 47);
            fullNameTB.TabIndex = 3;
            fullNameTB.Text = "FullName";
            // 
            // numTB
            // 
            numTB.Location = new Point(61, 513);
            numTB.Margin = new Padding(4, 5, 4, 5);
            numTB.Multiline = true;
            numTB.Name = "numTB";
            numTB.Size = new Size(191, 47);
            numTB.TabIndex = 4;
            numTB.Text = "Phone Number";
            // 
            // addButton
            // 
            addButton.Location = new Point(56, 595);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 52);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(171, 595);
            editButton.Margin = new Padding(4, 5, 4, 5);
            editButton.Name = "editButton";
            editButton.Size = new Size(107, 52);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(287, 595);
            DelButton.Margin = new Padding(4, 5, 4, 5);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(107, 52);
            DelButton.TabIndex = 7;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(171, 677);
            homeButton.Margin = new Padding(4, 5, 4, 5);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(107, 52);
            homeButton.TabIndex = 8;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 938);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1187, 17);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 240);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(634, 610);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 955);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(homeButton);
            Controls.Add(DelButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(numTB);
            Controls.Add(fullNameTB);
            Controls.Add(passTB);
            Controls.Add(userTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox userTB;
        private TextBox passTB;
        private TextBox fullNameTB;
        private TextBox numTB;
        private Button addButton;
        private Button editButton;
        private Button DelButton;
        private Panel panel2;
        private Label exit;
        private Label label2;
        private Button homeButton;
        private Panel panel3;
        private DataGridView dataGridView1;
    }
}