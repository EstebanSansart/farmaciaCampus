using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class AddRole{

    [Required(ErrorMessage = "Nombre de usuario Requerido!")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Se requiere especificar el rol de usuario!")]
    public string RoleName { get; set; } = String.Empty;    
}