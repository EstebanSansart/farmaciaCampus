using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class MedicineDto{
    [Required]
    public DateTime CreationDate { get; set; }
    [Required]
    public DateTime ExpirationDate { get; set; }
    [Required]
    public int MedicineInfoId { get; set; }
    [Required]
    public int StateId { get; set; }
}