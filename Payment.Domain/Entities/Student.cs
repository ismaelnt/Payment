namespace Payment.Domain.Entities;

public class Student
{
    private IList<Subscription> _subscriptions;

    public Student(string firstName, string lastName, string document, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Document { get; private set; }
    public string Email { get; private set; }
    public string Address { get; set; }

    public IEnumerable<Subscription> Subscriptions => _subscriptions.ToArray();

    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
            sub.Inactivate();

        _subscriptions.Add(subscription);
    }
}