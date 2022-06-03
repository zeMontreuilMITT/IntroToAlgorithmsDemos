using System.Text;

string testSentences = "the quick brown fox jumped. the lazy dog did not.";
Console.WriteLine(CapitalizeSentenceStarts(testSentences));
Console.WriteLine(CapitalizeEveryWordStart(testSentences));

Console.WriteLine(ReverseString(testSentences));
Console.WriteLine(ReverseWordOrder(testSentences));

string CapitalizeSentenceStarts(string sentences)
{
    string[] sentenceArray = sentences.Split('.');

    for (int i = 0; i < sentenceArray.Length; i++)
    {
        if(sentenceArray[i].Length > 0)
        {
            string sentence = sentenceArray[i].Trim();
            // get the first letter of the array
            char firstLetter = sentence.ToCharArray()[0];
            sentence  = sentence.Remove(0, 1);
            sentence = sentence.Insert(0, Char.ToUpper(firstLetter).ToString());
            sentenceArray[i] = sentence.Insert(sentence.Length, ".");
        }
    }

    return String.Join(' ', sentenceArray);
}

// capitalize every word in a string
string CapitalizeEveryWordStart(string sentences)
{
    string[] words = sentences.Split(' ');

    for(int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        char firstLetter = word.ToCharArray()[0];
        word = word.Remove(0, 1);
        word = word.Insert(0, Char.ToUpper(firstLetter).ToString());
        words[i] = word;
    }

    return String.Join(' ', words);
}

// Reverse a string with a for-loop
string ReverseString(string toReverse)
{
    StringBuilder sb = new StringBuilder();

    for(int i = toReverse.Length - 1; i >= 0; i--)
    {
        sb.Append(toReverse[i]);
    }

    return sb.ToString();
}

string ReverseWordOrder(string toReverse)
{
    string[] words = toReverse.Split(' ');
    StringBuilder sb = new StringBuilder();

    for(int i = words.Length - 1; i >= 0; i--)
    {
        string word = words[i];

        if(word[word.Length - 1] == '.')
        {
            word = word.Substring(word.Length - 1);
            word.Prepend('.');
            sb.Append(word);
        } else
        {
            sb.Append($"{word} ");
        }

    }

    return sb.ToString();
}