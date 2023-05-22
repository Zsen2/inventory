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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            cusGV = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)cusGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 100);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
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
            label2.Location = new Point(201, 27);
            label2.Name = "label2";
            label2.Size = new Size(369, 44);
            label2.TabIndex = 0;
            label2.Text = "Manage Customers";
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
            cusGV.TabIndex = 22;
            cusGV.CellClick += cusGV_CellContentClick;
            cusGV.CellContentClick += cusGV_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 604);
            panel3.Name = "panel3";
            panel3.Size = new Size(740, 10);
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
            homeButton.Click += homeButton_Click;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(201, 327);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 31);
            DelButton.TabIndex = 19;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(120, 327);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 31);
            editButton.TabIndex = 18;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(39, 327);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 31);
            addButton.TabIndex = 17;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cusNum
            // 
            cusNum.Location = new Point(60, 276);
            cusNum.Multiline = true;
            cusNum.Name = "cusNum";
            cusNum.PlaceholderText = "Phone Number";
            cusNum.Size = new Size(135, 30);
            cusNum.TabIndex = 16;
            // 
            // cusName
            // 
            cusName.Location = new Point(60, 240);
            cusName.Multiline = true;
            cusName.Name = "cusName";
            cusName.PlaceholderText = "Name";
            cusName.Size = new Size(135, 30);
            cusName.TabIndex = 14;
            // 
            // cusID
            // 
            cusID.Location = new Point(60, 204);
            cusID.Multiline = true;
            cusID.Name = "cusID";
            cusID.PlaceholderText = "ID";
            cusID.ReadOnly = true;
            cusID.Size = new Size(135, 30);
            cusID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(418, 136);
            label3.Name = "label3";
            label3.Size = new Size(203, 30);
            label3.TabIndex = 23;
            label3.Text = "CUSTOMERS LIST";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 614);
            Controls.Add(label3);
            Controls.Add(cusGV);
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
            Load += ManageCustomers_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cusGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private DataGridView cusGV;
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