using SistemaConsultaExames.Domain.Entities;
using SistemaConsultaExames.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SistemaConsultaExames.Infra.Data.Repositories
{
    public class ExamesTipoRepository : RepositoryBase<ExamesTipo>, IExamesTipoRepository
    {
        public IEnumerable<ExamesTipo> BuscarPorNome(string nome)
        {
            return Db.TiposDeExame.Where(p => p.Nome == nome);
        }

    }
}