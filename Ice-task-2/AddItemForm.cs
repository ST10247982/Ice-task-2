using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_task_2
{
    public partial class AddItemForm : Form
    {
        public Grocerystore store;
        public Form1 form;
        public AddItemForm(Grocerystore store)
        {
            InitializeComponent();

            this.store = store;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputValidator validator = new InputValidator();
            InventoryItem item = new InventoryItem();
            Boolean validItem = true;
            Category selectedCategory = (Category)listBox1.SelectedItem;
            string ItemName = txtbxName.Text;
            Boolean validName = validator.validateStringInput(ItemName);
            if (validName != true)
            {
                txtbxName.Clear();
                lblItemNameWarning.ForeColor = Color.Red;
                txtbxName.Focus();
                lblItemNameWarning.Text = "There must not be numbers";
                txtbxName.ForeColor = Color.Black;
                validItem = false;
            }

            double Price = (double)UDPrice.Value;

            if (Price == 0)
            {
                UDPrice.Focus();
                lblPriceWarning.ForeColor = Color.Red;
                lblPriceWarning.Text = "You have not entered a price greater than R 0";
                validItem = false;
            }
            lblPriceWarning.ForeColor = Color.Black;

            int Quantity = (int)UDQuantity.Value;
            if (Quantity == 0)
            {
                UDQuantity.Focus();
                lblQuantityWarning.ForeColor = Color.Red;
                lblQuantityWarning.Text = "You have not entered a value greater than 1";
                validItem = false;
            }
            if (validItem == true)
            {
                item.Name = ItemName;
                item.Price = Price;
                item.Quantity = Quantity;
                item.Category = selectedCategory;
                item.QuantityThreshold = (int)Math.Round(0.2 * Quantity);

                string errorMessage = store.GroceryStoreAdd(item);
                if (errorMessage.Length > 0)
                {
                    txtbxName.Clear();
                   
                    txtbxName.Focus();
                    MessageBox.Show(errorMessage);
                    validItem = false;
                }
                else
                {
                    this.Close();

                    form = new Form1(store);
                    form.Show();
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (e.Cancel == true)
            {
                CloseAllInstances();

            }


        }
        public static void CloseAllInstances()
        {
            // Get the process name without the extension
            string processName = System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location);

            // Get all processes with the same name
            Process[] processes = Process.GetProcessesByName(processName);

            // Close each process
            foreach (Process process in processes)
            {
                if (!process.Equals(Process.GetCurrentProcess())) // Don't close the current process
                {
                    process.CloseMainWindow(); // Close the main window of the process
                    process.WaitForExit(); // Wait for the process to exit gracefully
                }
            }
        }

        private void txtbxName_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void lblItemNameWarning_Click(object sender, EventArgs e)
        {

        }
    }

}
