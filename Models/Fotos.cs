using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Fotos{

    [Key]
    public int Id {get;set;}
    public string? Url {get;set;}
    public string? Descripcion {get;set;}

    [ForeignKey("Coleccion")]
    public int ColeccionId {get;set;}
    public Coleccion? Coleccion {get;set;}
}