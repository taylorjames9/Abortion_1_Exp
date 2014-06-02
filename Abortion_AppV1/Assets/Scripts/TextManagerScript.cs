using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextManagerScript : MonoBehaviour {

		public TextMesh my3DTextObject;

		public List<string> textList = new List<string>();


		//enum TextSizeEnum {Title, Chapter, Reg};

		public int textPlace;

		public int TextPlace { 
				get { 
						return textPlace; 
					} 

				set {  
						textPlace = value;
				
						if(textPlace == 0)
								my3DTextObject.fontSize = 57;
						else if(textPlace == 1 || textPlace == 4 || textPlace == 7)
								my3DTextObject.fontSize = 45;
						else
								my3DTextObject.fontSize = 32;

						my3DTextObject.text = textList[textPlace];
						print ("TextPlace =" + TextPlace);
				}
		}


	// Use this for initialization
	void Start () {
				textList.Add ("One Abortion.");
				textList.Add ("Chapter 1: The Test");
				textList.Add ("Lorem ipsum dolor sit amet, \n posuere turpis, at nam, \n viverra morbi imperdiet condimentum \npraesent eget donec, viverra \nconsequat");
				textList.Add ("Nonummy placerat ut sed ipsum \ndignissim. Dui imperdiet, \nat in nullam suspendisse, wisi \nconsequat convallis wisi aliquam, \nnec et elementum in feugiat vel \ntempor. Sodales enim ultricies donec.");
				textList.Add ("Chapter 2: The Judge");
				textList.Add ("Id qui risus. Ac non et \neget id faucibus, dapibus \ntincidunt. Sed tempor faucibus \ncondimentum,");
				textList.Add ("Mi lobortis facilisi mauris \nvulputate, orci ipsum vel mi massa, \nullamcorper nulla, in dui quisque \nquisque at mauris ac, nulla \npurus. Sed nec, magna lorem \nconsectetuer justo quis metus, neque eu \nsuspendisse. Suscipit elit massa \nnec, laoreet varius morbi velit \net lorem elit, cursus imperdiet \naliquet");
				textList.Add ("Chapter 3: The Parents");
				textList.Add ("Id qui risus. Ac non et eget \nid faucibus, dapibus tincidunt. \nSed tempor faucibus condimentum");
				textList.Add ("Sed nec, magna lorem consectetuer \njusto quis metus, neque eu \nsuspendisse. Suscipit elit massa \nnec, cursus imperdiet aliquet");
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
