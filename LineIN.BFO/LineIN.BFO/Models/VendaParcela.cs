using System;

namespace LineIN.BFO.Models
{
    public class VendaParcela 
    {
        public int Id { get; private set; }
        public int NumeroParcela { get; private set; }
        public DateTime Vencimento { get; private set; }
        public decimal Valor { get; private set; }

        internal VendaParcela (int numeroParcela, DateTime vencimento, decimal valor)
        {
            NumeroParcela = numeroParcela;
            Vencimento = vencimento;
            Valor = valor;
        }
    }


}
