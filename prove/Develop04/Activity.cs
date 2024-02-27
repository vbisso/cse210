namespace Develop04;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public  Activity(string name, string description, int duration)
    {
        _activityName = name;
        _activityDescription = description;
        _activityDuration = duration;
    }

    public void SetAcitivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }


    public string DisplayStartingMessage()
    {
        return $"Welcome to the {_activityName}!\n{_activityDescription}";
    }

    public void DisplayGetReady(){
        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);

    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nWell Done!!");
        ShowSpinner(3);
        Console.WriteLine( $"You have completed another {_activityDuration} seconds of the {_activityName}!");
        ShowSpinner(3);
    }



    public void ShowSpinner(int spinTime)
    {
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinTime);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        }
        Console.WriteLine();
    }
}



