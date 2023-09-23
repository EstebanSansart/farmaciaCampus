using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class EpsFullDto : EpsDto{

    [Required]
    public int Id { get; set; }
}