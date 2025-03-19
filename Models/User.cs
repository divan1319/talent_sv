using System.ComponentModel.DataAnnotations;

public class User {

    [Key]
    public int Id {get;set;}
    public string? Nombre {get;set;}
    public string? Email {get;set;}
    public string? Password {get;set;}
    public string? Avatar {get;set;}
    public DateTime FechaRegistro {get;set;}
    public bool Activo {get;set;}

    public ICollection<Coleccion>? Colecciones {get;set;}
}