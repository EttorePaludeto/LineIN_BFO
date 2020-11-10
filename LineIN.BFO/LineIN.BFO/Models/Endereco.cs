using Microsoft.EntityFrameworkCore;

namespace LineIN.BFO.Models
{
    [Owned]
    public class Endereco
    {
        public string Municipio { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }

        public static Endereco New(string municipio, string logradouro, string numero, 
            string bairro, string cep, string uf, string complemento = "")
        {
            return new Endereco
            {
                Municipio = municipio,
                Logradouro = logradouro,
                Numero = numero,
                Complemento = complemento,
                Bairro = bairro,
                CEP = cep,
                UF = uf
            };
        }
    }
}