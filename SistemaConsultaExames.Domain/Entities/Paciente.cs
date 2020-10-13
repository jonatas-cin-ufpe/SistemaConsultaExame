using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaConsultaExames.Domain.Entities
{
    public class Paciente
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Campo Nome não pode possuir mais do que 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14, ErrorMessage = "CPF não atende ao formato correto XXX.XXX.XXX-YY")]
        [RegularExpression(@"([0-9]{3})\.([0-9]{3})\.([0-9]{3})\-([0-9]{2})", ErrorMessage = "CPF não atende ao formato correto XXX.XXX.XXX-YY")]
        public int CPF { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required]
        public string Sexo { get; set; }


        [Required]
        public string Telefone  { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        public ExamesTipo Exame { get; set; }

    }
}
