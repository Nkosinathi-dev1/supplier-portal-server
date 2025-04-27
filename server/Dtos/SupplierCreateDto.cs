namespace server.Dtos
{
    public class SupplierCreateDto
    {
        public string CompanyName { get; set; } = string.Empty;
        public List<string> Telephones { get; set; } = new();
    }
}
