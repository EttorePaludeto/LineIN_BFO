using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineIN.BFO.Web.Models
{
    [ComplexType]
    public class EnderecoVM
    {
        [Required(ErrorMessage ="MUNICÍPIO é Campo Obrigatório")]
        public string Municipio { get; set; }
        [Required(ErrorMessage = "LOGRADOURO é Campo Obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "NÚMERO é Campo Obrigatório")]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "BAIRRO é Campo Obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "CEP é Campo Obrigatório")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "UF é Campo Obrigatório")]
        public string UF { get; set; }

    }
}