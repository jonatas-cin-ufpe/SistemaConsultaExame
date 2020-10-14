using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExamAppointment.MVC.ViewModels
{
    public class PacienteViewModel
    {

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres" )]
        public string Nome { get; set; }

        [Key]
        [Required(ErrorMessage = "Preencha o Campo CPF")]
        [RegularExpression(@"([0-9]{3})\.([0-9]{3})\.([0-9]{3})\-([0-9]{2})", ErrorMessage = "CPF não atende ao formato correto XXX.XXX.XXX-YY")]
        public string CPF { get; set; }


        [Required(ErrorMessage = "Preencha o Campo Nascimento")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Sexo")]
        public string Sexo { get; set; }


        [Required(ErrorMessage = "Preencha o Campo Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o Campo E-Mail")]
        [DisplayName("E-Mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        public virtual IEnumerable<MarcacaoConsultaViewModel> Consultas { get; set; }
    }
}