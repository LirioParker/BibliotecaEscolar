using System.ComponentModel.DataAnnotations;

namespace BibliotecaEscolar.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome e obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A classe e obrigatoria")]
        public string Classe { get; set; }

        [Required(ErrorMessage = "Turma e obrigatoria")]
        public string Turma { get; set; }

        [Range(7, 25, ErrorMessage = "A idade deve estar entre 7 e 25")]
        public int idade { get; set; }
        
        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
 }