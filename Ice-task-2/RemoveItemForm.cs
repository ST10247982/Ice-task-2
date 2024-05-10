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
    public partial class RemoveItemForm : Form
    {
        Grocerystore store;
        public RemoveItemForm(Grocerystore store)
        {
            this.store = store;
            InitializeComponent();
        }

        private void RemoveItemForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            InputValidator Validator = new InputValidator();
           
            Boolean validItem = true;
            string name = txtbxName.Text;
            Boolean validName = Validator.validateStringInput(name);
            if (validName != true)
            {
                txtbxName.Clear();
                lblNameWarning.ForeColor = Color.Red;
                txtbxName.Focus();
                lblNameWarning.Text = "There must not be numbers";
                txtbxName.ForeColor = Color.Black;
                validItem = false;
            }
            Category selectedCategory = (Category)lstbxCategory.SelectedItem;
           
            if (validItem == true)
            {


                string ErrorMessage = store.GroceryStoreRemove(name, selectedCategory);
                if (ErrorMessage.Length > 0)
                {
                    txtbxName.Clear();

                    txtbxName.Focus();
                    MessageBox.Show(ErrorMessage);
                    validItem = false;
                }
                else
                {
                    this.Close();

                    Form1 form= new Form1(store);
                    form.Show();
                    this.Close();
                }
            }
        }

        private void lblNameWarning_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblNameWarning_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void RemoveItemForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
