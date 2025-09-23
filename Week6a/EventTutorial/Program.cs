using System;
using EventTutorial;

public class Program
{
    public static void Main(string[] args)
    {

        CountdownTimer timer = new CountdownTimer();

        CountdownSubscriber subscriber = new CountdownSubscriber();
        // Subscribe to the event
        timer.CountdownFinished += subscriber.OnCountdownFinished;
        // Start the countdown
        timer.StartCountdown(5); // Countdown from 5 seconds

    }
}
