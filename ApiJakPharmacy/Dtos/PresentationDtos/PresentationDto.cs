using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PresentationDto{
    [Required]
    public string Name { get; set; }
}