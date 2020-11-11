using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Atendimento
    {
        public int IdAtendimento { get; set; }
        public int IdLocalizacao { get; set; }
        public int? IdGravidade { get; set; }
        public int? IdAgenteAdministrativo { get; set; }
        public int? IdAgenteCampo { get; set; }
        public int? IdStatus { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAtendimento { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string ObservacaoRequisitante { get; set; }
        public string ObservacaoAgente { get; set; }

        public Localizacao Localizacao { get; set; }
        public Gravidade Gravidade { get; set; }
        public Status Status { get; set; }
        public Usuario AgenteAdministrativo { get; set; }
        public Usuario AgenteCampo { get; set; }
    }
}
