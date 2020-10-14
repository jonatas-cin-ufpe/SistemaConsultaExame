using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaExames.Domain.Entities
{
    public class Paciente
    {
        
        public string Nome { get; set; }

        public string CPF { get; set; }

       
        public DateTime Nascimento { get; set; }

        public string Sexo { get; set; }

        public string Telefone  { get; set; }

       
        public string Email { get; set; }

        public virtual IEnumerable<MarcacaoConsulta> Consultas { get; set; }

    }
}
