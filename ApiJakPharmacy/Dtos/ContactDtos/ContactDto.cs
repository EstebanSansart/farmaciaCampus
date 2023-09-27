using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ContactDto{

    [Required]
    public string Description { get; set; }
    [Required]
    public int PersonId { get; set; }
    [Required]
    public int ContactTypeId { get; set; }
    [Required]
    public int ContactCategoryId { get; set; }
}