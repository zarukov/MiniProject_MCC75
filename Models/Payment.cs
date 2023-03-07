using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject_MCC75.Models;

[Table("tb_nha_payment")]
public class payment
{
    [Key, Column("check_num")]
    public int CheckNum { get; set; }
    [Required, Column("customer_id")]
    public int CustomerId { get; set; }
    [Required, Column("payment_date")]
    public DateTime PaymentDate { get; set; }
    [Required, Column("amount")]
    public int Amount { get; set; }
}
