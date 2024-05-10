using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_task_2
{
    public class Inventory
    {
       public Dictionary<Category, List<InventoryItem>> itemDictionary = new Dictionary<Category, List<InventoryItem>>();
        public Stack<InventoryItem> InventoryHistory = new Stack<InventoryItem>();

       
        public Boolean addItem (InventoryItem item)  // can throw failed to add exception
        {

            Boolean itemAddedStack = false;
            Boolean itemAddedDictionary = false;
            foreach(InventoryItem StackItem in InventoryHistory)
            {
                if (StackItem.Name== item.Name)
                {
                    throw new FailedToAddException($"There is already an item with the name {StackItem.Name} that belongs to category " +
                        $"{StackItem.Category}", DateTime.Now, "Maybe try adding another item with a different name", "Unable to add item!");
                }
            }
            InventoryHistory.Push(item);
            InventoryItem lastAdded = InventoryHistory.Peek();   // getting the person at the top of the stack/last added
            if(lastAdded == item)    // checking if the last person we added was the item passed into the method
            {
                itemAddedStack = true;
            }
            if (itemDictionary.ContainsKey(item.Category))
            {
                itemDictionary[item.Category].Add(item);  // by specifying the key first, this will access the list corressponding to the key
                itemAddedDictionary = true;                         // this means we will be adding the item into the list
            }
            else
            {
                List<InventoryItem> newList = new List<InventoryItem>();
                newList.Add(item);
                itemDictionary.Add(item.Category, newList);
                itemAddedDictionary = true;
            }
            Boolean addedItems = false;
            if(itemAddedStack==true && itemAddedDictionary==true) // checcking if they were successfully added on both sides
            {
                addedItems = true;
            }
            return addedItems;
        }

        public Boolean removeItem(string  targetItemName,Category targetCategory) // throws fail to remove exception
        {     

            Boolean removed = false;
            int count = 0;
               Stack <InventoryItem> tempStack = new Stack<InventoryItem> ();  // creating a temp stack
            InventoryItem toBeRemoved = null;
            while(InventoryHistory.Count > 0)   // looping through the current inventory
            {
                count++;
                InventoryItem currentItem = InventoryHistory.Pop ();  // popping the last item and holding it
                if (currentItem.Name == targetItemName)     // checking if the popped item is what we want to remove
                {
                    toBeRemoved = currentItem;
                    removed = true;
                }
                else
                {
                    tempStack.Push(currentItem);
                }
                 if( count == InventoryHistory.Count && removed== false)
                {
                    throw new FailedToRemoveException("The target item was not found", DateTime.Now,"Maybe try finding another item to remove", "Oh no, unable to remove the item!");
                }
                
            }
            while(tempStack.Count > 0)           // while loop to push all tempstack values back to original stack
            {
       
                InventoryHistory.Push(tempStack.Pop());
            }
            if (itemDictionary.ContainsKey(targetCategory))     // finding the key by using the ContainsKey() mehtod 
            {
                itemDictionary[targetCategory].Remove(toBeRemoved);
                // dictionary[key] --> access the list at that point so that .Remove(item) --> will remove an item from the list                                            
                removed = true;
            }
            return removed;
        }
        public string DisplayInventory()
        {
          
            string display = "";
            if (InventoryHistory.Count == 0)
            {
                display = "There are currently no items to display";
            }
                foreach (KeyValuePair <Category, List<InventoryItem>> kvp in itemDictionary)       // looping through all keys in dictionary
            {
                display += $"Category: {kvp.Key}\n";
                List<InventoryItem> currentList = kvp.Value;   // here we are getting the current list
                int count = 0;
                foreach(InventoryItem item in currentList)     // looping through all values in the current list
                {
                    count++;
                    display += $"{count})Product details:\n {item.Name} \n";
                    display += $"R {item.Price}\n";
                    display += $"Quantity: {item.Quantity}\n";
                    
                   
                }
                display += "\n";
            }
            return display;
        }

        

    }
}
