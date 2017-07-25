using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SimulateItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {

	public int index = 0;
	public int row = 0;
	public int col = 0;
	public ChessType curType = ChessType.Black;
	public Image background;
	public bool isSelected = false;
	public Image selectFlag;
	public Image unSelectFlag;
	public Image leftLine;
	public Image rightLine;
	public Image upLine;
	public Image downLine;
	LineType curLineType = LineType.None;
	public Sprite normalSprite;
	public Sprite highLightSprite;
	public static int simulateWidth = 3;

	public void reset() {
		setType (ChessType.Black);
		setSelected (false);
		setUnselected (false);
		setLineType (LineType.None);
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

	public void setSelected(bool selected) {
		isSelected = selected;
		if (selected) {	
			selectFlag.enabled = true;
		} else {
			selectFlag.enabled = false;
		}
	}

	public void setUnselected(bool unselected) {
		if (unselected) {
			unSelectFlag.enabled = true;
		} else {
			unSelectFlag.enabled = false;
		}
	}

	void Start() {
		row = index / simulateWidth;
		col = index % simulateWidth;
	}

	public void setType(ChessType t) {
		curType = t;
		if (curType == ChessType.Black)
			background.sprite = normalSprite;
		else
			background.sprite = highLightSprite;
	}

	public void Convert() {
		if (curType == ChessType.Black)
			setType (ChessType.White);
		else
			setType (ChessType.Black);
	}

	public void OnPointerEnter(PointerEventData data) {
		if (!GameController.manager.hasStartSimulate)
			return;
		if (GameController.manager.hasConfirmSimulate)
			return;
		if (!checkAvailable())
			return;
		if (GameController.manager.SimulateLinkCount >= 2 && GameController.manager.tempSimulateSelectedList [GameController.manager.tempSimulateSelectedList.Count - 2] == this) {
			GameController.manager.tempSimulateSelectedList.RemoveAt (GameController.manager.tempSimulateSelectedList.Count - 1);
			GameController.manager.SimulateLinkCount--;
			return;
		}
		if (GameController.manager.tempSimulateSelectedList.Contains (this))
			return;
		GameController.manager.tempSimulateSelectedList.Add (this);
		GameController.manager.SimulateLinkCount++;
	}

	public void OnPointerExit(PointerEventData data) {
		if (!GameController.manager.hasStartSimulate)
			return;
		if (GameController.manager.hasConfirmSimulate)
			return;
	}

	public void OnPointerClick(PointerEventData data) {
		if (GameController.manager.hasConfirmSimulate)
			return;
		if (!GameController.manager.hasStartSimulate) {
			//clear all item
			GameController.manager.ClearAllSimulateItems();
			GameController.manager.hasStartSimulate = true;
			GameController.manager.tempSimulateSelectedList.Add (this);
			GameController.manager.SimulateLinkCount = 0;
			GameController.manager.SimulateLinkCount++;
		} else {
			GameController.manager.hasStartSimulate = false;
			GameController.manager.ConvertSimulateItems ();
		}
	}

	bool checkAvailable() {
		SimulateItem lastItem = GameController.manager.tempSimulateSelectedList [GameController.manager.tempSimulateSelectedList.Count - 1];
		int lastRow = lastItem.index / simulateWidth;
		int lastCol = lastItem.index % simulateWidth;
		int curRow = index / simulateWidth;
		int curCol = index % simulateWidth;
		//around
		if ((lastCol == curCol && (lastRow == curRow + 1 || lastRow == curRow - 1)) || (lastRow == curRow && (lastCol == curCol + 1 || lastCol == curCol - 1)))
			return true;
		return false;
	}

}
