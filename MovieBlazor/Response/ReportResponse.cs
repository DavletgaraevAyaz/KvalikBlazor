namespace KvalikBlazor.Response
{

    public class ReportResponse
    {
        public List<string> Headers { get; set; } = new();
        public List<List<string>> Data { get; set; } = new();
    }
}
