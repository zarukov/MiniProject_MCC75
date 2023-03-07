using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_MCC75.Models;

[Table("tb_m_product")]
public class Product
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("productline_id")]
    public int ProductlineId { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }
    [Required, Column("scale")]
    public int Scale { get; set; }
    [Required, Column("vendor"), MaxLength(255)]
    public string Vendor { get; set; }
    [Required, Column("pdt_description"), MaxLength(255)]
    public string PdtDesc { get; set;}
    [Required, Column("qtyinstock")]
    public int QtyInStock { get; set; }
    [Required, Column("buyprice")]
    public int BuyPrice { get;set; }
    [Required, Column("msrp"), MaxLength(255)]
    public string Msrp { get; set; }
}
