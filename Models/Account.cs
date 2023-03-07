using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table("tb_m_accounts")]
public class Account
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("password"), MaxLength(255)]
    public string Password { get; set; }

    //cardinality
    [JsonIgnore]
    public ICollection<AccountRole>? AccountRoles { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(Id))]
    public Employee? Employee { get; set; }
}
