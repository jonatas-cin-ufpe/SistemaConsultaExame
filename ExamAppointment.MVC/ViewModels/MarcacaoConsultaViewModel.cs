using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamAppointment.MVC.ViewModels
{
    public class MarcacaoConsultaViewModel
    {   
        [Key]
        public int Protocolo { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Horario"]
        public DateTime Horario { get; set; }


        public string PacienteCPF { get; set; }

        public virtual PacienteViewModel Paciente { get; set; }

        public string ExameNome { get; set; }
        public ExamesTipoViewModel Exame { get; set; }

    }
}