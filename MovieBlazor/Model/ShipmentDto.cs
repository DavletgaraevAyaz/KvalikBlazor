namespace KvalikBlazor.Model
{
    public class ShipmentDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Destination { get; set; }
        public string Priority { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string WarehouseName { get; set; }
    }
}
