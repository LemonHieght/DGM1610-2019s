using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    public string  stopLight;
    public bool isUtah = true;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stopLight == "Red")
        {
            if(isUtah)
            {
                print("Stop or get off the road you youngans!");
            }
            else
            {
                print("???");
            }
        }
        else if(stopLight == "Yellow")
        {
           if(isUtah)
           {
                print("Slow down you hoolagan!");
           }
           else
            {
                print("???");
            }
        }
        else if(stopLight == "Green")
        {
           if(isUtah){
                print("Drive forward and get off the cell phone you hippy!");
           }
           else
            {
                print("???");
            }
        }
        else
        {
            print("FOOl!  Why did you come here??  Get out while you can!");
        }
    
    }
}
