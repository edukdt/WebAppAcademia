using System.ComponentModel.DataAnnotations;

namespace WebAppAcademia.Models
{
    public class TraineeModel
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
