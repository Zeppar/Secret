using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum ChessType {
	Black,
	White
}

public enum LineType {
	UpDown,
	LeftRight,
	UpLeft,
	UpRight,
	DownRight,
	DownLeft,
	OnlyLeft,
	OnlyRight,
	OnlyUp,
	OnlyDown,
	None
}

public class ChessItem : PoolObject {

	public SpriteRenderer SR;
	public Sprite[] spriteArr;
	public int index = 0;
	public SpriteRenderer selectFlag;
	public SpriteRenderer unSelectFlag;
	public SpriteRenderer[] lineArr;
	LineType curLineType = LineType.None;
	public ChessType curType = ChessType.Black;
	public SpriteRenderer leftLine;
	public SpriteRenderer rightLine;
	public SpriteRenderer upLine;
	public SpriteRenderer downLine;
	public int row;
	public int col;
	public bool isSelected = false;


	public void setIndex(int idx) {
		index = idx;
		row = index / GameController.manager.maxCol;
		col = index % GameController.manager.maxCol;
	}

	public void setSelected(bool selected) {
		isSelected = selected;
		if (selected) {	
			selectFlag.enabled = true;
		} else {
			selectFlag.enabled = false;
		}
	}

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
			leftLine.enabled = false;
			rightLine.enabled = false;
			upLine.enabled = true;
			downLine.enabled = true;
			break;
		case LineType.LeftRight:
			leftLine.enabled = true;
			rightLine.enabled = true;
			upLine.enabled = false;
			downLine.enabled = false;
			break;
		case LineType.UpLeft:
			leftLine.enabled = true;
			rightLine.enabled = false;
			upLine.enabled = true;
			downLine.enabled = false;
			break;
		case LineType.UpRight:
			leftLine.enabled = false;
			rightLine.enabled = true;
			upLine.enabled = true;
			downLine.enabled = false;
			break;
		case LineType.DownRight:
			leftLine.enabled = false;
			rightLine.enabled = true;
			upLine.enabled = false;
			downLine.enabled = true;
			break;
		case LineType.DownLeft:
			leftLine.enabled = true;
			rightLine.enabled = false;
			upLine.enabled = false;
			downLine.enabled = true;
			break;
		case LineType.OnlyLeft:
			leftLine.enabled = true;
			rightLine.enabled = false;
			upLine.enabled = false;
			downLine.enabled = false;
			break;
		case LineType.OnlyRight:
			leftLine.enabled = false;
			rightLine.enabled = true;
			upLine.enabled = false;
			downLine.enabled = false;
			break;
		case LineType.OnlyUp:
			leftLine.enabled = false;
			rightLine.enabled = false;
			upLine.enabled = true;
			downLine.enabled = false;
			break;
		case LineType.OnlyDown:
			leftLine.enabled = false;
			rightLine.enabled = false;
			upLine.enabled = false;
			downLine.enabled = true;
			break;
		case LineType.None:
			leftLine.enabled = false;
			rightLine.enabled = false;
			upLine.enabled = false;
			downLine.enabled = false;
			break;
		default:
			break;
		}
	}

	public void setUnselected(bool unselected) {
		if (unselected) {
			unSelectFlag.enabled = true;
		} else {
			unSelectFlag.enabled = false;
		}
	}

	public void Convert() {
		if (curType == ChessType.Black) {
			setType(ChessType.White);
		} else if (curType == ChessType.White) {
			setType(ChessType.Black);
		}
	}

	public void setType(ChessType t) {
		curType = t;
		if (curType == ChessType.Black) {
			SR.sprite = spriteArr [0];
		} else if(curType == ChessType.White) {
			SR.sprite = spriteArr [1];
		}
	}

	void OnMouseDown() {   
		#if UNITY_EDITOR_OSX || UNITY_STANDALONE_WIN
		ClickDownFunction();
		#endif
	}

	void ClickDownFunction() {
		if (!GameController.manager.hasStartGame)
			return;
		GameController.manager.hasStartLink = true;
		GameController.manager.selectedList.Add (this);
		GameController.manager.LinkCount++;
		if (GameController.manager.curShowMode == ShowMode.Now)
			this.Convert ();
	}

	void OnMouseUp() {
		#if UNITY_EDITOR_OSX || UNITY_STANDALONE_WIN
		ClickUpFunction();
		#endif
	}

	void ClickUpFunction() {
		if (!GameController.manager.hasStartGame)
			return;
		GameController.manager.hasStartLink = false;
		if (GameController.manager.LinkCount == GameController.manager.maxLinkCount) {
			//execute convertItems function in ShowMode.After
			if (GameController.manager.curLinkMode == LinkMode.Basic) {
				if (GameController.manager.curShowMode == ShowMode.After) {
					GameController.manager.ConvertItems ();
					if (GameController.manager.CheckIfWinTheGame ()) {
						GameController.manager.ShowWinOperation ();
					}
				}
				GameController.manager.step++;
			} else if (GameController.manager.curLinkMode == LinkMode.Advance){
				if (!GameController.manager.CheckAdvance ()) {
					if (GameController.manager.curShowMode == ShowMode.Now) {
						GameController.manager.ConvertItems ();
					}
				} else {
					//can convert
					if (GameController.manager.curShowMode == ShowMode.After) {
						GameController.manager.ConvertItems ();
						if (GameController.manager.CheckIfWinTheGame ()) {
							GameController.manager.ShowWinOperation ();
						}
					}
				}
			}
		} else {
			if (GameController.manager.curShowMode == ShowMode.Now) {
				GameController.manager.ConvertItems ();
			}
		}
		GameController.manager.selectedList.Clear ();
		//		print ("GameController.manager.LinkCount : " + GameController.manager.LinkCount);
		GameController.manager.LinkCount = 0;
	}

	void OnMouseEnter() {
		#if UNITY_EDITOR_OSX || UNITY_STANDALONE_WIN
		ClickEnterFunction();
		#endif
	}

	void ClickEnterFunction() {
		if (!GameController.manager.hasStartGame)
			return;
		//fixed Bug
		if (GameController.manager.hasStartLink) {
			if (!checkAvailable ())
				return;
			if (GameController.manager.LinkCount <= GameController.manager.maxLinkCount) {
				if (GameController.manager.LinkCount >= 2 && GameController.manager.selectedList [GameController.manager.LinkCount - 2] == this) {
					if (GameController.manager.curShowMode == ShowMode.Now)
						GameController.manager.selectedList [GameController.manager.LinkCount - 1].Convert ();
					GameController.manager.selectedList.RemoveAt (GameController.manager.selectedList.Count - 1);
					GameController.manager.LinkCount--;
					return;
				}
			}
			if (GameController.manager.LinkCount < GameController.manager.maxLinkCount) {
				if (GameController.manager.selectedList.Contains (this))
					return;
				GameController.manager.selectedList.Add (this);
				GameController.manager.LinkCount++;
				if (GameController.manager.curShowMode == ShowMode.Now) {
					//					this.Convert ();
					if (GameController.manager.curDiff == GameDiff.Easy) {
						this.Convert ();
					} else if (GameController.manager.curDiff == GameDiff.Hard) {
						if ((GameController.manager.LinkCount - 1) != GameController.manager.maxLinkCount / 2) {
							this.Convert ();
						}
					} else if (GameController.manager.curDiff == GameDiff.Ultra) {
						if ((GameController.manager.LinkCount - 1) == (GameController.manager.maxLinkCount / 2 + 1) || (GameController.manager.LinkCount - 1) == (GameController.manager.maxLinkCount / 2 - 1)) {
							// do nothing
						}
						else {
							this.Convert ();
						}
					}
				}
			}
			if (GameController.manager.LinkCount == GameController.manager.maxLinkCount) {
				if (GameController.manager.CheckIfWinTheGame ()) {
					GameController.manager.ShowWinOperation ();
				}
			}
		}
	}

	void OnMouseExit() {
		//do nothing
	}

	bool checkAvailable() {
		ChessItem lastItem = GameController.manager.selectedList [GameController.manager.selectedList.Count - 1];
		int lastRow = lastItem.index / GameController.manager.maxCol;
		int lastCol = lastItem.index % GameController.manager.maxCol;
		int curRow = index / GameController.manager.maxCol;
		int curCol = index % GameController.manager.maxCol;
		//around
		if ((lastCol == curCol && (lastRow == curRow + 1 || lastRow == curRow - 1)) || (lastRow == curRow && (lastCol == curCol + 1 || lastCol == curCol - 1)))
			return true;
		return false;
	}
		
	void Update() {
		#if UNITY_IOS
		if(Input.touchCount > 0) {
			if(JudgeClickSelf ()) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					ClickDownFunction();
				} else if (Input.GetTouch (0).phase == TouchPhase.Moved) {
					ClickEnterFunction();
				} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
					ClickUpFunction();
				} else if (Input.GetTouch (0).phase == TouchPhase.Canceled) {
					ClickUpFunction();
				}
			}
			else {
				if (Input.GetTouch (0).phase == TouchPhase.Ended) {
					ClickUpFunction();
				} else if (Input.GetTouch (0).phase == TouchPhase.Canceled) {
					ClickUpFunction();
				}
			}
		}
		#endif
	}

//	RaycastHit2D hit;
//	Vector2 worldPoint;
	bool JudgeClickSelf () {
		Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		RaycastHit2D hit = Physics2D.Raycast( worldPoint, Vector2.zero );
		if (hit.collider != null) {
			if (hit.collider.gameObject == this.gameObject) {
//				Debug.Log ("this");
				return true;
			} else {
//				Debug.Log (hit.collider.gameObject.name + " not this");
				return false;
			}
			return true;
		} else {
			return false;
		}
	}

}
