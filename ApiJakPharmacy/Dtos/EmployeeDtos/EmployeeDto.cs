using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class EmployeeDto{

    [Required]
    public int PositionId { get; set; }
    [Required]
    public int PersonId { get; set; }
}