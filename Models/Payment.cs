using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table("tb_nha_payment")]
public class Payment
{
    [Key, Column("check_num"), MaxLength(255)]
    public string CheckNum { get; set; }
    [Required, Column("customer_id")]
    public int CustomerId { get; set; }
    [Required, Column("payment_date")]
    public DateTime PaymentDate { get; set; }
    [Required, Column("amount")]
    public int Amount { get; set; }
    //relasi
    [JsonIgnore]
    [ForeignKey(nameof(CustomerId))]
    public Customer? Customer { get; set; }
}
