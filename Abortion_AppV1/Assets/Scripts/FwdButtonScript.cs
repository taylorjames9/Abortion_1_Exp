using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FwdButtonScript : MonoBehaviour {


		public TextManagerScript textManagerScript_2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnMouseUp() { 
		
				if (textManagerScript_2.textPlace < textManagerScript_2.textList.Count -1) {
						textManagerScript_2.TextPlace = textManagerScript_2.textPlace + 1;
						print ("We inside the forward button");
				} else
						textManagerScript_2.TextPlace = 0;

		}
}
