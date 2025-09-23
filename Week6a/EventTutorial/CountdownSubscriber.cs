using System;

namespace EventTutorial

{
    // Subscriber class
    public class CountdownSubscriber
    {
        // Method that will be called when the event is raised
        public void OnCountdownFinished(object sender, CountdownEventArgs e)
        {
            Console.WriteLine($"Countdown started with {e.InitialTime} seconds.");
            Console.WriteLine("The countdown has finished!");
        }
    }
}