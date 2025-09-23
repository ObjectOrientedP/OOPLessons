namespace EventTicketing.Events;

public class Concert : Event 
{
    public Concert(string name, int capacity) 
    : base(name, capacity) {}

    public override void DisplayDetails()
    {
        Console.WriteLine($"Concert: {Name}, Capacity: {Capacity}");
    }

}