using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class EpsTypeDto{
    [Required]
    public string Name { get; set; }
}