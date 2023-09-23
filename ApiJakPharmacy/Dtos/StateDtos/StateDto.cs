using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class StateDto{
    [Required]
    public string Name { get; set; }
}