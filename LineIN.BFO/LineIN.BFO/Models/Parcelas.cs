using System;

namespace LineIN.BFO.Models
{
    public class Parcelas : Entity
    {
        public int NumeroParcela { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
    }


}
