using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDTO, Customer>().ReverseMap();
        }
    }
}
