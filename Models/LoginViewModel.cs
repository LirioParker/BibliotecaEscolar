using System.ComponentModel.DataAnnotations;

namespace BibliotecaEscolar.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O nome de usuario e obrigatorio.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A senha e obrigatoria.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
