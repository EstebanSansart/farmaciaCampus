using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class UserDto{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Email { get; set; }
}