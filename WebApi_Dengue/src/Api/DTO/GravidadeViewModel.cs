using Api.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Models
{
    public class GravidadeViewModel 
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Prioridade { get; set; }
        public IEnumerable<AtendimentoViewModel> Atendimentos { get; set; }
    }
}
