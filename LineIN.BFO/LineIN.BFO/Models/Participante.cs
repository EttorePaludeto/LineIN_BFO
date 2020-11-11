using LineIN.BFO.Helpers;

namespace LineIN.BFO.Models
{
    public class Participante : Entity
    {
        public string CNPJouCPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public Participante(): base()
        {
           
        }

        private Participante(string cnpjOucpf, string nome, string email, Endereco endereco)
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

        public static Participante New(string cnpjOucpf, string nome, string email, Endereco endereco)
        {
            return new Participante(cnpjOucpf, nome, email, endereco);
        }

    }

}
