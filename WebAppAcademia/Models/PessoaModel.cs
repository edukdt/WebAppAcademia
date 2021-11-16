using System.ComponentModel.DataAnnotations;

namespace WebAppAcademia.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
