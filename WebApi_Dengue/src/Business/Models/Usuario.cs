using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
