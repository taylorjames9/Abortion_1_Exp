using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextManagerScript : MonoBehaviour {

	//public TextMesh my3DTextObject;
	public UILabel my3DTextObject;

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
							my3DTextObject.fontSize = 40;
						else if(textPlace == 1 || textPlace == 4 || textPlace == 7 || textPlace == 10 || textPlace == 13)
							my3DTextObject.fontSize = 30;
						else
							my3DTextObject.fontSize = 20;

						my3DTextObject.text = textList[textPlace];
						print ("TextPlace =" + TextPlace);
				}
		}


	// Use this for initialization
	void Start () {

				textList.Add ("One Abortion");
				textList.Add ("Chapter 1: The Test");
				textList.Add ("Lorem ipsum dolor sit amet, posuere turpis, at nam,  viverra morbi imperdiet condimentum praesent eget donec, viverra consequat");
				textList.Add ("Nonummy placerat ut sed ipsum dignissim. Dui imperdiet, at in nullam suspendisse, wisi consequat convallis wisi aliquam, nec et elementum in feugiat vel tempor. Sodales enim ultricies donec.");
				textList.Add ("Chapter 2: The Judge");
				textList.Add ("Id qui risus. Ac non et eget id faucibus, dapibus tincidunt. Sed tempor faucibus condimentum,");
				textList.Add ("Mi lobortis facilisi mauris vulputate, orci ipsum vel mi massa, ullamcorper nulla, in dui quisque quisque at mauris ac, nulla purus. Sed nec, magna lorem consectetuer justo quis metus, neque eu suspendisse. Suscipit elit.");
				textList.Add ("Chapter 3: The Parents");
				textList.Add ("Id qui risus. Ac non et eget id faucibus, dapibus tincidunt. Sed tempor faucibus condimentum");
				textList.Add ("Sed nec, magna lorem consectetuer justo quis metus, neque eu suspendisse. Suscipit elit massa nec, cursus imperdiet aliquet");
				textList.Add ("Chapter 4: The School");
				textList.Add ("nisi ut aliquid ex ea commodi consequatur? Quis reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?");
				textList.Add (" Neque porro quisquam est, qui dolorem ipsum quia, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.");
				textList.Add ("Chapter 5: The Boy");
				textList.Add ("Id qui risus. Ac non et eget id faucibus, dapibus tincidunt. Sed tempor faucibus condimentum,");
				textList.Add ("Mi lobortis facilisi mauris vulputate, orci ipsum vel mi massa, ullamcorper nulla.");
				textList.Add ("Add infinitum. \n \n \n          Fim");
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
