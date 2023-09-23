using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PresentationFullDto : PresentationDto{

    [Required]
    public int Id { get; set; }
}