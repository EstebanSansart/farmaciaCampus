using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ContactCategoryFullDto : ContactCategoryDto{

    [Required]
    public int Id { get; set; }
}