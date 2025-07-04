namespace KvalikBlazor.Response
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BatchNumber { get; set; }
        public int Quantity { get; set; }
        public string ExpirationDate { get; set; }
        public string StorageConditions { get; set; }
    }
}
