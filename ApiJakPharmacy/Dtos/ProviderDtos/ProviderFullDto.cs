using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ProviderFullDto : ProviderDto{

    [Required]
    public int Id { get; set; }
}