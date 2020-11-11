using API.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces.Service
{
    public interface IAtendimentoService
    {
        AtendimentoViewModel CriaAtendimento(AtendimentoViewModel model);
    }
}
