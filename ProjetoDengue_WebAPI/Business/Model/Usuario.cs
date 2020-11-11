using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public IEnumerable<Atendimento> AtendimentosAdm { get; set; }
        public IEnumerable<Atendimento> AtendimentosCampo { get; set; }
    }
}
