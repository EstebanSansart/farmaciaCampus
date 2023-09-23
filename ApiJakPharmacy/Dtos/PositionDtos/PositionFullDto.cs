using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PositionFullDto : PositionDto{

    [Required]
    public int Id { get; set; }
}