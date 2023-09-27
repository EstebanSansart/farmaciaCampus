using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class EpsDto{
    [Required]
    public int EpsTypeId { get; set; }
    [Required]
    public int PersonId { get; set; }
}