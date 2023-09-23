using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class DepartmentFullDto : DepartmentDto{

    [Required]
    public int Id { get; set; }
}