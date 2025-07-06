using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaEscolar.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
        {
        }

        public DbSet<Book> Livros { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}