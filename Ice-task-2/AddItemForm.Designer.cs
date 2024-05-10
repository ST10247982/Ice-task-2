namespace Ice_task_2
{
    partial class AddItemForm
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
            lblCategory = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblItemName = new Label();
            label5 = new Label();
            UDQuantity = new NumericUpDown();
            UDPrice = new NumericUpDown();
            listBox1 = new ListBox();
            txtbxName = new TextBox();
            btnAdd = new Button();
            btnMainPage = new Button();
            lblQuantityWarning = new Label();
            lblPriceWarning = new Label();
            lblItemNameWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)UDQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UDPrice).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(154, 79);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(158, 211);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(158, 285);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity:";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(158, 141);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(86, 20);
            lblItemName.TabIndex = 3;
            lblItemName.Text = "Item Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 211);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // UDQuantity
            // 
            UDQuantity.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UDQuantity.Location = new Point(403, 278);
            UDQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            UDQuantity.Name = "UDQuantity";
            UDQuantity.Size = new Size(150, 27);
            UDQuantity.TabIndex = 6;
            // 
            // UDPrice
            // 
            UDPrice.DecimalPlaces = 2;
            UDPrice.Location = new Point(403, 209);
            UDPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            UDPrice.Name = "UDPrice";
            UDPrice.Size = new Size(150, 27);
            UDPrice.TabIndex = 7;
            // 
            // listBox1
            // 
         
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { Category.fruits, Category.vegetables, Category.dairy, Category.meat, Category.bakery });
            listBox1.Location = new Point(403, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 24);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtbxName
            // 
            txtbxName.Location = new Point(403, 134);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(237, 27);
            txtbxName.TabIndex = 9;
            txtbxName.MouseClick += txtbxName_MouseClick;
            txtbxName.TextChanged += txtbxName_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(355, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.Location = new Point(644, 320);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(94, 29);
            btnMainPage.TabIndex = 11;
            btnMainPage.Text = "Main Page";
            btnMainPage.UseVisualStyleBackColor = true;
            // 
            // lblQuantityWarning
            // 
            lblQuantityWarning.AutoSize = true;
            lblQuantityWarning.Location = new Point(403, 308);
            lblQuantityWarning.Name = "lblQuantityWarning";
            lblQuantityWarning.Size = new Size(0, 20);
            lblQuantityWarning.TabIndex = 12;
            // 
            // lblPriceWarning
            // 
            lblPriceWarning.AutoSize = true;
            lblPriceWarning.Location = new Point(403, 239);
            lblPriceWarning.Name = "lblPriceWarning";
            lblPriceWarning.Size = new Size(0, 20);
            lblPriceWarning.TabIndex = 13;
            // 
            // lblItemNameWarning
            // 
            lblItemNameWarning.AutoSize = true;
            lblItemNameWarning.Location = new Point(403, 164);
            lblItemNameWarning.Name = "lblItemNameWarning";
            lblItemNameWarning.Size = new Size(0, 20);
            lblItemNameWarning.TabIndex = 14;
            lblItemNameWarning.Click += lblItemNameWarning_Click;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(lblItemNameWarning);
            Controls.Add(lblPriceWarning);
            Controls.Add(lblQuantityWarning);
            Controls.Add(btnMainPage);
            Controls.Add(btnAdd);
            Controls.Add(txtbxName);
            Controls.Add(listBox1);
            Controls.Add(UDPrice);
            Controls.Add(UDQuantity);
            Controls.Add(label5);
            Controls.Add(lblItemName);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Name = "AddItemForm";
            Text = "AddItemForm";
            FormClosing += AddItemForm_FormClosing;
            Load += AddItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)UDQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)UDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblItemName;
        private Label label5;
        private NumericUpDown UDQuantity;
        private NumericUpDown UDPrice;
        private ListBox listBox1;
        private TextBox txtbxName;
        private Button btnAdd;
        private Button btnMainPage;
        private Label lblQuantityWarning;
        private Label lblPriceWarning;
        private Label lblItemNameWarning;
    }
}