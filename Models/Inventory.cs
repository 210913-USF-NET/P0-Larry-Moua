namespace Models
{
    public class Inventory
    {
        public Inventory() {}

        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int PhotocardId { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Warehouse: {this.WarehouseId}, PhotocardId: {this.PhotocardId}, Stock {this.Stock}";
        }
    }
}