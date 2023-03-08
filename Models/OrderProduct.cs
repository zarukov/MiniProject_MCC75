using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table("tb_nha_orderproduct")]
public class OrderProduct
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("order_id")]
    public int OrderId { get; set; }
    [Required, Column("product_id")]
    public int ProductId { get; set; }
    [Required, Column("quantity")]
    public int Quantity { get; set; }
    [Required, Column("price_each")]
    public int PriceEach { get; set; }
    //relasi
    [JsonIgnore]
    [ForeignKey(nameof(OrderId))]
    public Order? Order { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(ProductId))]
    public Product? Product { get; set; }
}
