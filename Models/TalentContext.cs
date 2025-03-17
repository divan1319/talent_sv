
using Microsoft.EntityFrameworkCore;

public class TalentContext : DbContext{

    public TalentContext(DbContextOptions<TalentContext> options) : base(options){

    }
    
    

}