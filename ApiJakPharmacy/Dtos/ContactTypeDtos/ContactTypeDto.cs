using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ContactTypeDto{

    [Required]
    public string Name { get; set; }
}