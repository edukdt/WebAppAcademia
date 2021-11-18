using System.ComponentModel.DataAnnotations;

namespace WebAppAcademia.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }

        public string NomeCompleto { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public DateTime DataNascimento { get; set; }
        public int QuantidadeFilhos { get; set; }
    }
}
