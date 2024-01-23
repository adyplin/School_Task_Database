using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Entities;

public class CompanyEntity
{
    [Key]
    public int CompanyId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string CompanyName { get; set; } = null!;

}
