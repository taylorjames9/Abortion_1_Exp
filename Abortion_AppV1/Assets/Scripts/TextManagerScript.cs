using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextManagerScript : MonoBehaviour {

		public TextMesh my3DTextObject;

		public List<string> textList = new List<string>();

		public static int textPlace;






	// Use this for initialization
	void Start () {
	
				textList.Add ("One Abortion.");
				textList.Add ("Chapter 1: The Test");
				textList.Add ("Lorem ipsum dolor sit amet, posuere turpis, at nam, viverra morbi imperdiet condimentum praesent eget donec, viverra consequat");
				textList.Add ("Nonummy placerat ut sed ipsum dignissim. Dui imperdiet, at in nullam suspendisse, wisi consequat convallis wisi aliquam, nec et elementum in feugiat vel tempor. Sodales enim ultricies donec.");
				textList.Add ("Chapter 2: The Judge");
				textList.Add ("Id qui risus. Ac non et eget id faucibus, dapibus tincidunt. Sed tempor faucibus condimentum,");
				textList.Add ("Mi lobortis facilisi mauris vulputate, orci ipsum vel mi massa, ullamcorper nulla, in dui quisque quisque at mauris ac, nulla purus. Sed nec, magna lorem consectetuer justo quis metus, neque eu suspendisse. Suscipit elit massa nec, laoreet varius morbi velit et lorem elit, cursus imperdiet aliquet");
				textList.Add ("Chapter 3: The Parents");
				textList.Add ("Id qui risus. Ac non et eget id faucibus, dapibus tincidunt. Sed tempor faucibus condimentum,");
				textList.Add ("Sed nec, magna lorem consectetuer justo quis metus, neque eu suspendisse. Suscipit elit massa nec, cursus imperdiet aliquet");
				//textList.Add ("Chapter 2: The Parents");


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
