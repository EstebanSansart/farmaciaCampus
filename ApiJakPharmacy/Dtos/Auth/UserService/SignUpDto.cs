using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class SignUpDto{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;    
}