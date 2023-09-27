using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class MedicineInfoDto{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public int Price { get; set; }
    [Required]
    public int Discount { get; set; }
    [Required]
    public bool NeedOrder { get; set; }
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public int PresentationId { get; set; }
    [Required]
    public int MedicineBrandId { get; set; }
}