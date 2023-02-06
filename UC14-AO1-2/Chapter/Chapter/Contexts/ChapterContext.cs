using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext>options): base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = CYBERNOTE-13 ; initial catalog = Chapter  ; Integrated Security = true");
                //optionsBuilder.UseSqlServer("Data Source =  ;initial catlog =  ; User Id=seu_usuario;Password=sua_senha; ");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set;}

        public DbSet<Usuario> Usuarios { get; set;}
    }
}
// asad