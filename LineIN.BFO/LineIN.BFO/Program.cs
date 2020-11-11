using LineIN.BFO.Data;
using LineIN.BFO.Interfaces;
using LineIN.BFO.Models;
using LineIN.BFO.Repositorys;
using System;

namespace LineIN.BFO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DbContextBFO ctx = new DbContextBFO();

            IVendaRepository vendaRepository = new VendaRepository(ctx);
            var venda = CriarVenda();
            vendaRepository.Insert(venda);

           // IParticipanteRepository participanteRepository = new ParticipanteRepository(ctx);
           // var participante = participanteRepository.GetAll();
        }
           

        static Venda CriarVenda()
        {
            var participante = Participante.New(
                             cnpjOucpf: "58981945000111",
                             nome: "Escritório Contábil NovaTiete S/S Ltda",
                             email: "contato@novatiete.com.br",
                             Endereco.New(
                                 municipio: "Tiete",
                                 logradouro: "Rua Tenente Gelas",
                                 numero: "1442",
                                 bairro: "Centro",
                                 cep: "18530000",
                                 uf: "SP",
                                 complemento: "nulo")
                         );

            var venda = new Venda("100", participante, 1500.20M);

            venda.AddParcelas(DateTime.Now, 500M);
            venda.AddParcelas(DateTime.Now.AddDays(25), 500M);
            venda.AddParcelas(DateTime.Now.AddDays(50), 500M);

            return venda;
        }

       

        static void CriarParticipanteSucesso()
        {
                var participante = Participante.New(
                               cnpjOucpf: "58981945000111",
                               nome: "Escritório Contábil NovaTiete S/S Ltda",
                               email: "contato@novatiete.com.br",
                               Endereco.New(
                                   municipio: "Tiete",
                                   logradouro: "Rua Tenente Gelas",
                                   numero: "1442",
                                   bairro: "Centro",
                                   cep: "18530000",
                                   uf: "SP",
                                   complemento: "nulo")
                           );

                if (participante.Valid)
                {
                    Console.WriteLine("Participante Sucesso");
                }
                else
                {
                Console.WriteLine("Participante Erro: ");
                foreach (var item in participante.Notifications())
                    {
                        Console.WriteLine($"{item.Key} e {item.Message}");
                    }
                }

                Console.ReadLine();
         
        }
        static void CriarParticipanteErro()
        {
            var participante = Participante.New(
                               cnpjOucpf: "58981945000211",
                               nome: "Escritório Contábil NovaTiete S/S Ltda",
                               email: "contato@novatiete.com.br",
                               Endereco.New(
                                   municipio: "Tiete",
                                   logradouro: "Rua Tenente Gelas",
                                   numero: "1442",
                                   bairro: "Centro",
                                   cep: "18530000",
                                   uf: "SP",
                                   complemento: "nulo")
                           );

            if (participante.Valid)
            {
                Console.WriteLine("Participante Sucesso");
            }
            else
            {
                Console.WriteLine("Participante Erro: ");
                foreach (var item in participante.Notifications())
                {
                    Console.WriteLine($"{item.Key} e {item.Message}");
                }
            }

            Console.ReadLine();
        }
    }
}
