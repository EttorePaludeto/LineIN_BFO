using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LineIN.BFO.Interfaces;
using LineIN.BFO.Models;
using LineIN.BFO.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LineIN.BFO.Web.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaRepository vendaRepository;
        private readonly IParticipanteRepository participanteRepository;
        public readonly IMapper mapper;

        public VendaController(IVendaRepository vendaRepository, 
            IParticipanteRepository participanteRepository,
            IMapper mapper) 
        {
            this.participanteRepository = participanteRepository;
            this.vendaRepository = vendaRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Incluir()
        {

            VendaVM vendaVM = new VendaVM();
            var participantes = participanteRepository.GetAll().ToList();
            vendaVM.ListaParticipantes = mapper.Map<List<Participante>, List<ParticipanteVM>>(participantes);
            return View(vendaVM);
        }
    }
}
