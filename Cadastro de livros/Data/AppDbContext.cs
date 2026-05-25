using Microsoft.EntityFrameworkCore;
using CadastroDeLivros.Models;

namespace CadastroDeLivros.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Livro> Livros { get; set; }
}