using System.ComponentModel.DataAnnotations.Schema;

namespace projectAPI.Models;

[Table("tb_tr_order_product")]
public class OrderProducts
{
    public int Id { get; set; }
    public int Order_Id { get; set; }
    public int Product_Id { get; set; }
    public int Quantity { get; set; }
    public int price_each { get; set; }
}
