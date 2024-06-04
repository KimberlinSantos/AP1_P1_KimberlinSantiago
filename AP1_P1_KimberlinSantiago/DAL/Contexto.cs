using AP1_P1_KimberlinSantiago.Models;
using Microsoft.EntityFrameworkCore;
namespace AP1_P1_SamuelJavier.DAL;

public class Contexto : DbContext
{
    public Contexto(Microsoft.EntityFrameworkCore.DbContextOptions<Contexto> options)
        : base(options) { }

    DbSet<Articulos> Articulos { get; set; }
}