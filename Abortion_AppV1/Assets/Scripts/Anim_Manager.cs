using UnityEngine;
using System.Collections;

public class Anim_Manager : MonoBehaviour {

		private Animator animator;
		public TextManagerScript textManagerScript;

	// Use this for initialization
	void Start () {
	
				animator = this.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {


				if(textManagerScript.textPlace == 3)
						animator.SetInteger ("AnimToPlay" , 1);
				else if(textManagerScript.textPlace == 6)
						animator.SetInteger ("AnimToPlay" , 2);
				else if(textManagerScript.textPlace == 9)
						animator.SetInteger ("AnimToPlay" , 3);
				else if(textManagerScript.textPlace == 11)
						animator.SetInteger ("AnimToPlay" , 1);
				else if(textManagerScript.textPlace == 14)
			animator.SetInteger ("AnimToPlay" , 2);
				else
						animator.SetInteger ("AnimToPlay" , 0);
	
	}
}
