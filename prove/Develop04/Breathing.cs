using Develop04;

public class Breathing : Activity
{
    private int _breathingTime;

    public Breathing(string activityName, string activityDescription, int activityDuration):base(activityName, activityDescription, activityDuration)
    {
        _breathingTime = 0;
    }


    public void DisplayBreathingIntervals()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreathe in...");
            for (int i=4; i>0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write($"\nBreathe out...");
            for (int i=6; i>0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            

        }

        
    }
}