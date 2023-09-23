using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class StateFullDto : StateDto{

    [Required]
    public int Id { get; set; }
}