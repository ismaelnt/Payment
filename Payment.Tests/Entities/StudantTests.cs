using Payment.Domain.Entities;

namespace Payment.Tests.Entities;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var subscription = new Subscription(null);
        var student = new Student("Ismael", "Neto", "10650608402", "ismaent97@gmail.com");
        student.AddSubscription(subscription);
    }
}