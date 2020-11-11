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
    public class ParticipanteController : BaseController
    {
        public readonly IParticipanteRepository participanteRepository;
        public readonly IMapper mapper;


        public ParticipanteController(IParticipanteRepository _participanteRepository, IMapper _mapper)
        {
            participanteRepository = _participanteRepository;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult ListaParticipantes()
        {
            var clientes = participanteRepository.GetAll();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Incluir(ParticipanteVM participanteVm)
        {
       
            if (ModelState.IsValid)
            {
                var participante = mapper.Map<Participante>(participanteVm);
                
                if (participante.InValid)
                {
                    foreach (var item in participante.Notifications())
                    {
                        ModelState.AddModelError(item.Key, item.Message);
                        return View(participante);
                    }
                }

                participanteRepository.Insert(participante);
                return RedirectToAction("ListaParticipantes");
            }

            return View(participanteVm);
        }

        [HttpGet]
        //Trocar pelo ID depois. Como a lista é faze, um novo GUID é gerado a cada requisição.
        public IActionResult Editar(string CNPJ)
        {
           
            var participante = participanteRepository.GetBy(c=>c.CNPJouCPF == CNPJ);
            var participanteVm = mapper.Map<ParticipanteVM>(participante);
            return View(participanteVm);
        }


        [HttpPost]
        public IActionResult Editar(ParticipanteVM cliente)
        {
            if (ModelState.IsValid)
            {

                var participante = participanteRepository.GetBy(c => c.Id == cliente.Id);

                //var ClienteDominio = mapper.Map<Cliente>(cliente);

                if (participante.InValid)
                {
                    foreach (var item in participante.Notifications())
                    {
                        ModelState.AddModelError(item.Key, item.Message);
                        return View(cliente);
                    }
                }

                participanteRepository.Update(participante);
                return RedirectToAction("ListaParticipantes");
            }

            return View(cliente);
        }


        [HttpGet]
        //Trocar pelo ID depois. Como a lista é faze, um novo GUID é gerado a cada requisição.
        public IActionResult Excluir(string CNPJ)
        {
            var participante = participanteRepository.GetBy(c => c.CNPJouCPF == CNPJ);
            participanteRepository.Delete(participante);
            return RedirectToAction("ListaParticipantes");
        }
    }
}
