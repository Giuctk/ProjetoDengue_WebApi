using API.DTO;
using Business.Interfaces.Repository;
using Business.Interfaces.Service;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Business.Services
{
    public class AtendimentoService : IAtendimentoService
    {
        private readonly ILocalizacaoRepository _localizacao;
        private readonly IAtendimentoRepository _atendimento;
        public AtendimentoService(
            IAtendimentoRepository atendimento,
            ILocalizacaoRepository localizacao)
        {
            _atendimento = atendimento;
            _localizacao = localizacao;
        }

        public AtendimentoViewModel CriaAtendimento(AtendimentoViewModel model)
        {
            var atendimentoEntity = new Atendimento();
            var localizacaoEntity = new Localizacao();

            localizacaoEntity.CEP = model.CEP;
            localizacaoEntity.Rua = model.Rua;
            localizacaoEntity.Numero = model.Numero;
            localizacaoEntity.Bairro = model.Bairro;
            localizacaoEntity.Cidade = model.Cidade;
            localizacaoEntity.SiglaEstado = model.SiglaEstado;

            atendimentoEntity.DataInclusao = DateTime.Now;
            atendimentoEntity.ObservacaoRequisitante = model.Observacao;
            atendimentoEntity.Localizacao = localizacaoEntity;

            var atendimentoSalvo = _atendimento.Add(atendimentoEntity);
            model.IdAtendimento = atendimentoSalvo.IdAtendimento;

            return model;
        }
    }
}
