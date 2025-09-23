using System;


namespace EventTutorial {
// Define a custom EventArgs class
    public class CountdownEventArgs : EventArgs
    {
        public int InitialTime { get; set; }
    }
// Publisher class
    public class CountdownTimer
    {
        // Delegate for the event
        public delegate void CountdownFinishedEventHandler(object sender, CountdownEventArgs e);
        // Event declaration
        public event CountdownFinishedEventHandler CountdownFinished;
        public void StartCountdown(int seconds)
        {
            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine($"Time left: {i} seconds");
                System.Threading.Thread.Sleep(1000); // Simulate countdown
                if (i == 0)
                {
                    OnCountdownFinished(seconds); // Raise the event
                }
            }
        }
        // Method to raise the event
        protected virtual void OnCountdownFinished(int initialTime)
        {
            if (CountdownFinished != null) // Ensure there are subscribers
            {
                CountdownFinished(this, new CountdownEventArgs { InitialTime = initialTime });
            }
        }
    }
}
