using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class EpsTypeFullDto : EpsTypeDto{

    [Required]
    public int Id { get; set; }
}