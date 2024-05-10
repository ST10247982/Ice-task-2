namespace Ice_task_2
{
    public partial class Form1 : Form
    {
        private Grocerystore store;

        public Form1(Grocerystore store)
        {
            InitializeComponent();
            this.store = store;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            rTbxDisplay.Text = store.GroceryStoreDisplay();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(store);
            addItemForm.Show();

            this.Hide();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveItemForm removeItemForm = new RemoveItemForm(store);
            removeItemForm.Show();
            this.Hide();
        }
    }
}
