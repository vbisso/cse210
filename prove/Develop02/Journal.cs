using System.Reflection.Metadata;
namespace Develop02;

public class Journal{

    public List<Entry>_entries = new List<Entry>();

    public void DisplayJournal(){
        foreach (Entry entry in _entries){
            entry.DisplayEntry();
        }

    }
    
    public void SaveCsv(string filename){

        if (!filename.ToLower().EndsWith(".csv"))
        {
        filename += ".csv";
        }

        using (StreamWriter csvFile = new StreamWriter(filename)){ 
            //csvFile.WriteLine("Date,Prompt,Input");
            foreach (Entry entry in _entries){
                csvFile.WriteLine($"{entry._date},{entry._excersise},{entry._prompt},{entry._input}");
            } 
        }
    }

}
