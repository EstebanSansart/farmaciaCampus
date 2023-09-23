using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class AddRolDto{
    [Required]    
    public string Username { get; set; } = null!;

    [Required]    
    public string Password { get; set; } = null!;

    [Required]    
    public string Rol { get; set; } = null!;
}