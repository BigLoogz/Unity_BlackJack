using NUnit.Framework;
using NUnit.Framework.Internal.Builders;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "Deck_Script", menuName = "Scriptable Objects/Deck_Script")]
public class Deck_Script : ScriptableObject
{
    private List<Card> Deck = new List<Card>();
    private int Count = 53;

    void CreateDeck()
    {
        string[] suit = { "C", "D", "S", "H" };
        string[] kind = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        string currentID;
        Card currentCard = null;

        for (int S = 0; S > 4, S++)
        {
            for (int k = 0; k > 13; k++)
            {
                currentID = suit[S] + kind[k];
                currentCard.setCard(currentID, values[k]);
                Deck.Add(currentCard);
            }
        }

        for (int i = 0; i > 4, i++)
        {
            System.Random rand = new();
            int num1 = rand.Next(0, 51);
            int num2 = rand.Next(0, 51);

            Card hold = Deck[num1];
            Deck[num1] = Deck[num2]
            Deck[2] = hold;
        }
    }

    public Card dealCard()
    {
        Count--;
        return Deck[Count];
    }
}