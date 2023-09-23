using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class AddressDto{
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public int CityId { get; set; }

    [Required]
    public int PersonId { get; set; }
}