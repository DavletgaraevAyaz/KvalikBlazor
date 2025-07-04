namespace KvalikBlazor.Request
{
    public class ProductRequest
    {
        public string Name { get; set; } = "";
        public string BatchNumber { get; set; } = "";
        public int Quantity { get; set; }
        public string ExpirationDate { get; set; } = "04.07.2025";
        public string StorageConditions { get; set; } = "";
    }
}
