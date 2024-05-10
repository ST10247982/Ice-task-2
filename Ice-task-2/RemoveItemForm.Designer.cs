using System.Windows.Forms;

namespace Ice_task_2
{
    partial class RemoveItemForm
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
            lstbxCategory = new ListBox();
            lblItemName = new Label();
            txtbxName = new TextBox();
            lblCategory = new Label();
            btnRemove = new Button();
            lblNameWarning = new Label();
            SuspendLayout();
            // 
            // lstbxCategory
            // 
     
            lstbxCategory.FormattingEnabled = true;
            lstbxCategory.Items.AddRange(new object[] { Category.fruits, Category.vegetables, Category.dairy, Category.meat, Category.bakery });
            lstbxCategory.Location = new Point(343, 141);
            lstbxCategory.Name = "lstbxCategory";
            lstbxCategory.Size = new Size(150, 104);
            lstbxCategory.TabIndex = 0;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(164, 67);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(86, 20);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "Item Name:";
            // 
            // txtbxName
            // 
            txtbxName.Location = new Point(343, 60);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(125, 27);
            txtbxName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(164, 141);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(318, 338);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblNameWarning
            // 
            lblNameWarning.AutoSize = true;
            lblNameWarning.Location = new Point(343, 103);
            lblNameWarning.Name = "lblNameWarning";
            lblNameWarning.Size = new Size(0, 20);
            lblNameWarning.TabIndex = 5;
            lblNameWarning.MouseClick += lblNameWarning_MouseClick;
            lblNameWarning.MouseDoubleClick += lblNameWarning_MouseDoubleClick;
            // 
            // RemoveItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(lblNameWarning);
            Controls.Add(btnRemove);
            Controls.Add(lblCategory);
            Controls.Add(txtbxName);
            Controls.Add(lblItemName);
            Controls.Add(lstbxCategory);
            Name = "RemoveItemForm";
            Text = "RemoveItemForm";
            FormClosing += RemoveItemForm_FormClosing;
            Load += RemoveItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbxCategory;
        private Label lblItemName;
        private TextBox txtbxName;
        private Label lblCategory;
        private Button btnRemove;
        private Label lblNameWarning;
    }
}