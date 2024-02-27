using Develop04;

public class Listing:Activity{
    private List<string> _prompts = new List<string>();
    private string _prompt;
    private List<string> _items = new List<string>();


    public Listing(string name, string description,int duration,List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
        _prompt = "";
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }
    public void DisplayPrompt(){
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: \n");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void ListItems(){

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while(DateTime.Now < endTime){
            Console.Write("> ");
            _items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {GetListedItems()} items!");
        
    }

    public int GetListedItems(){
        return _items.Count;
    }

}