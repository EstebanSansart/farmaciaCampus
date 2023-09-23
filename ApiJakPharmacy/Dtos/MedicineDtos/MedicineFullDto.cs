using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class MedicineFullDto : MedicineDto{

    [Required]
    public int Id { get; set; }
}