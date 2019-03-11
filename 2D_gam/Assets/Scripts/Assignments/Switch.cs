using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string suspect;
    public string weapon;
    public string room;
    public string victim;

    
    
    // Start is called before the first frame update
    void Start()
    {
        murderMystery(suspect, weapon);
    }
    void murderMystery(string person, string weapon)
    {
        switch(person)
        {
            case "Mulch":
                print("Where's my Lawer!  I won't Talk until he's here.");
                break;
            case "Zonphone":
                print("Bro, why the harsh mellow.  You know I was with Mulch in the game room, Brah.");
                break;
            case "Philbert":
                print("I do say Detective, I was in the shower when you all got here.");
                break;
            case "ItsMe":
                print("I don't Know who's done it, but I did see Phibert leaving the kitchen at the time.");
                break;
            case "Sherlly":
                print("What's happening?  All i know is I was cooking and then the police suddenly came knocking on the door.");
                break;
            default:
                print("I'm not familiar with "+suspect+".");
                break;
        }
    }
}
