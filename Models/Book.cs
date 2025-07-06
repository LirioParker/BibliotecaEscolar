using System.ComponentModel.DataAnnotations;

namespace BibliotecaEscolar.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Porfavor preencha o campo titulo.")]
        [StringLength(70, ErrorMessage = "O titulo deve ter no maximo 70 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Porfavor preencha o campo Classe.")]
        public string Classe { get; set; }

        [Required(ErrorMessage = "Porfavor preencha o campo Autor")]
        public string Autor { get; set; }
        
        [Required(ErrorMessage ="Porfavor preencha o campo Ano")]
        [Range(1900, 2100, ErrorMessage = "Ano inválido")]
        public int Ano { get; set; }
        
        [Required(ErrorMessage = "Porfavor preencha o Campo Genero")]
        public string Genero { get; set; } 
    }
}