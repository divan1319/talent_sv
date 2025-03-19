using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Coleccion {

    [Key]
    public int Id {get;set;}
    public string? Nombre {get;set;} 
    public string? Descripcion {get;set;}
    public string? CoverImage {get;set;}

    [ForeignKey("User")]
    public int UserId {get;set;}
    public User? User {get;set;}
    public ICollection<Fotos>? Fotos {get;set;}
}