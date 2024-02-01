using System.Reflection.Metadata;
namespace Develop02;

public class Entry{
    public string _date;
    public string _excersise;
    public string _prompt;
    public string _input;

    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date} - Exercise?: {_excersise} - Prompt: {_prompt}");
        Console.WriteLine(_input);
    }
}

