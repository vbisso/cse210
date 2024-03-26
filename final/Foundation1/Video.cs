using System.ComponentModel.Design.Serialization;
using System.Transactions;

public class Video{

    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Comments> _comments {get; set;}
    public Video(string title, string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;

    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayVideoInfo(){
        Console.WriteLine($"{_title} by {_author}: {_length} seconds - {NumberOfComments()} comments");
        foreach(Comments comment in _comments){
            Console.WriteLine($"- {comment._username}: {comment._comment}");
        }
        Console.WriteLine();

    }
}