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
        public readonly IClienteRepository clienteRepository;
        public readonly IMapper mapper;


        public ParticipanteController(IClienteRepository _clienteRepository, IMapper _mapper)
        {
            clienteRepository = _clienteRepository;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult ListaParticipantes()
        {
            var clientes = clienteRepository.GetAll();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Incluir(ClienteVM cliente)
        {
       
            if (ModelState.IsValid)
            {
                var ClienteDominio = mapper.Map<Cliente>(cliente);
                
                if (ClienteDominio.InValid)
                {
                    foreach (var item in ClienteDominio.Notifications())
                    {
                        ModelState.AddModelError(item.Key, item.Message);
                        return View(cliente);
                    }
                }

                clienteRepository.Insert(ClienteDominio);
                return RedirectToAction("ListaParticipantes");
            }

            return View(cliente);
        }

        [HttpGet]
        //Trocar pelo ID depois. Como a lista é faze, um novo GUID é gerado a cada requisição.
        public IActionResult Editar(string CNPJ)
        {
           
            var cliente = clienteRepository.GetBy(c=>c.CNPJouCPF == CNPJ);
            var clienteVm = mapper.Map<ClienteVM>(cliente);
            return View(clienteVm);
        }


        [HttpPost]
        public IActionResult Editar(ClienteVM cliente)
        {
            if (ModelState.IsValid)
            {

                var ClienteDominio = clienteRepository.GetBy(c => c.Id == cliente.Id);

                //var ClienteDominio = mapper.Map<Cliente>(cliente);

                if (ClienteDominio.InValid)
                {
                    foreach (var item in ClienteDominio.Notifications())
                    {
                        ModelState.AddModelError(item.Key, item.Message);
                        return View(cliente);
                    }
                }

                clienteRepository.Update(ClienteDominio);
                return RedirectToAction("ListaParticipantes");
            }

            return View(cliente);
        }


        [HttpGet]
        //Trocar pelo ID depois. Como a lista é faze, um novo GUID é gerado a cada requisição.
        public IActionResult Excluir(string CNPJ)
        {
            var cliente = clienteRepository.GetBy(c => c.CNPJouCPF == CNPJ);
            clienteRepository.Delete(cliente);
            return RedirectToAction("ListaParticipantes");
        }
    }
}
