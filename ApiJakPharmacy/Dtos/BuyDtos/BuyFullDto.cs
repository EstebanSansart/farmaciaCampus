using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class BuyFullDto : BuyDto{

    [Required]
    public int Id { get; set; }
}