using SistemaConsultaExames.Domain.Entities;
using System.Collections.Generic;

namespace SistemaConsultaExames.Domain.Interfaces
{
    public interface IExamesTipoRepository : IRepositoryBase<ExamesTipo>
    {
        IEnumerable<ExamesTipo> BuscarPorNome(string nome);

    }
}
