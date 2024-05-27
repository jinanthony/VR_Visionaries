using System;
using System.Collections.Generic;

public static class WordProvider
{
    private static List<string> words = new List<string> { "pi-a-no", "ti-ger", "su-shi", "horse", "pine-ap-ple" };
    private static int currentIndex = 0;

    // Returns the current word as a string
    public static string GetCurrentWord()
    {
        if (currentIndex < words.Count)
        {
            return words[currentIndex].Replace("-", "");
        }
        else
        {
            return null; // Or handle as per your requirement
        }
    }

    // Increments the counter to the next word
    public static void IncrementWord()
    {
        if (currentIndex < words.Count - 1)
        {
            currentIndex++;
        }
        else
        {
            currentIndex = 0; // Or handle as per your requirement (e.g., wrap around or do nothing)
        }
    }

    // Returns the current word as a list of syllables
    public static List<string> GetSyllables()
    {
        string currentWord = GetCurrentWordWithSyllables();
        if (currentWord != null)
        {
            return SplitIntoSyllables(currentWord);
        }
        else
        {
            return new List<string>();
        }
    }

    // Gets the current word with syllables
    private static string GetCurrentWordWithSyllables()
    {
        if (currentIndex < words.Count)
        {
            return words[currentIndex];
        }
        else
        {
            return null; // Or handle as per your requirement
        }
    }

    // Splits the word into syllables based on the provided hyphens
    private static List<string> SplitIntoSyllables(string word)
    {
        return new List<string>(word.Split('-'));
    }
}