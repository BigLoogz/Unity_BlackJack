using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Scriptable Objects/Card")]
public class Card : ScriptableObject // each card is an object that contians two values, the id of the card (i.e "AC" witch reprcents ace of clubs) and the acual value of the card (I.e 11)
{
    private string id = "";
    private int value = 0;


    public void setCard(string i, int val)
    {
        id = i;
        value = val;
    }

    public void changeAce() // if the total value of the hand is to high and thier is an ace, the value of the ace will swith to 1
    {
        if (value == 11)
        {
            value = 1;
        }
    }
};