using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table("tb_nha_accounts")]
public class Account
{
    [Key, Column("employee_id", TypeName = "nchar(3)")]
    public string EmployeeId { get; set; }
    [Required, Column("password"), MaxLength(255)]
    public string Password { get; set; }

    //cardinality
    [JsonIgnore]
    public ICollection<AccountRole>? AccountRoles { get; set; }
    [JsonIgnore]
    public Employee? Employee { get; set; }
}
