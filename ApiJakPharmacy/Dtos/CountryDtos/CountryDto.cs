using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class CountryDto{

    [Required]
    public string Name { get; set; }
}