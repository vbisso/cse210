using Develop04;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private string _prompt;
    private List<string> _questions = new List<string>();
    private string _question;

    public Reflection(string activityName, string activityDescription, int activityDuration, List<string> prompts, List<string> questions) : base(activityName, activityDescription, activityDuration)
    {
        _prompts = prompts;
        _prompt = "";
        _questions = questions;
        _question = "";
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }


    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue...");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each questions as they related to this experience.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            Console.Write($"You may begin in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }


    public string GetRandomQuestion(){
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        _question = _questions[randomIndex];
        return _question;
    }

    public void DisplayQuestion(){

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while(DateTime.Now < endTime){
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(7);
        }

    }


}

