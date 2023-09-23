using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PersonTypeDto{
    [Required]
    public string Description { get; set; }
}