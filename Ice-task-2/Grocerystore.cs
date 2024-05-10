

namespace Ice_task_2
{

    public class Grocerystore
    {
        Inventory inventory { get; set; }

        public Grocerystore()
        {
            inventory = new Inventory();
            

        }
        public string GroceryStoreDisplay()
        {
            return inventory.DisplayInventory();
        }
        public string GroceryStoreAdd(InventoryItem item)
        {
            

            string errorMessage = "";
            try
            {
                inventory.addItem(item);
            }
            catch (FailedToAddException e)
            {
                errorMessage = $"Error: {e.Message}\n";
                errorMessage += $"Cause: {e.CauseOfError}\n";
                errorMessage += $"Time: {e.ErrorTimeStamp} \n";
                errorMessage += $"Solution: {e.Solution} \n";
            }
            return errorMessage;
        }
        public string GroceryStoreRemove(string ItemName, Category category)


        {
            string errorMessage = "";
            try
            {
                inventory.removeItem(ItemName, category);
            }
            catch (FailedToRemoveException e)
            {
                errorMessage = $"Error: {e.Message}\n";
                errorMessage += $"Cause: {e.CauseOfError}\n";
                errorMessage += $"Time: {e.ErrorTimeStamp} \n";
                errorMessage += $"Solution: {e.Solution} \n";
            }
            return errorMessage;
        }
       

    }
}
