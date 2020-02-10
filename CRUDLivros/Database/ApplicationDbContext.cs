using CRUDLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDLivros.Database
{
    public class ApplicationDbContext : DbContext
    {
            public DbSet<Livro> Livros {get; set;}

            public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options){}
       
    }
}