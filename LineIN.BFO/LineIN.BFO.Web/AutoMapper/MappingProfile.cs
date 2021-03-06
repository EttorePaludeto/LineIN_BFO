﻿using AutoMapper;
using LineIN.BFO.Models;
using LineIN.BFO.Web.Models;

namespace LineIN.BFO.Web.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ParticipanteVM, Participante>().ReverseMap();
            CreateMap<EnderecoVM, Endereco>().ReverseMap();
            CreateMap<VendaVM, Venda>().ReverseMap();
            CreateMap<VendaParcelaVM, VendaParcela>().ReverseMap();

        }
    }
}
