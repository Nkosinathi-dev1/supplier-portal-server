namespace server.Models
{
    public class SupplierContact : Core
    {
        public string Telephone { get; set; } = string.Empty;

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = null!;
    }
}
