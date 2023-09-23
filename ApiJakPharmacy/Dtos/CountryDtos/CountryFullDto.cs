using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class CountryFullDto : CountryDto{

    [Required]
    public int Id { get; set; }
}