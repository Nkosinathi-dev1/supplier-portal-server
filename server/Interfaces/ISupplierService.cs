using server.Dtos;

namespace server.Interfaces
{
    public interface ISupplierService
    {
        Task<SupplierDto> AddSupplierAsync(SupplierDto dto);
        Task<string?> GetPhoneNumberByCompanyNameAsync(string companyName);
        Task<List<SupplierDropdownDto>> GetSuppliersForDropdownPaginatedAsync(int page, int pageSize);
        Task<List<SupplierResponseDto>> GetSuppliersByIdsAsync(List<int> ids);

        Task<SupplierResponseDto?> GetSupplierByIdAsync(int id);

        Task<SupplierDto?> GetSupplierByCompanyNameAsync(string companyName);




        //Task<List<SupplierDropdownDto>> GetSuppliersForDropdownPaginatedAsync(int page, int pageSize);


    }
}
