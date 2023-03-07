using System.ComponentModel.DataAnnotations.Schema;

namespace projectAPI.Models;

[Table("tb_m_product")]
public class Products
{
    public int Id { get; set; }
    public int Producline_Id { get; set; }
    public string Name { get; set; }
    public int Scala { get; set; }
    public string Vendor { get; set; }
    public string Pdt_description { get; set;}
    public int Qtyinstock { get; set; }
    public int Buyprice { get;set; }
    public string Mrsp { get; set; }
}
