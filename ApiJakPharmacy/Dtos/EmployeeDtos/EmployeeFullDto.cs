using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class EmployeeFullDto : EmployeeDto{

    [Required]
    public int Id { get; set; }
}