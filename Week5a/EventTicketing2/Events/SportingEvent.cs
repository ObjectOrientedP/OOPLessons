namespace EventTicketing.Events;


public class SportingEvent : Event 
{
    public SportingEvent(string name, int capacity) : base(name, capacity) 
    {}

    public override void DisplayDetails()
    {
        Console.WriteLine($"Sporting Event: {Name}, Capacity: {Capacity}");
    }

}