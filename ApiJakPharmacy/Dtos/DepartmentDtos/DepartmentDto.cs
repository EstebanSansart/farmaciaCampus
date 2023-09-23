using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class DepartmentDto{

    [Required]
    public string Name { get; set; }
    [Required]
    public int CountryId { get; set; }
}