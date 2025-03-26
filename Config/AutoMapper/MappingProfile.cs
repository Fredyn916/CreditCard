using AutoMapper;
using Models.DTO;
using Models.Entities;

namespace Config.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ClienteDTO, Cliente>().ReverseMap();
        CreateMap<CartaoDTO, Cartao>().ReverseMap();
    }
}