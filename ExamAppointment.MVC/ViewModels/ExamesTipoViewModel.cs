using System.ComponentModel.DataAnnotations;

namespace ExamAppointment.MVC.ViewModels
{
    public class ExamesTipoViewModel
    {   
        [Key]
        [Required(ErrorMessage = "Preencha o Campo Nome"]
        [MaxLength(100, ErrorMessage = "Campo Nome não pode possuir mais do que 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Descricao é obrigatório"]
        [MaxLength(256, ErrorMessage = "Campo Descricao não pode possuir mais do que 256 caracteres")]
        public string Descricao { get; set; }
    }
}