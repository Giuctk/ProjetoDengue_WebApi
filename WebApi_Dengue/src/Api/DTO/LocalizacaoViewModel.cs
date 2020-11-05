﻿using Api.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Models
{
    public class LocalizacaoViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public IEnumerable<AtendimentoViewModel> Atendimentos { get; set; }
    }
}
