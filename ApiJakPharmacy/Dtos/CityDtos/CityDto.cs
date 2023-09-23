using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class CityDto{

    [Required]
    public string Name { get; set; }
    [Required]
    public int DepartmentId { get; set; }
}