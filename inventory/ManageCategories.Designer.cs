namespace inventory
{
    partial class ManageCategories
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
            label2 = new Label();
            label3 = new Label();
            cusGV = new DataGridView();
            panel3 = new Panel();
            homeButton = new Button();
            DelButton = new Button();
            editButton = new Button();
            addButton = new Button();
            catName = new TextBox();
            catID = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cusGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 100);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(708, -12);
            label1.Name = "label1";
            label1.Size = new Size(32, 39);
            label1.TabIndex = 2;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(190, 27);
            label2.Name = "label2";
            label2.Size = new Size(429, 44);
            label2.TabIndex = 0;
            label2.Text = "Manage Manufacturer";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(409, 136);
            label3.Name = "label3";
            label3.Size = new Size(222, 30);
            label3.TabIndex = 34;
            label3.Text = "Manufacturer LIST";
            // 
            // cusGV
            // 
            cusGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cusGV.Location = new Point(337, 169);
            cusGV.Name = "cusGV";
            cusGV.ReadOnly = true;
            cusGV.RowHeadersWidth = 62;
            cusGV.RowTemplate.Height = 25;
            cusGV.Size = new Size(364, 366);
            cusGV.TabIndex = 33;
            cusGV.CellContentClick += cusGV_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 604);
            panel3.Name = "panel3";
            panel3.Size = new Size(740, 10);
            panel3.TabIndex = 32;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(121, 345);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 31);
            homeButton.TabIndex = 31;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(202, 296);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 31);
            DelButton.TabIndex = 30;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(121, 296);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 31);
            editButton.TabIndex = 29;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(40, 296);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 31);
            addButton.TabIndex = 28;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // catName
            // 
            catName.Location = new Point(61, 244);
            catName.Multiline = true;
            catName.Name = "catName";
            catName.Size = new Size(135, 30);
            catName.TabIndex = 26;
            catName.Text = "Name";
            // 
            // catID
            // 
            catID.Location = new Point(61, 208);
            catID.Multiline = true;
            catID.Name = "catID";
            catID.Size = new Size(135, 30);
            catID.TabIndex = 25;
            catID.Text = "ID";
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 614);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(cusGV);
            Controls.Add(panel3);
            Controls.Add(homeButton);
            Controls.Add(DelButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(catName);
            Controls.Add(catID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cusGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView cusGV;
        private Panel panel3;
        private Button homeButton;
        private Button DelButton;
        private Button editButton;
        private Button addButton;
        private TextBox catName;
        private TextBox catID;
    }
}