namespace Payment.Domain.Models;

public class Subscription
{
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? ExpireDate { get; set; }
    public bool Active { get; set; }
    public List<Payment> Payments { get; set; }
}