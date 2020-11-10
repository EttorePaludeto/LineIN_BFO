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
          
        }
           

        static void CriarClienteSucesso()
        {
                var cliente = Cliente.New(
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

                if (cliente.Valid)
                {
                    Console.WriteLine("Cliente Sucesso");
                }
                else
                {
                Console.WriteLine("Cliente Erro: ");
                foreach (var item in cliente.Notifications())
                    {
                        Console.WriteLine($"{item.Key} e {item.Message}");
                    }
                }

                Console.ReadLine();
         
        }
        static void CriarClienteErro()
        {
            var cliente = Cliente.New(
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

            if (cliente.Valid)
            {
                Console.WriteLine("Cliente Sucesso");
            }
            else
            {
                Console.WriteLine("Cliente Erro: ");
                foreach (var item in cliente.Notifications())
                {
                    Console.WriteLine($"{item.Key} e {item.Message}");
                }
            }

            Console.ReadLine();
        }
    }
}
