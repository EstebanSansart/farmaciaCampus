using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class UserSignup: UserLoggin{
    [EmailAddress]
    [Required(ErrorMessage = "el campo email es requerido!")]
    public string Email { get; set; }

    [Required(ErrorMessage ="el numero de identificacion del usuario es requerido!")]
    public int DocumentNumber { get; set; }
}