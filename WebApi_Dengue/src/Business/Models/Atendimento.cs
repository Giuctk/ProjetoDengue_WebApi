using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class Atendimento:Entity
    {
        public Guid IdLocalizacao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string  ObservacaoRequisitante { get; set; }
        public Guid IdGravidade { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public Guid IdStatus { get; set; }
        public Guid? IdRequisitante { get; set; }
        public Guid? IdAgenteAdministrativo { get; set; }
        public Guid? IdAgenteCampo { get; set; }

        public Localizacao Localizacao { get; set; }
        public Status Status { get; set; }
        public Gravidade Gravidade { get; set; }
        public Usuario Requisitante { get; set; }
        public Usuario AgenteAdministrativo { get; set; }
        public Usuario AgenteCampo { get; set; }
    }
}
