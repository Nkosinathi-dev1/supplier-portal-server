using AutoMapper;
using server.Dtos;
using server.Models;

namespace server.Profiles
{
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<SupplierDto, Supplier>();
            CreateMap<Supplier, SupplierDto>();
        }
    }
}
