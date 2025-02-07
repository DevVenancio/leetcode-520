namespace ConsoleApp1;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int count = 0;
        
        for (int i = 0 ; i < word.Length ; i++)
        {
            if (char.IsUpper(word[i]))
                count++;
        }

        if (count == word.Length)
            return true;

        if (char.IsUpper(word[0]) && count == 1)
            return true;

        if (count == 0)
            return true;

        return false;

    }
}