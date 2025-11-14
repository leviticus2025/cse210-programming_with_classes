public class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void RenderWord()
    {
        if (_isHidden == false)
        {
            Console.Write(_word + " ");
        }
        else
        {
            string underscore = new string('_', _word.Length);
            Console.Write(underscore + " ");
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}