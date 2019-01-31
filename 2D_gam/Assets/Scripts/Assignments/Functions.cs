using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
	public string weather;
	
	void Start(){
		Weather(weather);
	}
	void Weather (string weatherState){
		
		if(weatherState == "Sunny"){
			print("The sun is shinning today!");
		}
		else if(weatherState == "Raining"){
			print("It's soggy and wet today.");
		}
		else if(weatherState == "Windy"){
			print("It's Very windy today.");
		}
		else if(weatherState == "Snowy"){
			print("It's mighty snowy today.");
		}
		else if(weatherState == "Foggy"){
			print("Visability is poor do to fog.");
		}
		else{
			print ("I don't understand "+ weatherState);
		}
	}
}
