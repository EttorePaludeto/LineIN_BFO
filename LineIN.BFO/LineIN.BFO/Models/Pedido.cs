using System;
using System.Collections.Generic;

namespace LineIN.BFO.Models
{
    public class Pedido : Entity
    {
        public string SeuNumero { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public CondicaoPagamento CondicaoPagamento { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        private Pedido()
        {
            Parcelas = new List<Parcelas>();
        }
    }


}
