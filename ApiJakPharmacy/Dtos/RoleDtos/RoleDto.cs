using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class RoleDto{
    [Required]
    public string Description { get; set; }
}