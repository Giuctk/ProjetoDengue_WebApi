using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Status:Entity
    {
        public string Descricao { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
