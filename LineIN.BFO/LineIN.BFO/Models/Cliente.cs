using LineIN.BFO.Helpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineIN.BFO.Models
{

    public class Cliente : Entity
    {
        public string CNPJouCPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente()
        {
           
        }

        private Cliente(string cnpjOucpf, string nome, string email, Endereco endereco)
        {
            if (!cnpjOucpf.IsValidCnpjOuCpf())
            {
                AddNotification(Key: "erro", "CNPJ inválido");
            }

            CNPJouCPF = cnpjOucpf;
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }

        public static Cliente New(string cnpjOucpf, string nome, string email, Endereco endereco)
        {
            return new Cliente(cnpjOucpf, nome, email, endereco);
        }

      


    }

}
