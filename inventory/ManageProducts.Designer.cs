namespace inventory
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            label3 = new Label();
            dataGridView1 = new DataGridView();
            homeButton = new Button();
            DelButton = new Button();
            editButton = new Button();
            addButton = new Button();
            prodPrice = new TextBox();
            prodQT = new TextBox();
            prodName = new TextBox();
            prodID = new TextBox();
            desc = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            exit = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(568, 125);
            label3.Name = "label3";
            label3.Size = new Size(187, 30);
            label3.TabIndex = 14;
            label3.Text = "PRODUCTS LIST";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSlateBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(332, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 366);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(120, 440);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 31);
            homeButton.TabIndex = 21;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(201, 391);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 31);
            DelButton.TabIndex = 20;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(120, 391);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 31);
            editButton.TabIndex = 19;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(39, 391);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 31);
            addButton.TabIndex = 18;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // prodPrice
            // 
            prodPrice.Location = new Point(60, 266);
            prodPrice.Multiline = true;
            prodPrice.Name = "prodPrice";
            prodPrice.PlaceholderText = "Price";
            prodPrice.Size = new Size(135, 30);
            prodPrice.TabIndex = 17;
            // 
            // prodQT
            // 
            prodQT.Location = new Point(60, 230);
            prodQT.Multiline = true;
            prodQT.Name = "prodQT";
            prodQT.PlaceholderText = "Quantity";
            prodQT.Size = new Size(135, 30);
            prodQT.TabIndex = 16;
            // 
            // prodName
            // 
            prodName.Location = new Point(60, 194);
            prodName.Multiline = true;
            prodName.Name = "prodName";
            prodName.PlaceholderText = "Product Name";
            prodName.Size = new Size(135, 30);
            prodName.TabIndex = 15;
            // 
            // prodID
            // 
            prodID.Location = new Point(60, 158);
            prodID.Multiline = true;
            prodID.Name = "prodID";
            prodID.PlaceholderText = "Product ID";
            prodID.ReadOnly = true;
            prodID.Size = new Size(135, 30);
            prodID.TabIndex = 13;
            // 
            // desc
            // 
            desc.Location = new Point(60, 302);
            desc.Multiline = true;
            desc.Name = "desc";
            desc.PlaceholderText = "Description";
            desc.Size = new Size(135, 30);
            desc.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 348);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "Product Manufacturer";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(524, 533);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 28);
            comboBox2.TabIndex = 26;
            comboBox2.Text = "Select Manufacturer";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(697, 530);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 27;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(778, 530);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 28;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.DarkRed;
            exit.Location = new Point(1012, -12);
            exit.Name = "exit";
            exit.Size = new Size(32, 39);
            exit.TabIndex = 1;
            exit.Text = "x";
            exit.Click += exit_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 601);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 10);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(exit);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 110);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(363, 40);
            label1.Name = "label1";
            label1.Size = new Size(338, 44);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 611);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(desc);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(homeButton);
            Controls.Add(DelButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(prodPrice);
            Controls.Add(prodQT);
            Controls.Add(prodName);
            Controls.Add(prodID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private DataGridView dataGridView1;
        private Button homeButton;
        private Button DelButton;
        private Button editButton;
        private Button addButton;
        private TextBox prodPrice;
        private TextBox prodQT;
        private TextBox prodName;
        private TextBox prodID;
        private TextBox desc;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Label exit;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
    }
}