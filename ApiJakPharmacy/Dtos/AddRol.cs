using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class AddRol{

    [Required(ErrorMessage = "Nombre de usuario Requerido!")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Se requiere especificar el rol de usuario!")]
    public string RolName { get; set; } = String.Empty;    
}