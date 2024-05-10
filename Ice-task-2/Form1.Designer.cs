namespace Ice_task_2
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
            rTbxDisplay = new RichTextBox();
            btnDisplay = new Button();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // rTbxDisplay
            // 
            rTbxDisplay.Location = new Point(28, 21);
            rTbxDisplay.Name = "rTbxDisplay";
            rTbxDisplay.Size = new Size(497, 310);
            rTbxDisplay.TabIndex = 1;
            rTbxDisplay.Text = "";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(241, 364);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display Items";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += button1_Click_1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(87, 46);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 34);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += button2_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(87, 135);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(94, 34);
            btnRemoveItem.TabIndex = 4;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRemoveItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Location = new Point(654, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 229);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(rTbxDisplay);
            panel2.Controls.Add(btnDisplay);
            panel2.Location = new Point(35, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 418);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 488);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rTbxDisplay;
        private Button btnDisplay;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Panel panel1;
        private Panel panel2;
    }
}
