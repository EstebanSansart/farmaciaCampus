using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class SaleFullDto : SaleDto{

    [Required]
    public int Id { get; set; }
}