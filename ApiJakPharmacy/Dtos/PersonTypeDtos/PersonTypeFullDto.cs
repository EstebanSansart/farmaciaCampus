using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PersonTypeFullDto : PersonTypeDto{

    [Required]
    public int Id { get; set; }
}