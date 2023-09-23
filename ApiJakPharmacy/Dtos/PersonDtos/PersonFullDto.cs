using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PersonFullDto : PersonDto{

    [Required]
    public int Id { get; set; }
}