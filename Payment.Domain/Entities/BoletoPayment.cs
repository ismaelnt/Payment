namespace Payment.Domain.Entities;

public class BoletoPayment : Payment
{
    public BoletoPayment(
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        string document,
        string address,
        string email,
        string barCode,
        string boletoNumber
    ) : base(paidDate, expireDate, total, totalPaid, payer, document, address)
    {
        Email = email;
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string Email { get; private set; }
    public string BarCode { get; private set; }
    public string BoletoNumber { get; private set; }
}