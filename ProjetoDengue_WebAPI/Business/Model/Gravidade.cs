using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Gravidade
    {
        public int IdGravidade { get; set; }
        public string Descricao { get; set; }
        public int Prioridade { get; set; }

        public IEnumerable<Atendimento> Atendimentos { get; set; }

    }
}
