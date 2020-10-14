using SistemaConsultaExames.Domain.Entities;
using System.Collections.Generic;

namespace SistemaConsultaExames.Domain.Interfaces
{
    public interface IPacienteRepository : IRepositoryBase<Paciente>
    {
            IEnumerable<Paciente> BuscarPorNome(string nome);
            IEnumerable<Paciente> BuscarPorCPF(string cpf);
    }
}
