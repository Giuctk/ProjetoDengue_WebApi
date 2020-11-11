using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Status
    {
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
