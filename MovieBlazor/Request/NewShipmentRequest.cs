namespace KvalikBlazor.Request
{
    public class NewShipmentRequest
    {
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public string Destination { get; set; } = "";
        public string Priority { get; set; } = "Средний";
        public DateTime ShipmentDate { get; set; }
    }
}
