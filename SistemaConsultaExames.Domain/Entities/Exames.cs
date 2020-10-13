using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaExames.Domain.Entities
{
    public class Exames
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "Campo Observacao não pode possuir mais do que 1000 caracteres")]
        public string Observacao { get; set; }

        public ExamesTipo Exame { get; set; }



    }
}
