using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class MedicineBrandFullDto : MedicineBrandDto{

    [Required]
    public int Id { get; set; }
}