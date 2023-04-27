namespace inventory
{
    partial class ManageCustomers
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
            panel2 = new Panel();
            label1 = new Label();
            exit = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            homeButton = new Button();
            DelButton = new Button();
            editButton = new Button();
            addButton = new Button();
            cusNum = new TextBox();
            cusName = new TextBox();
            cusID = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(exit);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(768, -9);
            label1.Name = "label1";
            label1.Size = new Size(32, 39);
            label1.TabIndex = 2;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.DarkRed;
            exit.Location = new Point(799, -9);
            exit.Name = "exit";
            exit.Size = new Size(32, 39);
            exit.TabIndex = 1;
            exit.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(201, 27);
            label2.Name = "label2";
            label2.Size = new Size(369, 44);
            label2.TabIndex = 0;
            label2.Text = "Manage Customers";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 366);
            dataGridView1.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 604);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 10);
            panel3.TabIndex = 21;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(120, 376);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 31);
            homeButton.TabIndex = 20;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(201, 327);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 31);
            DelButton.TabIndex = 19;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(120, 327);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 31);
            editButton.TabIndex = 18;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(39, 327);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 31);
            addButton.TabIndex = 17;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // cusNum
            // 
            cusNum.Location = new Point(43, 242);
            cusNum.Multiline = true;
            cusNum.Name = "cusNum";
            cusNum.Size = new Size(135, 30);
            cusNum.TabIndex = 16;
            cusNum.Text = "Phone Number";
            // 
            // cusName
            // 
            cusName.Location = new Point(43, 206);
            cusName.Multiline = true;
            cusName.Name = "cusName";
            cusName.Size = new Size(135, 30);
            cusName.TabIndex = 14;
            cusName.Text = "Name";
            // 
            // cusID
            // 
            cusID.Location = new Point(43, 170);
            cusID.Multiline = true;
            cusID.Name = "cusID";
            cusID.Size = new Size(135, 30);
            cusID.TabIndex = 13;
            cusID.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(454, 137);
            label3.Name = "label3";
            label3.Size = new Size(203, 30);
            label3.TabIndex = 23;
            label3.Text = "CUSTOMERS LIST";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(homeButton);
            Controls.Add(DelButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(cusNum);
            Controls.Add(cusName);
            Controls.Add(cusID);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label exit;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button homeButton;
        private Button DelButton;
        private Button editButton;
        private Button addButton;
        private TextBox cusNum;
        private TextBox cusName;
        private TextBox cusID;
        private Label label1;
        private Label label3;
    }
}