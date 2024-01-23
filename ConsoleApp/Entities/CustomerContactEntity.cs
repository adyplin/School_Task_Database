using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Entities;

public class CustomerContactEntity
{
    [Key, ForeignKey(nameof(CustomerEntity))]
    public int CustomerId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Email { get; set; } = null!;


    [Column(TypeName = "varchar(15)")]
    public string? PhoneNumber { get; set; }
    public virtual CustomerEntity Customer { get; set; } = null!;
}
