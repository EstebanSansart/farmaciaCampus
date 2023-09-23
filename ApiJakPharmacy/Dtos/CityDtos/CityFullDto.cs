using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class CityFullDto : CityDto{

    [Required]
    public int Id { get; set; }
}