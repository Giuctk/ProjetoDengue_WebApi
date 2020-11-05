using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public class AtendimentoViewModel
    {
        [Key]
        public int Id { get; set; }
        public int IdLocalizacao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string ObservacaoRequisitante { get; set; }
        public int IdGravidade { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdStatus { get; set; }
        public int? IdRequisitante { get; set; }
        public int? IdAgenteAdministrativo { get; set; }
        public int? IdAgenteCampo { get; set; }

        public LocalizacaoViewModel Localizacao { get; set; }
        public StatusViewModel Status { get; set; }
        public GravidadeViewModel Gravidade { get; set; }
        public UsuarioViewModel Requisitante { get; set; }
        public UsuarioViewModel AgenteAdministrativo { get; set; }
        public UsuarioViewModel AgenteCampo { get; set; }
    }
}
