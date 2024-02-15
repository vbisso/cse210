using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;// Holds the words of the scripture
    private Reference _reference;

    //constructors:
    public Scripture(string scriptureText, Reference reference)
    {

        _reference = reference;
        _words = new List<Word>();

        string[] words = scriptureText.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideWord()
    {

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                Random random = new Random();
                if (random.Next(2) == 1)
                {
                    word.Hide();
                }
            }
        }





    }




    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            { //checks if the word is not hidden (wordState == false)
                return false; //returns false (!) because not all of the words are hidden

            }
        }
        return true; //returns true because all of the words are hidden
    }

    public string GetRenderedText()
    {
        string renderedText = "";
        foreach (Word w in _words)
        {
            renderedText += w.GetRenderedText() + " ";
        }
        return _reference.formatReference() + ":" + renderedText.Trim();

    }
}



