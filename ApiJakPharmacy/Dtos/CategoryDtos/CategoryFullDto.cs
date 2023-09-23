using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class CategoryFullDto : CategoryDto{

    [Required]
    public int Id { get; set; }
}