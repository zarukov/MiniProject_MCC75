using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_MCC75.Models;

[Table("tb_nha_employee")]
public class Employee
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("office_code")]
    public int OfficeCode { get; set; }
    [Column("reports_to")]
    public int ReportsTo { get; set; }
    [Required, Column("first_name"), MaxLength(255)]
    public string FirstName { get; set; }
    [Column("last_name"), MaxLength(255)]
    public string? LastName { get; set; }
    [Required, Column("extension")]
    public int Extension { get; set; }
    [Required, Column("email"), MaxLength(255)]
    public string Email { get; set; }
    [Required, Column("job_title"), MaxLength(255)]
    public string JobTitle { get; set; }
}
