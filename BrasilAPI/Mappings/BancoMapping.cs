using BrasilAPI.Dtos;
using BrasilAPI.Models;
using AutoMapper;

namespace BrasilAPI.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping() 
        {
        CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
        CreateMap<BancoResponse, BancoModel>();
        CreateMap<BancoModel, BancoResponse>();
        }
    }
}
