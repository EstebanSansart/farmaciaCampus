using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PositionDto{
    [Required]
    public string Name { get; set; }
}