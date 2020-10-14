using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaExames.Domain.Entities
{
    public class Exame
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Observacao { get; set; }

        public ExamesTipo Tipo { get; set; }



    }
}
