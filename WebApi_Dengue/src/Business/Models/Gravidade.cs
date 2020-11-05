using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Gravidade : Entity
    {
        public string Descricao { get; set; }
        public int Prioridade { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
