
using Microsoft.EntityFrameworkCore;
using Talent_SV.Models;

namespace Talent_SV.Models{
public class TalentContext : DbContext{

    public TalentContext(DbContextOptions<TalentContext> options) : base(options){

    }

    public DbSet<User> Users {get;set;}
    public DbSet<Coleccion> Colecciones {get;set;}
    public DbSet<Foto> Fotos {get;set;}

}
}