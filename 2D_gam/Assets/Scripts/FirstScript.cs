using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour {

    public int WaterBottle = 60;
    
	// Use this for initialization
	void Start () {
		print(WaterBottle);
        Debug.Log(WaterBottle);
	}
	
	// Update is called once per frame
	void Update () {
        print(WaterBottle += 12);
	}
}
