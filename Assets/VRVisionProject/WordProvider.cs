using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WordProvider
{
    public static string[] wordBank = { "piano", "tiger", "horse", "sushi", "pineapple" };
    public static int wordBankIndex = 0;

    public static string getCurrentWord()
    {
        return wordBank[wordBankIndex];
    }
}
