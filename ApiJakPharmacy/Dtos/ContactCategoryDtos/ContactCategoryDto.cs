using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ContactCategoryDto{

    [Required]
    public string Name { get; set; }
}