using System.Reflection.Metadata;
namespace Develop02;

public class Entry{

    public string _prompt;
    public string _date;
    public string _input;

    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_input);
    }
}

