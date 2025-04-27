using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Dtos;
using server.Interfaces;
using server.Models;

namespace server.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public SupplierService(AppDbContext db, IMapper mapper)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<SupplierDto> AddSupplierAsync(SupplierDto dto)
        {
            var supplier = _mapper.Map<Supplier>(dto);
            _db.Suppliers.Add(supplier);
            await _db.SaveChangesAsync();
            return _mapper.Map<SupplierDto>(supplier);
        }

        public async Task<string?> GetPhoneNumberByCompanyNameAsync(string companyName)
        {
            var supplier = await _db.Suppliers
                .FirstOrDefaultAsync(s => s.CompanyName.ToLower() == companyName.ToLower());

            return supplier?.Telephone;
        }


        public async Task<SupplierResponseDto?> GetSupplierByIdAsync(int id)
        {
            var supplier = await _db.Suppliers.FirstOrDefaultAsync(s => s.Id == id);

            if (supplier == null) return null;

            return new SupplierResponseDto
            {
                CompanyName = supplier.CompanyName,
                Telephone = supplier.Telephone
            };
        }

        public async Task<List<SupplierResponseDto>> GetSuppliersByIdsAsync(List<int> ids)
        {
            var suppliers = await _db.Suppliers
                .Where(s => ids.Contains(s.Id))
                .ToListAsync();

            return suppliers.Select(s => new SupplierResponseDto
            {
                CompanyName = s.CompanyName,
                Telephone = s.Telephone
            }).ToList();
        }




        public async Task<List<SupplierDropdownDto>> GetSuppliersForDropdownPaginatedAsync(int page, int pageSize)
        {
            var skip = (page - 1) * pageSize;

            return await _db.Suppliers
                .OrderBy(s => s.CompanyName)
                .Skip(skip)
                .Take(pageSize)
                .Select(s => new SupplierDropdownDto
                {
                    Id = s.Id,
                    CompanyName = s.CompanyName
                })
                .ToListAsync();
        }



    }
}
