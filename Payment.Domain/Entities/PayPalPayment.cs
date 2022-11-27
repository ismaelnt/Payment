namespace Payment.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        string document,
        string address,
        string email,
        string transactionCode
    ) : base(paidDate, expireDate, total, totalPaid, payer, document, address)
    {
        Email = email;
        TransactionCode = transactionCode;
    }

    public string Email { get; set; }
    public string TransactionCode { get; set; }
}