using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table("tb_nha_order")]
public class Order
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("customer_id")]
    public int CustomerId { get; set; }
    [Required, Column("order_date")]
    public DateTime OrderDate { get; set;}
    [Required, Column("required_date")]
    public DateTime RequiredDate { get; set; }
    [Required, Column("shipped_date")]
    public DateTime ShippedDate { get; set; }
    [Required, Column("status")]
    public int Status { get; set; }
    [Column("comment"), MaxLength(255)]
    public string? Comments { get; set; }

    //relasi & kardinalitas
    [JsonIgnore]
    public ICollection<OrderProduct>? OrderProducts { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(CustomerId))]
    public Customer? Customer { get; set; }
}
