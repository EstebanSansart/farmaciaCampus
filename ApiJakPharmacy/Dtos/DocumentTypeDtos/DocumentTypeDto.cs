using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class DocumentTypeDto{

    [Required]
    public string Description { get; set; }
}