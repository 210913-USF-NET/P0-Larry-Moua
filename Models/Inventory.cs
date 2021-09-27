namespace Models
{
    public class Inventory
    {
        public Inventory() {}

        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int PhotocardId { get; set; }
        public int Stock { get; set; }
    }
}