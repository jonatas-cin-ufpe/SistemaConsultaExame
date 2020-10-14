using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultaExames.Domain.Entities
{
    public class MarcacaoConsulta
    {
        public int Protocolo { get; set; }

        public DateTime Horario { get; set; }

        public string PacienteCPF { get; set; }

        public virtual Paciente Paciente {get; set;}

        public string ExameNome { get; set; }
        public ExamesTipo Exame { get; set; }
    }
}
