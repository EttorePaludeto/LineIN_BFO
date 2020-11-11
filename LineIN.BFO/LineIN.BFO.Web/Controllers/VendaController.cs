using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LineIN.BFO.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LineIN.BFO.Web.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaRepository vendaRepository;
        private readonly IParticipanteRepository participanteRepository;

        public VendaController(IVendaRepository vendaRepository, 
            IParticipanteRepository participanteRepository) 
        {
            this.participanteRepository = participanteRepository;
            this.vendaRepository = vendaRepository;
        }

        [HttpGet]
        public IActionResult Incluir()
        {
            ViewBag.Parts = participanteRepository.GetAll();
            return View();
        }
    }
}
