using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour {

	public static GameController2 manager = null;

	public GameDiff curDiff = GameDiff.Easy;

	public LineMode curLineMode = LineMode.Show;

	public ShowMode curShowMode = ShowMode.After;

	public LinkMode curLinkMode = LinkMode.Basic;

	public List<ChessItem> chessList = new List<ChessItem> ();

	//不写capacity 就是可变的 capacity
	public List<ChessItem> selectedList = new List<ChessItem> ();

	public List<SimulateItem> simulateList = new List<SimulateItem> ();

	public List<SimulateItem> tempSimulateSelectedList = new List<SimulateItem> ();

	public List<SimulateItem> simulateSelectedList = new List<SimulateItem> ();

	public List<int> ctmAnswerList = new List<int> ();

	public List<AnswerPanel> answerPanelList;

	public int LinkCount = 0;

	public int SimulateLinkCount = 0;

	public int maxLinkCount = 3;

	public int SimCount = 3;

	public bool hasStartLink = false;

	public bool hasStartGame = false;

	public bool hasStartSimulate = false;

	public bool hasConfirmSimulate = false;

	public background bg;

	public bool JLinkMode = false;

	public bool LLinkMode = false;

	public bool CtmLinkMode = false;

	public List<List<int>> answerList = new List<List<int>> (4);

	List<int> LList = new List<int> (6);
	List<int> JList = new List<int> (9);
	bool LListConfigured = false;
	bool JListConfigured = false;
	public int maxX = 0;
	public int maxY = 0;
	int simulateMaxX = 0;
	int simulateMaxY = 0;

	public int maxRow = 6;
	public int maxCol = 7;
	public float itemWidth = 0.85f;
	public float itemHeight = 0.85f;
	public float offset = 0.1f;
	public Transform content;
	public ChessItem chessItemPrefab;



	public void ConfirmSimulateList() {
		simulateSelectedList.Clear ();
		for (int i = 0; i < tempSimulateSelectedList.Count; i++) {
			simulateSelectedList.Add (tempSimulateSelectedList [i]);
		}
	}

	public void ResetSimulteByResetBtn() {
		for (int i = 0; i < simulateSelectedList.Count; i++) {
			simulateSelectedList [i].reset();
		}
//		for (int i = 0; i < tempSimulateSelectedList.Count; i++) {
//			tempSimulateSelectedList [i].reset ();
//		}
		simulateSelectedList.Clear ();
		tempSimulateSelectedList.Clear ();
		hasConfirmSimulate = false;
		SimulateLinkCount = 0;
	}

	void Awake() {
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
		} else if (manager != this) {
			Destroy (gameObject);
		}
	}

	public void CreateAllItems() {
		float originX = itemWidth * 0.5f;
		float originY = itemHeight * 0.5f;
		for (int i = 0; i < maxRow; i++) {
			for (int j = 0; j < maxCol; j++) {
				ChessItem item = (ChessItem)PoolManager.manager.getPool (chessItemPrefab).getObject ();
				item.transform.SetParent (content);
				item.transform.localPosition = new Vector3 (originX + j * (offset + itemWidth), originY - i * (offset + itemHeight), 0);
				item.setIndex (i * maxCol + j);
				chessList.Add (item);
			}
		}
	}

	public void DestoryAllItems() {
		for (int i = chessList.Count - 1; i >=0; i--) {
			chessList [i].returnToPool ();
			chessList [i].reset ();
		}
		chessList.Clear ();
	}

	public void setAnswerPanelData() {
		for (int i = 0; i < answerPanelList.Count; i++) {
			if (JLinkMode) {
				maxX = 3;
				maxY = 3;
				answerPanelList [i].setAnswerList (JList, maxX, maxY);
			} else if (LLinkMode) {
				maxX = 2;
				maxY = 3;
				answerPanelList [i].setAnswerList (LList, maxX, maxY);
			} else if (CtmLinkMode) {
//				maxX = simulateMaxX;
//				maxY = simulateMaxY;
//				answerPanelList [i].setAnswerList (ctmAnswerList, maxX, maxY);
			}
		}
	}

	public void SetLinkModeData(AdvanceLinkMode alm) {
		answerList.Clear ();
		if (alm == AdvanceLinkMode.J) {
			if (!JListConfigured)
				ConfigureJList ();
			maxX = 3;
			maxY = 3;
			for (int i = 0; i < 4; i++) {
				List<int> temp = new List<int> (9);
				switch (i) {
				case 0:
					for (int j = 0; j < JList.Count; j++) {
						temp.Add (JList [j]);
					}
					break;
				case 1:
					for (int m = 0; m < maxX; m++) {
						for (int n = maxY - 1; n >= 0; n--) {
							temp.Add (JList [n * maxX + m]);
						}
					}
					break;
				case 2:
					for (int m = maxY - 1; m >= 0; m--) {
						for (int n = maxX - 1; n >= 0; n--) {
							temp.Add (JList [m * maxX + n]);
						}
					}
					break;
				case 3:
					for (int m = maxX - 1; m >= 0; m--) {
						for (int n = 0; n < maxY; n++) {
							temp.Add (JList [n * maxX + m]);
						}
					}
					break;
				default:
					break;
				}
				answerList.Add (temp);
			}
			//print
			print ("Show all data");
			string str = "";
			for (int i = 0; i < answerList.Count; i++) {
				str = "";
				for (int j = 0; j < answerList [i].Count; j++) {
					str += answerList [i] [j] + " ";
				}
				print (str);
			}
		} else if (alm == AdvanceLinkMode.L) {
			if (!LListConfigured)
				ConfigureLList ();
			maxX = 2;
			maxY = 3;
			for (int i = 0; i < 4; i++) {
				List<int> temp = new List<int> (6);
				switch (i) {
				case 0:
					for (int j = 0; j < LList.Count; j++) {
						temp.Add (LList [j]);
					}
					break;
				case 1:
					for (int m = 0; m < maxX; m++) {
						for (int n = maxY - 1; n >= 0; n--) {
							temp.Add (LList [n * maxX + m]);
						}
					}
					break;
				case 2:
					for (int m = maxY - 1; m >= 0; m--) {
						for (int n = maxX - 1; n >= 0; n--) {
							temp.Add (LList [m * maxX + n]);
						}
					}
					break;
				case 3:
					for (int m = maxX - 1; m >= 0; m--) {
						for (int n = 0; n < maxY; n++) {
							temp.Add (LList [n * maxX + m]);
						}
					}
					break;
				default:
					break;
				}
				answerList.Add (temp);
			}
				
			string str = "";
			for (int i = 0; i < answerList.Count; i++) {
				str = "";
				for (int j = 0; j < answerList [i].Count; j++) {
					str += answerList [i] [j] + " ";
				}
				print (str);
			}
		} else if (alm == AdvanceLinkMode.CTM) {
//			ctmAnswerList is right list
			maxX = simulateMaxX;
			maxY = simulateMaxY;
			for (int i = 0; i < 4; i++) {
				List<int> temp = new List<int> (6);
				switch (i) {
				case 0:
					for (int j = 0; j < ctmAnswerList.Count; j++) {
						temp.Add (ctmAnswerList [j]);
					}
					break;
				case 1:
					for (int m = 0; m < maxX; m++) {
						for (int n = maxY - 1; n >= 0; n--) {
							temp.Add (ctmAnswerList [n * maxX + m]);
						}
					}
					break;
				case 2:
					for (int m = maxY - 1; m >= 0; m--) {
						for (int n = maxX - 1; n >= 0; n--) {
							temp.Add (ctmAnswerList [m * maxX + n]);
						}
					}
					break;
				case 3:
					for (int m = maxX - 1; m >= 0; m--) {
						for (int n = 0; n < maxY; n++) {
							temp.Add (ctmAnswerList [n * maxX + m]);
						}
					}
					break;
				default:
					break;
				}
				answerList.Add (temp);
			}
		}
	}

	void ConfigureLList() {
		LList.Add (1);
		LList.Add (0);
		LList.Add (1);
		LList.Add (0);
		LList.Add (1);
		LList.Add (1);
		LListConfigured = true;
	}

	void ConfigureJList() {
		JList.Add (1);
		JList.Add (1);
		JList.Add (1);
		JList.Add (0);
		JList.Add (0);
		JList.Add (1);
		JList.Add (0);
		JList.Add (1);
		JList.Add (1);
		JListConfigured = true;
	}

	void Start() {
		for (int i = 0; i < chessList.Count; i++) {
			chessList [i].setIndex (i);
		}
	}

	public void ResetToNormal() {
		hasStartGame = false;
		hasStartLink = false;

		for (int i = 0; i < chessList.Count; i++) {
			chessList [i].setType (ChessType.Black);
		}
		selectedList.Clear ();
		for (int i = 0; i < answerPanelList.Count; i++) {
			answerPanelList [i].Reset ();
		}
		answerList.Clear ();
		for (int i = 0; i < simulateList.Count; i++) {
			simulateList [i].reset ();
		}
			
		bg.ResetSimulate ();
		ResetSimulate ();
		ResetSimulteByResetBtn ();
		DestoryAllItems ();
	}

	public void ResetSimulate() {
		ctmAnswerList.Clear ();
		for (int i = 0; i < tempSimulateSelectedList.Count; i++) {
			tempSimulateSelectedList [i].reset ();
		}
		tempSimulateSelectedList.Clear ();
		hasStartSimulate = false;
		hasConfirmSimulate = false;
	}
	//do not influenced by show mode
	public void SimulateInLowLevel () {
		int i = 0;
		bool deadChess = false;
		bool hasAdded = false;
		int random = 0;
		int RandomDir = 0;
		int lastIndex = 0;
		while (i < SimCount) {
			//operate board
			random = Random.Range(0,chessList.Count);
			selectedList.Add (chessList [random]);
			deadChess = false;
			for (int j = 0; j < maxLinkCount - 1; j++) {
				if (!CheckAlive (selectedList [selectedList.Count - 1].index)) {
					deadChess = true;
					break;
				}
				RandomDir = 0;
				hasAdded = false;
				lastIndex = selectedList [selectedList.Count - 1].index;
				while (true) {
					RandomDir = Random.Range (0, 4);
					switch (RandomDir) {
					case 0:
						if (CheckAvailable (Direction.Up)) {
							//add to list
							selectedList.Add(chessList[lastIndex - maxCol]);
							hasAdded = true;
							break;
						}
						break;
					case 1:
						if (CheckAvailable (Direction.Down)) {
							//add to list
							selectedList.Add(chessList[lastIndex + maxCol]);
							hasAdded = true;
							break;
						}
						break;
					case 2:
						if (CheckAvailable (Direction.Left)) {
							//add to list
							selectedList.Add(chessList[lastIndex - 1]);
							hasAdded = true;
							break;
						}
						break;
					case 3:
						if (CheckAvailable (Direction.Right)) {
							//add to list
							selectedList.Add(chessList[lastIndex + 1]);
							hasAdded = true;
							break;
						}
						break;
					default:
						break;
					}
					// has added item to list
					if (hasAdded)
						break;
				}
			}

			if (!deadChess) {
				i++;
				ConvertItems ();
			}
			selectedList.Clear ();
		}
	}

	public void SimulateInMiddleLevel() {
		int i = 0;
		int random = 0;
		int randomIndex = 0;
		int row = 0;
		int col = 0;
		int tMaxX = 0;
		int tMaxY = 0;
		bool deadChess = false;
		while (i < SimCount) {
			random = Random.Range (0, chessList.Count);
			randomIndex = Random.Range (0, 4);
			row = random / maxCol;
			col = random % maxCol;
			deadChess = false;
			randomIndex = 0;
			switch (randomIndex) {
			case 0:
				if (JLinkMode) {
					maxX = 3;
					maxY = 3;
				} else if (LLinkMode) {
					maxX = 2;
					maxY = 3;
				} else if (CtmLinkMode) {
					maxX = simulateMaxX;
					maxY = simulateMaxY;
				}
				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						if(chessList[j].row >= row && chessList[j].col >= col && chessList[j].row <= tMaxY && chessList[j].col <= tMaxX) {
							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
//							chessList[j].Convert();
							int answerX = chessList [j].row - row;
							int answerY = chessList [j].col - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j].Convert ();
						}
					}
				} else {
					deadChess = true;
				}
				break;
			case 1:
				if (JLinkMode) {
					maxX = 3;
					maxY = 3;
				} else if (LLinkMode) {
					maxX = 3;
					maxY = 2;
				} else if (CtmLinkMode) {
					maxX = simulateMaxY;
					maxY = simulateMaxX;
				}
				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						if(chessList[j].row >= row && chessList[j].col >= col && chessList[j].row <= tMaxY && chessList[j].col <= tMaxX) {
							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = chessList [j].row - row;
							int answerY = chessList [j].col - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j].Convert ();
						}
					}
				} else {
					deadChess = true;
				}
				break;
			case 2:
				if (JLinkMode) {
					maxX = 3;
					maxY = 3;
				} else if (LLinkMode) {
					maxX = 2;
					maxY = 3;
				} else if (CtmLinkMode) {
					maxX = simulateMaxX;
					maxY = simulateMaxY;
				}
				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						if(chessList[j].row >= row && chessList[j].col >= col && chessList[j].row <= tMaxY && chessList[j].col <= tMaxX) {
							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = chessList [j].row - row;
							int answerY = chessList [j].col - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j].Convert ();
						}
					}
				} else {
					deadChess = true;
				}
				break;
			case 3:
				if (JLinkMode) {
					maxX = 3;
					maxY = 3;
				} else if (LLinkMode) {
					maxX = 3;
					maxY = 2;
				} else if (CtmLinkMode) {
					maxX = simulateMaxY;
					maxY = simulateMaxX;
				}
				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						if(chessList[j].row >= row && chessList[j].col >= col && chessList[j].row <= tMaxY && chessList[j].col <= tMaxX) {
							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = chessList [j].row - row;
							int answerY = chessList [j].col - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j].Convert ();
						}
					}
				} else {
					deadChess = true;
				}
				break;
			default:
				break;
			}
			if (!deadChess)
				i++;
		}
	}

	bool CheckAvailableInAdvanceMode(int randomIndex, int row, int col) {
		if (row + maxY - 1 > maxRow - 1)
			return false;
		if (col + maxX - 1 > maxCol - 1)
			return false;
		return true;
	}

	bool CheckAvailable(Direction dir) {
		if(selectedList.Count == 0)
			return true;
		//get row and col of the last item
		int curIndex = selectedList[selectedList.Count - 1].index;
		int row = curIndex / maxCol;
		int col = curIndex % maxCol;
		switch (dir) {
		case Direction.Up:
			if (row == 0)
				return false;
			else if (selectedList.Contains (chessList [curIndex - maxCol]))
				return false;
			break;
		case Direction.Down:
			if (row == maxRow - 1)
				return false;
			else if (selectedList.Contains (chessList [curIndex + maxCol]))
				return false;
			break;
		case Direction.Left:
			if (col == 0)
				return false;
			else if (selectedList.Contains (chessList [curIndex - 1]))
				return false;
			break;
		case Direction.Right:
			if (col == maxCol - 1)
				return false;
			else if (selectedList.Contains (chessList [curIndex + 1]))
				return false;
			break;
		default:
			break;
		}
		return true;
	}

	bool CheckAlive(int itemIndex) {
		int row = itemIndex / maxCol;
		int col = itemIndex % maxCol;
		if (row == 0 && col == 0) {
			if (selectedList.Contains (chessList [itemIndex + 1]) && selectedList.Contains (chessList [itemIndex + maxCol])) {
				return false;
			}
		} else if (row == 0 && col == maxCol - 1) {
			if (selectedList.Contains (chessList [itemIndex - 1]) && selectedList.Contains (chessList [itemIndex + maxCol])) {
				return false;
			}
		} else if (row == maxRow - 1 && col == 0) {
			if (selectedList.Contains (chessList [itemIndex + 1]) && selectedList.Contains (chessList [itemIndex - maxCol])) {
				return false;
			}
		} else if (row == maxRow - 1 && col == maxCol - 1) {
			if (selectedList.Contains (chessList [itemIndex - 1]) && selectedList.Contains (chessList [itemIndex - maxCol])) {
				return false;
			}
		}
		return true;
	}

	public void ConvertItems() {
		for (int i = 0; i < selectedList.Count; i++) {
			if (curDiff == GameDiff.Easy) {
				selectedList [i].Convert ();
			} else if (curDiff == GameDiff.Hard) {
				if (i != maxLinkCount / 2) {
					selectedList [i].Convert ();
				}
			} else if (curDiff == GameDiff.Ultra) {
				if (i == (maxLinkCount / 2 + 1) || i == (maxLinkCount / 2 - 1)) {
					// do nothing
				}
				else {
					selectedList [i].Convert ();
				}
			}
		}
	}

	void Update() {

		ShowSelectedItems ();
		if (!hasStartGame) {
			if (hasConfirmSimulate)
				ShowSimulateSelectItem ();
			else
				ShowTempSimualteSelectItem ();
			ShowSimulateLine ();
		}

		if (curLineMode == LineMode.Show) {
			ShowLine ();
		}

	}

	public void CalculateCtmList() {
		print ("CalculateCtmList");
		int tMinX = 3;
		int tMinY = 3;
		int tMaxX = 0;
		int tMaxY = 0;

		ctmAnswerList.Clear ();

		for (int i = 0; i < simulateSelectedList.Count; i++) {
			print ("row : " + simulateSelectedList [i].row + " col : " + simulateSelectedList [i].col);
			if (simulateSelectedList [i].col >= tMaxX)
				tMaxX = simulateSelectedList [i].col;
			if (simulateSelectedList [i].col <= tMinX)
				tMinX = simulateSelectedList [i].col;
			if (simulateSelectedList [i].row >= tMaxY)
				tMaxY = simulateSelectedList [i].row;
			if (simulateSelectedList [i].row <= tMinY)
				tMinY = simulateSelectedList [i].row;
		}

		print (tMinX);
		print (tMaxX);
		print (tMinY);
		print (tMaxY);

		for (int i = 0; i < simulateList.Count; i++) {
			if (simulateList [i].col >= tMinX && simulateList [i].col <= tMaxX && simulateList [i].row >= tMinY && simulateList [i].row <= tMaxY) {
				ctmAnswerList.Add (simulateList [i].isSelected ? 1 : 0);
			}
		}

		simulateMaxX = tMaxX - tMinX + 1;
		simulateMaxY = tMaxY - tMinY + 1;

		string str = "";
		for (int i = 0; i < ctmAnswerList.Count; i++) {
			str += ctmAnswerList [i].ToString ();
		}
		print ("ctm list : " + str);

	}

	public bool CheckIfWinTheGame() {
		ChessType type = chessList [0].curType;
		bool win = true;
		for (int i = 0; i < chessList.Count; i++) {
			if (chessList [i].curType != type) {
				win = false;
				break;
			}
		}
		return win;
	}

	public void ShowWinOperation() {
		bg.ShowWinOperation ();
		ResetToNormal ();
	}

	public void ConvertSimulateItems() {
		int tempCount = 0;
		for (int i = 0; i < simulateList.Count; i++) {
			if (tempSimulateSelectedList.Contains (simulateList [i])) {
				//Judge Diff
				simulateList [i].Convert();
				tempCount++;
			}
		}
		maxLinkCount = tempCount;
	}

	void ShowSimulateSelectItem() {
		for (int i = 0; i < simulateList.Count; i++) {
			if (simulateSelectedList.Contains (simulateList [i])) {
				//Judge Diff
				simulateList [i].setSelected (true);
				simulateList [i].setUnselected (false);
			} else {
				simulateList [i].setSelected (false);
				simulateList [i].setUnselected (false);
			}
		}
	}

	void ShowTempSimualteSelectItem() {
		for (int i = 0; i < simulateList.Count; i++) {
			if (tempSimulateSelectedList.Contains (simulateList [i])) {
				//Judge Diff
				simulateList [i].setSelected (true);
				simulateList [i].setUnselected (false);
			} else {
				simulateList [i].setSelected (false);
				simulateList [i].setUnselected (false);
			}
		}
	}

	void ShowSelectedItems() {
		for (int i = 0; i < chessList.Count; i++) {
			if (selectedList.Contains (chessList [i])) {
				//Judge Diff
				if (curDiff == GameDiff.Easy) {
					chessList [i].setSelected (true);
					chessList [i].setUnselected (false);
				} else if (curDiff == GameDiff.Hard) {
					int index = selectedList.IndexOf (chessList [i]);
					if (index != maxLinkCount / 2) {
						chessList [i].setSelected (true);
						chessList [i].setUnselected (false);
					} else {
						chessList [i].setSelected (false);
						chessList [i].setUnselected (true);
					}
				} else if (curDiff == GameDiff.Ultra) {
					int index = selectedList.IndexOf (chessList [i]);
					if (index == (maxLinkCount / 2 + 1) || index == (maxLinkCount / 2 - 1)) {
						chessList [i].setSelected (false);
						chessList [i].setUnselected (true);
					}
					else {
						chessList [i].setSelected (true);
						chessList [i].setUnselected (false);
					}
				}
			} else {
				chessList [i].setSelected (false);
				chessList [i].setUnselected (false);
			}
		}
	}

	void ShowSimulateLine() {
		for (int i = 0; i < simulateList.Count; i++) {
			if (!tempSimulateSelectedList.Contains (simulateList [i]))
				simulateList [i].setLineType (LineType.None);
		}
		for (int i = 0; i < tempSimulateSelectedList.Count; i++) {
			if (i == 0) {
				//judge next
				if (tempSimulateSelectedList.Count > 1) {
					if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - 1) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + 1) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyLeft);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyDown);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyUp);
					}
				} else {
					tempSimulateSelectedList [i].setLineType (LineType.None);
				}
			} else if (i == tempSimulateSelectedList.Count - 1) {
				//judge prev
				if (tempSimulateSelectedList.Count > 1) {
					if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index - 1) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index + 1) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyLeft);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index - SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyDown);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index + SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.OnlyUp);
					}
				} else {
					tempSimulateSelectedList [i].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index - 1) {
					if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + 1) {
						tempSimulateSelectedList [i].setLineType (LineType.LeftRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.DownRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.UpRight);
					} else {
						tempSimulateSelectedList [i].setLineType (LineType.None);
					}
				} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index + 1) {
					if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - 1) {
						tempSimulateSelectedList [i].setLineType (LineType.LeftRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.DownLeft);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.UpLeft);
					} else {
						tempSimulateSelectedList [i].setLineType (LineType.None);
					}
				} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index - SimulateItem.simulateWidth) {
					if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - 1) {
						tempSimulateSelectedList [i].setLineType (LineType.DownRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + 1) {
						tempSimulateSelectedList [i].setLineType (LineType.DownLeft);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.UpDown);
					} else {
						tempSimulateSelectedList [i].setLineType (LineType.None);
					}
				} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i - 1].index + SimulateItem.simulateWidth) {
					if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - 1) {
						tempSimulateSelectedList [i].setLineType (LineType.UpRight);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index + 1) {
						tempSimulateSelectedList [i].setLineType (LineType.UpLeft);
					} else if (tempSimulateSelectedList [i].index == tempSimulateSelectedList [i + 1].index - SimulateItem.simulateWidth) {
						tempSimulateSelectedList [i].setLineType (LineType.UpDown);
					} else {
						tempSimulateSelectedList [i].setLineType (LineType.None);
					}
				}
			}
		}
	}

	void ShowLine() {
		for (int i = 0; i < chessList.Count; i++) {
			if (!selectedList.Contains (chessList [i]))
				chessList [i].setLineType (LineType.None);
		}
		//judge if line should show
		for (int i = 0; i < selectedList.Count; i++) {
			if (i == 0) {
				//judge next
				if (selectedList.Count > 1) {
					if (selectedList [i].index == selectedList [i + 1].index - 1) {
						selectedList [i].setLineType (LineType.OnlyRight);
					} else if (selectedList [i].index == selectedList [i + 1].index + 1) {
						selectedList [i].setLineType (LineType.OnlyLeft);
					} else if (selectedList [i].index == selectedList [i + 1].index - maxCol) {
						selectedList [i].setLineType (LineType.OnlyDown);
					} else if (selectedList [i].index == selectedList [i + 1].index + maxCol) {
						selectedList [i].setLineType (LineType.OnlyUp);
					}
				} else {
					selectedList [i].setLineType (LineType.None);
				}
			} else if (i == selectedList.Count - 1) {
				//judge prev
				if (selectedList.Count > 1) {
					if (selectedList [i].index == selectedList [i - 1].index - 1) {
						selectedList [i].setLineType (LineType.OnlyRight);
					} else if (selectedList [i].index == selectedList [i - 1].index + 1) {
						selectedList [i].setLineType (LineType.OnlyLeft);
					} else if (selectedList [i].index == selectedList [i - 1].index - maxCol) {
						selectedList [i].setLineType (LineType.OnlyDown);
					} else if (selectedList [i].index == selectedList [i - 1].index + maxCol) {
						selectedList [i].setLineType (LineType.OnlyUp);
					}
				} else {
					selectedList [i].setLineType (LineType.None);
				}
			} else {
				//jugde prev and next    --    at least three items
				if (selectedList [i].index == selectedList [i - 1].index - 1) {
					if (selectedList [i].index == selectedList [i + 1].index + 1) {
						selectedList [i].setLineType (LineType.LeftRight);
					} else if (selectedList [i].index == selectedList [i + 1].index - maxCol) {
						selectedList [i].setLineType (LineType.DownRight);
					} else if (selectedList [i].index == selectedList [i + 1].index + maxCol) {
						selectedList [i].setLineType (LineType.UpRight);
					} else {
						selectedList [i].setLineType (LineType.None);
					}
				} else if (selectedList [i].index == selectedList [i - 1].index + 1) {
					if (selectedList [i].index == selectedList [i + 1].index - 1) {
						selectedList [i].setLineType (LineType.LeftRight);
					} else if (selectedList [i].index == selectedList [i + 1].index - maxCol) {
						selectedList [i].setLineType (LineType.DownLeft);
					} else if (selectedList [i].index == selectedList [i + 1].index + maxCol) {
						selectedList [i].setLineType (LineType.UpLeft);
					} else {
						selectedList [i].setLineType (LineType.None);
					}
				} else if (selectedList [i].index == selectedList [i - 1].index - maxCol) {
					if (selectedList [i].index == selectedList [i + 1].index - 1) {
						selectedList [i].setLineType (LineType.DownRight);
					} else if (selectedList [i].index == selectedList [i + 1].index + 1) {
						selectedList [i].setLineType (LineType.DownLeft);
					} else if (selectedList [i].index == selectedList [i + 1].index + maxCol) {
						selectedList [i].setLineType (LineType.UpDown);
					} else {
						selectedList [i].setLineType (LineType.None);
					}
				} else if (selectedList [i].index == selectedList [i - 1].index + maxCol) {
					if (selectedList [i].index == selectedList [i + 1].index - 1) {
						selectedList [i].setLineType (LineType.UpRight);
					} else if (selectedList [i].index == selectedList [i + 1].index + 1) {
						selectedList [i].setLineType (LineType.UpLeft);
					} else if (selectedList [i].index == selectedList [i + 1].index - maxCol) {
						selectedList [i].setLineType (LineType.UpDown);
					} else {
						selectedList [i].setLineType (LineType.None);
					}
				}
			}
		}
	}

	public bool CheckAdvance() {
		int minX = maxCol - 1;
		int minY = maxRow - 1;
		int maxX = 0;
		int maxY = 0;
		for (int i = 0; i < selectedList.Count; i++) {
//			print ("row : " + selectedList [i].row + " col : " + selectedList[i].col);
			if (selectedList [i].row <= minY)
				minY = selectedList [i].row;
			if (selectedList [i].col <= minX)
				minX = selectedList [i].col;
			if (selectedList [i].row >= maxY)
				maxY = selectedList [i].row;
			if (selectedList [i].col >= maxX)
				maxX = selectedList [i].col;
		}
			
		List<int> tempList = new List<int> ((maxX - minX + 1) * (maxY - minY + 1));
		tempList.Clear ();
		for (int i = 0; i < chessList.Count; i++) {
			if (chessList [i].col >= minX && chessList [i].row >= minY && chessList [i].col <= maxX && chessList [i].row <= maxY) {
				tempList.Add (chessList [i].isSelected ? 1 : 0);
			}
		}

		for (int i = 0; i < tempList.Count; i++) {
			print (tempList [i]);
		}

		if (tempList.Count != answerList [0].Count)
			return false;

		bool hasFindList = true;
		for (int i = 0; i < answerList.Count; i++) {
			hasFindList = true;
			for (int j = 0; j < answerList [i].Count; j++) {
				if (answerList [i] [j] != tempList [j]) {
					hasFindList = false;
					break;
				}
			}
			if (hasFindList)
				break;
		}

		if (hasFindList)
			print ("Find");
		else
			print ("Not Find");

		return hasFindList;
	}

	public void RevertItemsInShowModeNow() {
		for (int i = 0; i < selectedList.Count; i++) {
			if (curDiff == GameDiff.Easy) {
				selectedList [i].Convert ();
			} else if (curDiff == GameDiff.Hard) {
				if (i != maxLinkCount / 2) {
					selectedList [i].Convert ();
				}
			} else if (curDiff == GameDiff.Ultra) {
				if (i == (maxLinkCount / 2 + 1) || i == (maxLinkCount / 2 - 1)) {
					// do nothing
				} else {
					selectedList [i].Convert ();
				}
			}
		}
	}

	public void ClearAllSimulateItems() {
		for (int i = 0; i < tempSimulateSelectedList.Count; i++)
			tempSimulateSelectedList [i].Convert ();
		tempSimulateSelectedList.Clear ();
	}

	public bool CheckSimulateAvailable() {
		return SimulateLinkCount >= 3;
	}
}
