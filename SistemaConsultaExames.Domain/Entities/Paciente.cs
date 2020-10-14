using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaExames.Domain.Entities
{
    public class Paciente
    {
        
        public string Nome { get; set; }

        [RegularExpression(@"([0-9]{3})\.([0-9]{3})\.([0-9]{3})\-([0-9]{2})", ErrorMessage = "CPF não atende ao formato correto XXX.XXX.XXX-YY")]
        public string CPF { get; set; }

       
        public DateTime Nascimento { get; set; }

        public string Sexo { get; set; }

        public string Telefone  { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        public virtual IEnumerable<MarcacaoConsulta> Consultas { get; set; }

    }
}
