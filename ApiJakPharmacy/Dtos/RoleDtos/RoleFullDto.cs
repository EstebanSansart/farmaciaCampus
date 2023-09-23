using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class RoleFullDto : RoleDto{

    [Required]
    public int Id { get; set; }
}