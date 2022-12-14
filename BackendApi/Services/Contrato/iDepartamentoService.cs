using BackendApi.Models;

namespace BackendApi.Services.Contrato
{
    public interface iDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}
