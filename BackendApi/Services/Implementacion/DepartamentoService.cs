using Microsoft.EntityFrameworkCore;
using BackendApi.Models;
using BackendApi.Services.Contrato;

namespace BackendApi.Services.Implementacion
{
    public class DepartamentoService: iDepartamentoService
    {
        private DbempleadoContext _dbContext; //contexto hacia la base de datos

        public DepartamentoService(DbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Departamento>>GetList()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                lista = await _dbContext.Departamentos.ToListAsync();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
