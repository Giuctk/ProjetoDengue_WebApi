using Api.DTO;
using AutoMapper;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Gravidade, GravidadeViewModel>().ReverseMap();
            CreateMap<Status, StatusViewModel>().ReverseMap();
            CreateMap<Atendimento, AtendimentoViewModel>().ReverseMap();
            CreateMap<Localizacao, LocalizacaoViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
        }
    }
}
