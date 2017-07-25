using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerPanel : MonoBehaviour {
	public int panelIndex;
	public List<int> answerList = null;
	public List<AnswerItem> answerItemList;
	public List<AnswerItem> selectItemList = new List<AnswerItem> ();
	public static int answerWidth = 3;
	public bool hasConvert = false;
	int idx = 0;
	public void setAnswerList(List<int> l, int maxX, int maxY) {
		GameController.manager.printIntList (l);
		answerList = l;
		idx = 0;
		print ("X Y : " + maxX + " " + maxY);
//		for (int i = 0; i < answerItemList.Count; i++) {
//			if (answerItemList [i].col < maxX && answerItemList [i].row < maxY ) {
//				answerItemList [i].setType (answerList [idx++] == 1 ? ChessType.White : ChessType.Black);
//			} else {
//				answerItemList [i].setType (ChessType.Black);
//			}
//		}
	}

	public void Reset() {
		hasConvert = false;
//		if(answerList != null && GameController.manager.CtmLinkMode)
//			answerList.Clear ();
		for (int i = 0; i < answerItemList.Count; i++) {
			answerItemList [i].setType (ChessType.Black);
			answerItemList [i].setLineType (LineType.None);
		}
		selectItemList.Clear ();
	}

	void Update() {
		if (GameController.manager.hasStartGame) {
			if (GameController.manager.CtmLinkMode) {
				if (!hasConvert) {
					ConvertCTMList ();
					ShowCTMLine ();
					ShowConvert ();
					hasConvert = true;
				}
			} else if (GameController.manager.JLinkMode) {
				if (!hasConvert) {
					ConvertList (GameController.manager.JAnswerList);
					ShowJModeLine ();
					ShowConvert ();
					hasConvert = true;
				}
			} else if (GameController.manager.LLinkMode) {
				if (!hasConvert) {
					ConvertList (GameController.manager.LAnswerList);
					ShowLModeLine ();
					ShowConvert ();
					hasConvert = true;
				}
			}
		}
//		ShowLine ();
	}

	void ConvertList(List<int> l) {
		for (int i = 0; i < l.Count; i++) {
			for (int j = 0; j < answerItemList.Count; j++) {
				if (l[i] == answerItemList [j].index) {
					selectItemList.Add (answerItemList [j]);
					break;
				}
			}
		}
	}
	 

	void ShowConvert() {
		for (int i = 0; i < answerItemList.Count; i++) {
			if (selectItemList.Contains (answerItemList [i])) {
				answerItemList [i].setType (ChessType.White);
			} else {
				answerItemList [i].setType (ChessType.Black);
			}
		}
	}

	void ConvertCTMList() {
		for (int i = 0; i < GameController.manager.simulateSelectedList.Count; i++) {
			for (int j = 0; j < answerItemList.Count; j++) {
				if (GameController.manager.simulateSelectedList [i].index == answerItemList [j].index) {
					selectItemList.Add (answerItemList [j]);
					break;
				}
			}
		}
	}

	void ShowJModeLine() {
		switch (panelIndex) {
		case 0:
			showLJPanelOneLine (GameController.manager.JAnswerList);
			break;
		case 1:
			showLJPanelTwoLine (GameController.manager.JAnswerList);
			break;
		case 2:
			showLJPanelThreeLine (GameController.manager.JAnswerList);
			break;
		case 3:
			showLJPanelFourLine (GameController.manager.JAnswerList);
			break;
		default:
			break;
		}
	}

	void ShowLModeLine() {
		switch (panelIndex) {
		case 0:
			showLJPanelOneLine (GameController.manager.LAnswerList);
			break;
		case 1:
			showLJPanelTwoLine (GameController.manager.LAnswerList);
			break;
		case 2:
			showLJPanelThreeLine (GameController.manager.LAnswerList);
			break;
		case 3:
			showLJPanelFourLine (GameController.manager.LAnswerList);
			break;
		default:
			break;
		}
	}

	void ShowCTMLine() {
		//judge if line should show
		switch (panelIndex) {
		case 0:
			showCTMPanelOneLine ();
			break;
		case 1:
			showCTMPanelTwoLine ();
			break;
		case 2:
			showCTMPanelThreeLine ();
			break;
		case 3:
			showCTMPanelFourLine ();
			break;
		default:
			break;
		}
	}

	// 这个地方写的太傻比了！！
	void showCTMPanelOneLine() {
		for (int i = 0; i < selectItemList.Count; i++) {
			if (i == 0) {
				//judge next
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else if (i == selectItemList.Count - 1) {
				//judge prev
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showCTMPanelTwoLine() {
		for (int i = 0; i < selectItemList.Count; i++) {
			if (i == 0) {
				//judge next
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else if (i == selectItemList.Count - 1) {
				//judge prev
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showCTMPanelThreeLine() {
		for (int i = 0; i < selectItemList.Count; i++) {
			if (i == 0) {
				//judge next
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else if (i == selectItemList.Count - 1) {
				//judge prev
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showCTMPanelFourLine() {
		for (int i = 0; i < selectItemList.Count; i++) {
			if (i == 0) {
				//judge next
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else if (i == selectItemList.Count - 1) {
				//judge prev
				if (selectItemList.Count > 1) {
					if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
						selectItemList [i].setLineType (LineType.OnlyUp);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
						selectItemList [i].setLineType (LineType.OnlyDown);
					} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyRight);
					} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.OnlyLeft);
					}
				} else {
					selectItemList [i].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (selectItemList [i].index == selectItemList [i - 1].index - 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + 1) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.UpDown);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index - answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.UpRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.DownRight);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + answerWidth) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				} else if (selectItemList [i].index == selectItemList [i - 1].index + answerWidth) {
					if (selectItemList [i].index == selectItemList [i + 1].index - 1) {
						selectItemList [i].setLineType (LineType.UpLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index + 1) {
						selectItemList [i].setLineType (LineType.DownLeft);
					} else if (selectItemList [i].index == selectItemList [i + 1].index - answerWidth) {
						selectItemList [i].setLineType (LineType.LeftRight);
					} else {
						selectItemList [i].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showLJPanelOneLine (List<int> list) {
		print ("list count : " + list.Count);
		for (int i = 0; i < list.Count; i++) {
			if (i == 0) {
				//judge next
				if (list.Count > 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list [i]].setLineType (LineType.OnlyRight);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else if (i == list.Count - 1) {
				//judge prev
				if (list.Count > 1) {
					if (list [i] == list [i - 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					} else if (list [i] == list [i - 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					} else if (list [i] == list [i - 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					} else if (list [i] == list [i - 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (list [i] == list [i - 1] - 1) {
					if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] - answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showLJPanelTwoLine (List<int> list) {
		for (int i = 0; i < list.Count; i++) {
			if (i == 0) {
				//judge next
				if (list.Count > 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else if (i == list.Count - 1) {
				//judge prev
				if (list.Count > 1) {
					if (list [i] == list [i - 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					} else if (list [i] == list [i - 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					} else if (list [i] == list [i - 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					} else if (list [i] == list [i - 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (list [i] == list [i - 1] - 1) {
					if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] - answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showLJPanelThreeLine (List<int> list) {
		for (int i = 0; i < list.Count; i++) {
			if (i == 0) {
				//judge next
				if (list.Count > 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else if (i == list.Count - 1) {
				//judge prev
				if (list.Count > 1) {
					if (list [i] == list [i - 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					} else if (list [i] == list [i - 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					} else if (list [i] == list [i - 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					} else if (list [i] == list [i - 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (list [i] == list [i - 1] - 1) {
					if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] - answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void showLJPanelFourLine (List<int> list) {
		for (int i = 0; i < list.Count; i++) {
			if (i == 0) {
				//judge next
				if (list.Count > 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else if (i == list.Count - 1) {
				//judge prev
				if (list.Count > 1) {
					if (list [i] == list [i - 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyUp);
					} else if (list [i] == list [i - 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.OnlyDown);
					} else if (list [i] == list [i - 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyRight);
					} else if (list [i] == list [i - 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.OnlyLeft);
					}
				} else {
					answerItemList [list[i]].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (list [i] == list [i - 1] - 1) {
					if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + 1) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.UpDown);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] - answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.UpRight);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.DownRight);
					} else if (list [i] == list [i + 1] + answerWidth) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				} else if (list [i] == list [i - 1] + answerWidth) {
					if (list [i] == list [i + 1] - 1) {
						answerItemList [list[i]].setLineType (LineType.UpLeft);
					} else if (list [i] == list [i + 1] + 1) {
						answerItemList [list[i]].setLineType (LineType.DownLeft);
					} else if (list [i] == list [i + 1] - answerWidth) {
						answerItemList [list[i]].setLineType (LineType.LeftRight);
					} else {
						answerItemList [list[i]].setLineType (LineType.None);
					}
				}
			}
		}
	}
}
