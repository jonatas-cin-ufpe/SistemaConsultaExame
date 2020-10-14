using SistemaConsultaExames.Domain.Entities;
using SistemaConsultaExames.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SistemaConsultaExames.Infra.Data.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente> , IPacienteRepository
    {
        public IEnumerable<Paciente> BuscarPorNome(string nome)
        {
            return Db.Pacientes.Where(p => p.Nome == nome);
        }

        public IEnumerable<Paciente> BuscarPorCPF(string cpf)
        {
            return Db.Pacientes.Where(p => p.CPF == cpf);
        }

    }
}
