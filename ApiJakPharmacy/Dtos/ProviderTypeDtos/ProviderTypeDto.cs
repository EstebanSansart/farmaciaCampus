using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ProviderTypeDto{
    [Required]
    public string Name { get; set; }
}