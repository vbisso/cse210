public class Word
{
    private string _word;
    private bool _wordState;

    //constructor
    public Word(string word)
    {
        _word = word;
        _wordState = false; //false = shown, true = hidden
    }

    public void Hide()
    {
        _wordState = true;//it hides the word
    }

    public bool IsHidden()
    { //checks if the word is hidden
        return _wordState; // true = hidden, false = shown
    }

    public string GetRenderedText()
    {
        string renderedText = "";
        if (_wordState)
        { //If the word is hidden (wordState == true), return "_"



            foreach (char c in _word)
            {
                renderedText += "_";
            }

        }
        else
        {
            return _word; //if the word is not hidden (wordState == false), return the word
        }
        return renderedText;
    }



}