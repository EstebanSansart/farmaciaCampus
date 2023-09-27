using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ProviderDto{
    [Required]
    public string Name { get; set; }
    [Required]
    public int ProviderTypeId { get; set; }
    [Required]
    public int PersonId { get; set; }
}