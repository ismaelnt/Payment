namespace Payment.Domain.Entities;

public class CreditCardPayment : Payment
{
    public CreditCardPayment(
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        string document,
        string address,
        string cardHolderName,
        string cardNumber,
        string lastTransactionNumber
    ) : base(paidDate, expireDate, total, totalPaid, payer, document, address)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; set; }
    public string CardNumber { get; set; }
    public string LastTransactionNumber { get; set; }
}