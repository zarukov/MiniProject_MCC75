using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniProject_MCC75.Models;

[Table ("tb_nha_customer")]
public class Customer
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("employee_id", TypeName = "nchar(3)")]
    public string EmployeeId { get; set; }
    [Required, Column("first_name"), MaxLength(255)]
    public string FirstName { get; set; }
    [Column("last_name"), MaxLength(255)]
    public string? LastName { get; set; }
    [Required, Column("phone_number"), MaxLength(255)]
    public string PhoneNumber { get; set; }
    [Required, Column("address1"), MaxLength(255)]
    public string Address1 { get; set; }
    [Column("address2"), MaxLength(255)]
    public string? Address2 { get; set; }
    [Required, Column("city"), MaxLength(255)]
    public string City { get; set; }
    [Required, Column("state"), MaxLength(255)]
    public string State { get; set; }
    [Required, Column("postal_code", TypeName = "nchar(5)")]
    public string PostalCode { get; set; }
    [Required, Column("country"), MaxLength(255)]
    public string Country { get; set; }
    [Required, Column("credit_limit"), MaxLength(255)]
    public string CreditLimit { get; set; }

    //relasi & kardinalitas
    [JsonIgnore]
    public ICollection<Order>? Orders { get; set; }
    [JsonIgnore]
    public ICollection<Payment>? Payments { get; set; }
    [JsonIgnore]
    public Employee? Employee { get; set; }
}
