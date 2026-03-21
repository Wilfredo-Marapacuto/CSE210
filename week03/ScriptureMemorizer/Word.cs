public class Word
{
    private string _prefixPunctuation;
    private string _wordText;
    private string _suffixPunctuation;
    private string _hint;
    private bool _isHidden;

    public Word(string text)
        : this(text, "")
    {
    }

    public Word(string text, string hint)
    {
        _hint = hint;
        _isHidden = false;

        int start = 0;
        while (start < text.Length && !char.IsLetter(text[start]))
        {
            start++;
        }

        int end = text.Length - 1;
        while (end >= start && !char.IsLetter(text[end]))
        {
            end--;
        }

        if (start > end)
        {
            _prefixPunctuation = text;
            _wordText = "";
            _suffixPunctuation = "";
        }
        else
        {
            _prefixPunctuation = text.Substring(0, start);
            _wordText = text.Substring(start, end - start + 1);
            _suffixPunctuation = text.Substring(end + 1);
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return $"{_prefixPunctuation}{_wordText}{_suffixPunctuation}";
        }

        string hiddenWord = new string('_', _wordText.Length);

        if (!string.IsNullOrWhiteSpace(_hint))
        {
            return $"{_prefixPunctuation}{hiddenWord} ({_hint}){_suffixPunctuation}";
        }

        return $"{_prefixPunctuation}{hiddenWord}{_suffixPunctuation}";
    }
}