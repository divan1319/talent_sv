using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Talent_SV.Models{
public class Coleccion {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required]
    [StringLength(100)]
    public string Nombre {get;set;} 

    [Required]
    [StringLength(255)]
    public string Descripcion {get;set;}
    
    [Required]
    [StringLength(500)]
    public string CoverImage {get;set;}

    public int UserId {get;set;}

    [ForeignKey("UserId")]
    public virtual User User {get; set;}

    public virtual ICollection<Foto> Fotos {get;set;}

}
}
