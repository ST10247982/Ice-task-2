

namespace Ice_task_2
{
    public  class InventoryItem
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }

        public int QuantityThreshold { get; set; }   // we will use this to check if the quantity of items are almost depleted
    }
}
