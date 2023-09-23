using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class PersonDto{
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime RegisterDate { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
}