using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class LogginDto{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
}