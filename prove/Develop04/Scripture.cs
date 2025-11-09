public class Scripture
{
    private List<Word> _words = new();
    private Reference _reference;
    public Scripture(Reference reference, string scriptureText)
    {
        string[] parts = scriptureText.Split();
        foreach (string part in parts)
        {
            Word word = new(part);
            _words.Add(word);
        }
        _reference = reference;
    }
    public void HideRandomWords(int number)
{
    Random random = new();
    List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
    int count = Math.Min(number, visibleWords.Count);

    for (int i = 0; i < count; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index);
    }
}
    public void RenderScripture()
    {
        _reference.DisplayString();
        foreach (Word word in _words)
        {
            word.RenderWord();
        }
    }
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

}