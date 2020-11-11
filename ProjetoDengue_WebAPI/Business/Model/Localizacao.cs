using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Localizacao
    {
        public int IdLocalizacao { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string SiglaEstado { get; set; }

        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
