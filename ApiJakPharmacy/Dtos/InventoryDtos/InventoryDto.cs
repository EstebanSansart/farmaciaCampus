using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class InventoryDto{
    [Required]
    public string Ubication { get; set; }
    [Required]
    public int TotalStock { get; set; }
    [Required]
    public int MedicineInfoId { get; set; }
}