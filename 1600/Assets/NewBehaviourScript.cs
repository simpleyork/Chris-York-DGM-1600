using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	int myInt = 5;

		// Use this for initialization
	void Start (){
		myInt = MuliplyByTwo(myInt);
		Debug.Log (myInt);
	}
	int MuliplyByTwo(int number){
		int ret;

		ret = number * 2;

		return ret;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
