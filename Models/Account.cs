using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Models
{
    [Table("tb_m_accounts")]
    public class Account
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("password"), MaxLength(255)]
        public string Password { get; set; }

        ////cardinalitty
        //[JsonIgnore]
        //public ICollection<AccountRole>? AccountRoles  { get; set; }
        //[JsonIgnore]
        //public Employee? Employee  { get; set; }
    }
}
