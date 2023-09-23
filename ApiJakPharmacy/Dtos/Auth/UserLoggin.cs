using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class UserLoggin{
    [Required(ErrorMessage = "Nombre de usuario Requerido!")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Contraseña Requerida para realizar esta accion!")]
    public string Password { get; set; }

}