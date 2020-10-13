﻿using System.ComponentModel.DataAnnotations;

namespace SistemaConsultaExames.Domain.Entities
{
    public class ExamesTipo
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Campo Nome não pode possuir mais do que 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(256, ErrorMessage = "Campo Descricao não pode possuir mais do que 256 caracteres")]
        public string Descricao { get; set; }
    }
}
