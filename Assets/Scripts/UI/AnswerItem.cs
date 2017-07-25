using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerItem : MonoBehaviour {

	public Image background;
	public ChessType curType = ChessType.Black;
	public int index;
	public int row;
	public int col;
	LineType curLineType = LineType.None;
	public Image leftLine;
	public Image rightLine;
	public Image upLine;
	public Image downLine;
	public Sprite blackSprite;
	public Sprite whiteSprite;

	// Use this for initialization
	void Start () {
		row = index / 3;
		col = index % 3;
	}
	
	public void setType(ChessType t) {
		curType = t;
		if (curType == ChessType.Black)
			background.sprite = blackSprite;
		else
			background.sprite = whiteSprite;
	}

	public void setLineType(LineType type) {
		curLineType = type;
		switch (curLineType) {
		case LineType.UpDown:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (true);
			downLine.gameObject.SetActive (true);
			break;
		case LineType.LeftRight:
			leftLine.gameObject.SetActive (true);
			rightLine.gameObject.SetActive (true);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (false);
			break;
		case LineType.UpLeft:
			leftLine.gameObject.SetActive (true);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (true);
			downLine.gameObject.SetActive (false);
			break;
		case LineType.UpRight:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (true);
			upLine.gameObject.SetActive (true);
			downLine.gameObject.SetActive (false);
			break;
		case LineType.DownRight:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (true);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (true);
			break;
		case LineType.DownLeft:
			leftLine.gameObject.SetActive (true);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (true);
			break;
		case LineType.OnlyLeft:
			leftLine.gameObject.SetActive (true);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (false);
			break;
		case LineType.OnlyRight:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (true);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (false);
			break;
		case LineType.OnlyUp:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (true);
			downLine.gameObject.SetActive (false);
			break;
		case LineType.OnlyDown:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (true);
			break;
		case LineType.None:
			leftLine.gameObject.SetActive (false);
			rightLine.gameObject.SetActive (false);
			upLine.gameObject.SetActive (false);
			downLine.gameObject.SetActive (false);
			break;
		default:
			break;
		}
	}
}
