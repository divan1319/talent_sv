
using Microsoft.EntityFrameworkCore;

public class TalentContext : DbContext{

    public TalentContext(DbContextOptions<TalentContext> options) : base(options){

    }

    public DbSet<User> Users {get;set;}
    public DbSet<Coleccion> Colecciones {get;set;}
    public DbSet<Fotos> Fotos {get;set;}

}