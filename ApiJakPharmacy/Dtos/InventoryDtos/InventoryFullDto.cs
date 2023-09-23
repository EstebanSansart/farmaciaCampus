using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class InventoryFullDto : InventoryDto{

    [Required]
    public int Id { get; set; }
}