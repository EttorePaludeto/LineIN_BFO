
using System;
using System.ComponentModel.DataAnnotations;

namespace LineIN.BFO.Web.Models
{

    public class ParticipanteVM 
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "CNPJ é Campo Obrigatório")]
        public string CNPJouCPF { get; set; }
        [Required(ErrorMessage = "NOME é Campo Obrigatório")]
        public string Nome { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "ENDEREÇO é Obrigatório")]
        public EnderecoVM Endereco { get; set; }

        public ParticipanteVM()
        {
            Endereco = new EnderecoVM();
        }



    }



}
