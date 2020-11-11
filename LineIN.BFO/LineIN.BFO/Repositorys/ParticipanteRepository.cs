using LineIN.BFO.Data;
using LineIN.BFO.Interfaces;
using LineIN.BFO.Models;

namespace LineIN.BFO.Repositorys
{
    public class ParticipanteRepository : Repository<Participante>, IParticipanteRepository
    {

        public ParticipanteRepository(DbContextBFO context) : base(context)
        {

        }

        public void CriarListaFake()
        {
            _dbSet.Add(Participante.New(
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
                          )
            );

            _dbSet.Add(Participante.New(
                            cnpjOucpf: "033.401.138-82",
                            nome: "JOSE MOACIR MODOLO",
                            email: "contato@victorblue.com.br",
                            Endereco.New(
                                municipio: "Tiete",
                                logradouro: "RUA SANTA CRUZ",
                                numero: "670",
                                bairro: "SANTA CRUZ",
                                cep: "18530000",
                                uf: "SP",
                                complemento: "nulo")
                        )
          );

            _dbSet.Add(Participante.New(
                            cnpjOucpf: "11.017.311/0001-80",
                            nome: "PAULO ROBERTO SCHINCARIOL E OUTROS (FAZENDINHA)",
                            email: "contato@novatiete.com.br",
                            Endereco.New(
                                municipio: "Tiete",
                                logradouro: "FAZENDA RODOVIA CORNÉLIO PIRES SP 127",
                                numero: "S/N",
                                bairro: "RIO CAPIVARI",
                                cep: "18530000",
                                uf: "SP",
                                complemento: "RODOVIA")
                        )
          );

            _dbSet.Add(Participante.New(
                            cnpjOucpf: "05.437.703/0001-03",
                            nome: "CAMARGO COMPANHIA DE EMBALAGENS LTDA",
                            email: "contato@novatiete.com.br",
                            Endereco.New(
                                municipio: "Tiete",
                                logradouro: "RUA ÁLVARO CAMERIN",
                                numero: "51",
                                bairro: "DISTRITO INDUSTRIAL",
                                cep: "18530000",
                                uf: "SP",
                                complemento: "nulo")
                        )
          );
            _dbSet.Add(Participante.New(
                          cnpjOucpf: "05.437.703/0001-03",
                          nome: "CAMARGO COMPANHIA DE EMBALAGENS LTDA",
                          email: "contato@novatiete.com.br",
                          Endereco.New(
                              municipio: "Tiete",
                              logradouro: "RUA ÁLVARO CAMERIN",
                              numero: "51",
                              bairro: "DISTRITO INDUSTRIAL",
                              cep: "18530000",
                              uf: "SP",
                              complemento: "nulo")
                      )
        );
            _dbSet.Add(Participante.New(
                          cnpjOucpf: "05.437.703/0001-03",
                          nome: "CAMARGO COMPANHIA DE EMBALAGENS LTDA",
                          email: "contato@novatiete.com.br",
                          Endereco.New(
                              municipio: "Tiete",
                              logradouro: "RUA ÁLVARO CAMERIN",
                              numero: "51",
                              bairro: "DISTRITO INDUSTRIAL",
                              cep: "18530000",
                              uf: "SP",
                              complemento: "nulo")
                      )
        );
            _dbSet.Add(Participante.New(
                          cnpjOucpf: "05.437.703/0001-03",
                          nome: "CAMARGO COMPANHIA DE EMBALAGENS LTDA",
                          email: "contato@novatiete.com.br",
                          Endereco.New(
                              municipio: "Tiete",
                              logradouro: "RUA ÁLVARO CAMERIN",
                              numero: "51",
                              bairro: "DISTRITO INDUSTRIAL",
                              cep: "18530000",
                              uf: "SP",
                              complemento: "nulo")
                      )
        );
            _dbSet.Add(Participante.New(
                          cnpjOucpf: "05.437.703/0001-03",
                          nome: "CAMARGO COMPANHIA DE EMBALAGENS LTDA",
                          email: "contato@novatiete.com.br",
                          Endereco.New(
                              municipio: "Tiete",
                              logradouro: "RUA ÁLVARO CAMERIN",
                              numero: "51",
                              bairro: "DISTRITO INDUSTRIAL",
                              cep: "18530000",
                              uf: "SP",
                              complemento: "nulo")
                      )
        );
        }
    }
}
