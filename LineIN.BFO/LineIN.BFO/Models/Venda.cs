using System;
using System.Collections.Generic;
using System.Linq;

namespace LineIN.BFO.Models
{
    public class Venda : Entity
    {
        public string SeuNumero { get; set; }
        public Guid ParticipanteId { get; set; }
        public Participante Participante { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; private set; }
        public List<VendaParcela> Parcelas { get; set; }

        private Venda()
        {
            Parcelas = new List<VendaParcela>();
        }

        public Venda(string seuNumero, Participante participante, decimal valor): this()
        {
            SeuNumero = seuNumero;
            Participante = participante;
            Valor = valor;
            Data = DateTime.UtcNow.AddHours(-3);
        }

        public void AddParcelas(DateTime Vencimento, decimal ValorParcela)
        {
            if (!ValidaLimiteValorPedido(ValorParcela)) return;

            var count = Parcelas.Count + 1;
            var parcela = new VendaParcela(count, Vencimento, ValorParcela);
            Parcelas.Add(parcela);
        }

        private bool ValidaLimiteValorPedido(decimal ValorParcela)
        {
            var totalParcelas = Parcelas.Sum(c => c.Valor) + ValorParcela;

            if (totalParcelas > Valor)
            {
                AddNotification("Erro", "Valor total das parcelas supera o valor do pedido");
                return false;
            }

            return true;
        }
        
    }


}
