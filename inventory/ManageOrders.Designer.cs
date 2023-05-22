namespace inventory
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            panel3 = new Panel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            cusID = new TextBox();
            orderDate = new DateTimePicker();
            label1 = new Label();
            comboBox2 = new ComboBox();
            dataGridView2 = new DataGridView();
            cusName = new TextBox();
            label4 = new Label();
            qtyTB = new TextBox();
            orderButton = new Button();
            Number = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            total = new Label();
            totalAm = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            exit = new Label();
            panel2 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 802);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 10);
            panel3.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(163, 128);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 25;
            label3.Text = "CUSTOMERS LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSlateBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(365, 244);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // cusID
            // 
            cusID.Location = new Point(83, 461);
            cusID.Multiline = true;
            cusID.Name = "cusID";
            cusID.PlaceholderText = "Customer ID";
            cusID.Size = new Size(135, 30);
            cusID.TabIndex = 28;
            // 
            // orderDate
            // 
            orderDate.Location = new Point(83, 564);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(210, 23);
            orderDate.TabIndex = 29;
            orderDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(128, 539);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 30;
            label1.Text = "Order Date";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(696, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 28);
            comboBox2.TabIndex = 32;
            comboBox2.Text = "Select Manufacturer";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.SelectionChangeCommitted += comboBox2_SelectionChangeCommitted;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.DarkSlateBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(449, 153);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(636, 244);
            dataGridView2.TabIndex = 31;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // cusName
            // 
            cusName.Location = new Point(83, 497);
            cusName.Multiline = true;
            cusName.Name = "cusName";
            cusName.PlaceholderText = "Customer Name";
            cusName.Size = new Size(135, 30);
            cusName.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(691, 431);
            label4.Name = "label4";
            label4.Size = new Size(92, 22);
            label4.TabIndex = 34;
            label4.Text = "Quantity";
            // 
            // qtyTB
            // 
            qtyTB.Location = new Point(674, 456);
            qtyTB.Multiline = true;
            qtyTB.Name = "qtyTB";
            qtyTB.Size = new Size(135, 30);
            qtyTB.TabIndex = 35;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(815, 456);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(107, 31);
            orderButton.TabIndex = 36;
            orderButton.Text = "Add to Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.DarkSlateBlue;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView3.Location = new Point(510, 497);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(544, 245);
            dataGridView3.TabIndex = 37;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Num";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Product";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "UPrice";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "TotalPrice";
            Column5.Name = "Column5";
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.Transparent;
            total.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            total.ForeColor = SystemColors.ControlLightLight;
            total.Location = new Point(677, 766);
            total.Name = "total";
            total.Size = new Size(138, 22);
            total.TabIndex = 38;
            total.Text = "TotalAmount: ";
            total.Click += total_Click;
            // 
            // totalAm
            // 
            totalAm.AutoSize = true;
            totalAm.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalAm.ForeColor = Color.Red;
            totalAm.Location = new Point(815, 766);
            totalAm.Name = "totalAm";
            totalAm.Size = new Size(0, 23);
            totalAm.TabIndex = 39;
            // 
            // button1
            // 
            button1.Location = new Point(83, 637);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 40;
            button1.Text = "Insert Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(211, 637);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 41;
            button2.Text = "View Orders";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(429, 28);
            label2.Name = "label2";
            label2.Size = new Size(301, 44);
            label2.TabIndex = 0;
            label2.Text = "Manage Orders";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.DarkRed;
            exit.Location = new Point(1106, -12);
            exit.Name = "exit";
            exit.Size = new Size(32, 39);
            exit.TabIndex = 1;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(exit);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 100);
            panel2.TabIndex = 23;
            // 
            // button3
            // 
            button3.Location = new Point(147, 691);
            button3.Name = "button3";
            button3.Size = new Size(107, 31);
            button3.TabIndex = 42;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1157, 812);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(totalAm);
            Controls.Add(total);
            Controls.Add(dataGridView3);
            Controls.Add(orderButton);
            Controls.Add(qtyTB);
            Controls.Add(label4);
            Controls.Add(cusName);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(orderDate);
            Controls.Add(cusID);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox cusID;
        private DateTimePicker orderDate;
        private Label label1;
        private ComboBox comboBox2;
        private DataGridView dataGridView2;
        private TextBox cusName;
        private Label label4;
        private TextBox qtyTB;
        private Button orderButton;
        private DataGridViewTextBoxColumn Number;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label total;
        private Label totalAm;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label exit;
        private Panel panel2;
        private Button button3;
    }
}