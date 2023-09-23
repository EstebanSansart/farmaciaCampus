using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ProviderTypeFullDto : ProviderTypeDto{

    [Required]
    public int Id { get; set; }
}