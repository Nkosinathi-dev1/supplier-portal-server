using server.Dtos;

namespace server.Interfaces
{
    public interface ISupplierService
    {
        Task<SupplierDto> AddSupplierAsync(SupplierDto dto);
        Task<string?> GetPhoneNumberByCompanyNameAsync(string companyName);
    }
}
