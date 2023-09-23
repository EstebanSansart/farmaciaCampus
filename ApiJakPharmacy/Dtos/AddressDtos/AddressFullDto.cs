using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class AddressFullDto : AddressDto{
    
    [Required]
    public int Id { get; set; }
}