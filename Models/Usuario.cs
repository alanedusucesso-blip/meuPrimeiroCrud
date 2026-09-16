using System.ComponentModel.DataAnnotations;

namespace meuprimeirocrud.Models
{
    public class Usuario
    {
        //[Key]
        //public int id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        public string senha { get; set; }

        public bool Ativo { get; set; }

    }
}
