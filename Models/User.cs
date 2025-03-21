using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Talent_SV.Models{

public class User {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required]
    [StringLength(200)]
    public string Nombre {get;set;}

    [Required]
    [StringLength(200)]
    public string Email {get;set;}

    [Required]
    [StringLength(200)]
    public string Password {get;set;}

    [Required]
    [StringLength(200)]
    public string Avatar {get;set;}
    [Required]
    public DateTime FechaRegistro {get;set;}

    [Required]
    [DefaultValue(true)]
    public bool Activo {get;set;}

    public virtual ICollection<Coleccion> Coleccions {get;set;}

}
}