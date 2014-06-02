using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackButtonScript : MonoBehaviour {

	public TextManagerScript textManagerScript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


		/*void OnTap(TapGesture gesture) { 

				textManagerScript.TextPlace = textManagerScript.textPlace -1;
				print ("We inside the forward button");
		}*/

		void OnMouseUp(){
		
				if (textManagerScript.textPlace > 0) {
						textManagerScript.TextPlace = textManagerScript.textPlace - 1;
						print ("We inside the forward button");
				} else
						textManagerScript.TextPlace = textManagerScript.textList.Count -1 ;
		}
}
