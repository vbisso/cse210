using Develop04;

public class Breathing : Activity
{
    private int _breathingIn;
    private int _breathingOut;

    public Breathing(string activityName, string activityDescription, int activityDuration, int breathingIn, int breathingOut):base(activityName, activityDescription, activityDuration)
    {
       _breathingIn = breathingIn;
       _breathingOut = breathingOut;
    }


    public void DisplayBreathingIntervals()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreathe in...");
            for (int i=_breathingIn; i>0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                if(i>9){
                    Console.Write("\b\b ");
                }
                else{
                    Console.Write("\b \b");
                }
                
            }
            Console.Write($"\nBreathe out...");
            for (int i=_breathingOut; i>0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                if(i>9){
                    Console.Write("\b\b ");
                }
                else{
                    Console.Write("\b \b");
                }
            }
            
        }

        
    }
}