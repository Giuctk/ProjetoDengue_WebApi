using Api.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Models
{
    public class StatusViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<AtendimentoViewModel> Atendimentos { get; set; }
    }
}
