using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamAppointment.MVC.ViewModels
{
    public class ExameViewModel
    {
        public int Id { get; set; }

        public string Observacao { get; set; }

        public ExamesTipo Tipo { get; set; }
    }
}