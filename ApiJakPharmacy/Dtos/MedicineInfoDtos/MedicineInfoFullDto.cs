using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class MedicineInfoFullDto : MedicineInfoDto{

    [Required]
    public int Id { get; set; }
}