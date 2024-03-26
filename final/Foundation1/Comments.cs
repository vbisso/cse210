using System.Runtime.InteropServices;

public class Comments{
    public string _username { get; set; }
    public string _comment { get; set; }
    public Comments(string username, string comment){
        _username = username;
        _comment = comment;
    }
    
}