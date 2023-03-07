using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    [Required, Column("comment"), MaxLength(255)]
    public string Comments { get; set; }
}
