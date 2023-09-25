using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ContactTypeFullDto : ContactDto{

    [Required]
    public int Id { get; set; }
}