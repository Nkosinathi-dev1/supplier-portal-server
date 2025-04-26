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
    }
}
