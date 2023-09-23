using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class CategoryDto{

    [Required]
    public string Name { get; set; }
}