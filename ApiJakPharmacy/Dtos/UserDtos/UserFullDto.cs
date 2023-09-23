using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class UserFullDto : UserDto{

    [Required]
    public int Id { get; set; }
}