using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class calculator : MonoBehaviour {
	public float x=10f;
	public float y = 10f;
	public float lol = 10f;
	public float g=10f;
	public float G = 10f;
	public float r = 10f;
	float k = 9000000000f;
	float F;
	// Use this for initialization
	void Start () {
		
	}	
	// Update is called once per frame
	void Update () { if (Input.GetKeyDown (KeyCode.Q)) {
			print (x + y);
	} else if (Input.GetKeyDown (KeyCode.W)) {
			print (x - y);
	} else if (Input.GetKeyDown (KeyCode.A)) {
			print (x * y);
	} else if (Input.GetKeyDown (KeyCode.S)) {
			print (x / y);
	} else if (Input.GetKeyDown (KeyCode.Z)) {
			print ((x = y) * 2);
	} else if (Input.GetKeyDown (KeyCode.X)) {
			print (x * lol * y);
		}
	else if (Input.GetKeyDown (KeyCode.Space)){
		F=k*(G*g)/r*r;
			print(F);
		}
	}
}
