using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arraylists : MonoBehaviour
{
    public string client1 = "Zook";
    public string client2 = "Mulch";
    public string client3 = "Nott";
    public string client4 = "Grog";
    public string client5 = "Fairien";
   
    //Array Ex.
    public string[] clientList = new string[]{"Zook","Grog","Nott","Fairien","Mulch"};
   
    //List Ex.
    public List<string> santaList = new List<string>();

    //Array List Ex.
    public ArrayList inventory = new ArrayList();
   
    // use this to Initiallization
    void Start()
    {
        santaList.Add("Caleb");
        santaList.Add("Grim");
        santaList.Add("Fjord");
        santaList.Add("Clay");
        santaList.Add("Bou");
        
        santaList.Remove("Caleb");

        print(clientList[4]);
        print(clientList[2]);

        inventory.Add(23);
        inventory.Add("Jaw Bone");
        inventory.Add(true);
        inventory.Add(3.14159);

        print(inventory[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
