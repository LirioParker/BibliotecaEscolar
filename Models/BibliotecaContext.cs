using Microsoft.EntityFrameworkCore;

namespace BibliotecaEscolar.Models
{
    public class BibliotecaContext : DbContext
    {
        // Construtor que recebe as opções (configuração) do contexto
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        // DbSet para a tabela de Livros (Books)
        public DbSet<Book> Livros { get; set; }

        // DbSet para a tabela de Alunos
        public DbSet<Aluno> Alunos { get; set; }

        // Caso queira configurar algo adicionalmente via Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Exemplo: definir nome da tabela explicitamente
            modelBuilder.Entity<Book>().ToTable("Livros");
            modelBuilder.Entity<Aluno>().ToTable("Alunos");

        }
    }
}