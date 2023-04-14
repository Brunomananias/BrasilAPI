using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
     
    }
} 
