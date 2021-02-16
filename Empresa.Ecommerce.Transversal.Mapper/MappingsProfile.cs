using System;
using AutoMapper;
using Empresa.Ecommerce.Domain.Entity;
using Empresa.Ecommerce.Application.DTO;

namespace Empresa.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            //Si todos los atributos se llaman igual en la clase de Aplicacion CustomerDTO y la Domain Entity Customer
            CreateMap<Customers, CustomersDTO>().ReverseMap();

            //En caso de que los atributos no se llaman igual, se puede aplicar atributo por atributo

            /*
             CreateMap<Customers, CustomersDTO>().ReverseMap()
                .ForMember(
                destination => destination.CustomerId,
                source => source.MapFrom(src => src.CustomerId))
                .ForMember(
                destination => destination.CompanyName,
                source => source.MapFrom(src => src.CompanyName)).ReverseMap();
            */
        }
    }
}
