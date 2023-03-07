using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table("tb_m_productline")]
public class ProductLine
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }

    //relasi & kardinalitas
    [JsonIgnore]
    public ICollection<Product>? Products { get; set; }
}
