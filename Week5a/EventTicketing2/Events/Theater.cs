namespace EventTicketing.Events;


public class Theater : Event 
{
    public Theater(string name, int capacity) : base(name, capacity) 
    {}
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Theater: {Name}, Capacity: {Capacity}");
    }   
}