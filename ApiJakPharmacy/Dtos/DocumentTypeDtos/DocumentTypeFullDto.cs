using System.ComponentModel.DataAnnotations;

namespace ApiJakPharmacy.Dtos;
public class DocumentTypeFullDto : DocumentTypeDto{

    [Required]
    public int Id { get; set; }
}