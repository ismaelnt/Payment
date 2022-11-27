namespace Payment.Domain.Entities;

public class Subscription
{
    private readonly IList<Payment> _payments;

    public Subscription(DateTime? expireDate)
    {
        CreateDate = DateTime.Now;
        UpdateDate = DateTime.Now;
        ExpireDate = expireDate;
        Active = true;
        _payments = new List<Payment>();
    }

    public DateTime CreateDate { get; private set; }
    public DateTime UpdateDate { get; private set; }
    public DateTime? ExpireDate { get; private set; }
    public bool Active { get; private set; }
    public IReadOnlyCollection<Payment> Payments { get; private set; }

    public void AddPayment(Payment payment)
    {
        _payments.Add(payment);
    }

    public void Activate()
    {
        Active = true;
        UpdateDate = DateTime.Now;
    }

    public void Inactivate()
    {
        Active = false;
        UpdateDate = DateTime.Now;
    }
}