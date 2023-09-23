using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ProviderDto{
    [Required]
    public int ProviderTypeId { get; set; }
    [Required]
    public int PersonId { get; set; }
}