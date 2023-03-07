using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAPI.Models;

[Table("tb_m_productline")]
public class ProductLines
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("Name"), MaxLength(255)]
    public string Name { get; set; }
}
