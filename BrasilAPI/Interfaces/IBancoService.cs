using BrasilAPI.Dtos;

namespace BrasilAPI.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}
