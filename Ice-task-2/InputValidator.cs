

namespace Ice_task_2
{
    public  class InputValidator
    {
        public Boolean ValidMethodStringInput = false;
        public Boolean ValidMethodIntInput = false;
        public Boolean validateStringInput(string input)
        {
            
            if(ValidMethodStringInput == input.Any(char.IsDigit))       
            {
                ValidMethodStringInput = true;
            }
            return ValidMethodStringInput;
        }
        public Boolean ValidateIntInput(int input)
        {
            if(input > 0)
            {
                ValidMethodIntInput = true;
            }
            return ValidMethodIntInput;
        }
        public Boolean ValidateInventoryItem(InventoryItem item)
        {
            Boolean valid = false;
            if(item.Price >0 && item.Category!= null && item.Quantity>0)
            {
                valid = true;
            }
            return valid;
        }   // this will be called before we do the addItem/removeItem method

       
    }
}
