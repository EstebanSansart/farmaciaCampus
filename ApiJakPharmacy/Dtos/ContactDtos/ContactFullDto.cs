using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class ContactFullDto : ContactDto{

    [Required]
    public int Id { get; set; }
}