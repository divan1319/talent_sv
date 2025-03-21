using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Talent_SV.Models{
public class Foto{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required]
    [StringLength(255)]
    public string Url {get;set;}

    [Required]
    [StringLength(500)]
    public string Descripcion {get;set;}

    public int ColeccionId {get;set;}

    [ForeignKey("ColeccionId")]
    public virtual Coleccion Coleccion {get;set;}

}
}