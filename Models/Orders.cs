namespace projectAPI.Models;


public class Orders
{
    public int Id { get; set; }
    public int Customer_Id { get; set; }
    public DateTime OrderDate { get; set;}
    public DateTime RequiredDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public int Status { get; set; }
    public string Comments { get; set; }
}
