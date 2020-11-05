using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Localizacao : Entity
    {
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
