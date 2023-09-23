using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class MedicineBrandDto{
    [Required]
    public string Name { get; set; }
}