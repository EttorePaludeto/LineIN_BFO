using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LineIN.BFO.Web.Models
{
    public class VendaVM
    {
        [Required(ErrorMessage = "SEU-NUMERO é Campo Obrigatório")]
        public string SeuNumero { get; set; }
        public Guid ParticipanteId { get; set; }
        public ParticipanteVM Participante { get; set; }
        [Required(ErrorMessage = "VALOR é Campo Obrigatório")]
        public decimal Valor { get; set; }
        public DateTime Data { get; private set; }
        public List<VendaParcelaVM> Parcelas { get; set; }

        public List<ParticipanteVM> ListaParticipantes { get; set; }

        public VendaVM()
        {
            Parcelas = new List<VendaParcelaVM>();
            ListaParticipantes = new List<ParticipanteVM>();
        }
    }

    public class VendaParcelaVM
    {
        public int Id { get; private set; }
        public int NumeroParcela { get; private set; }
        [Required(ErrorMessage = "VENCIMENTO é Campo Obrigatório")]
        public DateTime Vencimento { get; private set; }
        [Required(ErrorMessage = "VALOR PARCELA é Campo Obrigatório")]
        public decimal Valor { get; private set; }
    }
}
