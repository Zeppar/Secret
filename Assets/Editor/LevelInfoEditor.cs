using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

enum TempGameMode {
	Link3,
	Link4,
	Link5,
	LinkL,
	LinkJ
}	
public class LevelInfoEditor : EditorWindow {
	GameDiff curDiff = GameDiff.Easy;
	int SimCount = 1;
	int maxLinkCount = 3;
	int maxCol = 7;
	int maxRow = 6;
	int currentLevel = 0;
	public List<int> LList = new List<int> (6);
	public List<int> JList = new List<int> (9);
	public List<int> chessList = new List<int> (42);
	public List<int> selectedList = new List<int> (6);
	public List<List<int>> answerList = new List<List<int>> (4);
	TempGameMode curGameMode = TempGameMode.Link3;
	[MenuItem("Custom/ShowLevelInfoWindow",false,1)]
	static void ShowLevelInfoWindow() {
		Rect theRect = new Rect (0, 0, 500, 500);
		LevelInfoEditor window = (LevelInfoEditor)EditorWindow.GetWindowWithRect (typeof(LevelInfoEditor), theRect, true, "关卡模拟器");
		window.Show ();
	}

	void OnGUI() {
		curGameMode = (TempGameMode)EditorGUILayout.EnumPopup ("游戏模式", curGameMode);
		curDiff = (GameDiff)EditorGUILayout.EnumPopup ("游戏难度", curDiff);
		SimCount = EditorGUILayout.IntField ("模拟步数", SimCount);
		currentLevel = EditorGUILayout.IntField ("当前关卡数", currentLevel);
		//init list
		chessList.Clear();
		for (int i = 0; i < maxCol * maxRow; i++) {
			chessList.Add (1);
		}
		if (GUILayout.Button ("开始模拟")) {
			if (SimCount <= 0 || SimCount >= 100) {
				this.ShowNotification (new GUIContent ("请输入合法的步数"));
				return;
			}
			if (currentLevel < 0 || currentLevel > 99) {
				this.ShowNotification (new GUIContent ("请输入合法的关卡数"));
				return;
			}
			SetLinkModeData ();
			switch (curGameMode) {
			case TempGameMode.Link3:
				maxLinkCount = 3;
				SimulateInBasicLevel ();
				break;
			case TempGameMode.Link4:
				maxLinkCount = 4;
				SimulateInBasicLevel ();
				break;
			case TempGameMode.Link5:
				maxLinkCount = 5;
				SimulateInBasicLevel ();
				break;
			case TempGameMode.LinkJ:
				maxLinkCount = 6;
				SimulateInAdvanceLevel (TempGameMode.LinkJ);
				break;
			case TempGameMode.LinkL:
				maxLinkCount = 4;
				SimulateInAdvanceLevel (TempGameMode.LinkL);
				break;
			default:
				break;
			}
			printChessList ();
			WriteToLevelFile ();
		}
		if (GUILayout.Button ("重新模拟")) {
			chessList.Clear ();
			for (int i = 0; i < maxCol * maxRow; i++) {
				chessList.Add (1);
			}
		}
	}

	void WriteToLevelFile() {
		string filepath = "level_" + currentLevel.ToString ();
		string fullPath = "levelInfo/" + filepath + ".txt";
		string fileName = Application.dataPath + "/Resources/" + fullPath; 
		FileInfo file = new FileInfo (fileName);
		if (!file.Exists) {
			try {
				FileStream fs = new FileStream (fileName, FileMode.Create);
				StreamWriter sw = new StreamWriter (fs);
				string str = "";
				str = "Mode ";
				switch (curGameMode) {
				case TempGameMode.Link3:
					str += "3L";
					break;
				case TempGameMode.Link4:
					str += "4L";
					break;
				case TempGameMode.Link5:
					str += "5L";
					break;
				case TempGameMode.LinkL:
					str += "LL";
					break;
				case TempGameMode.LinkJ:
					str += "JL";
					break;
				default:
					break;
				}
				sw.WriteLine (str);
				str = "Size 7/6";
				sw.WriteLine (str);
				str = "Diff ";
				switch (curDiff) {
				case GameDiff.Easy:
					str += "easy";
					break;
				case GameDiff.Hard:
					str += "hard";
					break;
				case GameDiff.Ultra:
					str += "ultra";
					break;
				default:
					break;
				}
				sw.WriteLine (str);
				str = "Star 10/20/30";
				sw.WriteLine (str);
				for (int i = 0; i < maxRow; i++) {
					str = "";
					for (int j = 0; j < maxCol; j++) {
						str += chessList [i * maxCol + j];
						if (j != maxCol - 1) {
							str += ",";
						}
					}
					sw.WriteLine (str);
				}
				sw.Close ();
				fs.Close ();
			}
			catch (Exception e) {
				Debug.LogError (e);
			}
		} else {
			try {
				FileStream fs = new FileStream (fileName, FileMode.Open, FileAccess.Write);
				StreamWriter sw = new StreamWriter (fs);
				string str = "";
				str = "Mode ";
				switch (curGameMode) {
				case TempGameMode.Link3:
					str += "3L";
					break;
				case TempGameMode.Link4:
					str += "4L";
					break;
				case TempGameMode.Link5:
					str += "5L";
					break;
				case TempGameMode.LinkL:
					str += "LL";
					break;
				case TempGameMode.LinkJ:
					str += "JL";
					break;
				default:
					break;
				}
				sw.WriteLine (str);
				str = "Size 7/6";
				sw.WriteLine (str);
				str = "Diff ";
				switch (curDiff) {
				case GameDiff.Easy:
					str += "easy";
					break;
				case GameDiff.Hard:
					str += "hard";
					break;
				case GameDiff.Ultra:
					str += "ultra";
					break;
				default:
					break;
				}
				sw.WriteLine (str);
				str = "Star 10/20/30";
				sw.WriteLine (str);
				for (int i = 0; i < maxRow; i++) {
					str = "";
					for (int j = 0; j < maxCol; j++) {
						str += chessList [i * maxCol + j];
						if (j != maxCol - 1) {
							str += ",";
						}
					}
					sw.WriteLine (str);
				}
				sw.Close ();
				fs.Close ();
			}
			catch(Exception e) {
				Debug.LogError (e);
			}
		}
	}

	void SimulateInBasicLevel() {
		int i = 0;
		bool deadChess = false;
		bool hasAdded = false;
		int random = 0;
		int RandomDir = 0;
		int lastIndex = 0;
		//		int SimCount = Random.Range (25, 75);
//		int SimCount = 1;
		while (i < SimCount) {
			Debug.Log (i);
			//operate board
			random = UnityEngine.Random.Range(0,chessList.Count);
			Debug.Log (random);
			selectedList.Add (random);
			deadChess = false;
			for (int j = 0; j < maxLinkCount - 1; j++) {
				if (!CheckAlive (random)) {
					deadChess = true;
					Debug.Log ("deadChess");
//					i++;
					break;
				}
				RandomDir = 0;
				hasAdded = false;
				lastIndex = selectedList [selectedList.Count - 1];
				while (true) {
					RandomDir = UnityEngine.Random.Range (0, 4);
					switch (RandomDir) {
					case 0:
						if (CheckAvailable (Direction.Up)) {
							//add to list
							selectedList.Add(lastIndex - maxCol);
							hasAdded = true;
							break;
						}
						break;
					case 1:
						if (CheckAvailable (Direction.Down)) {
							//add to list
							selectedList.Add(lastIndex + maxCol);
							hasAdded = true;
							break;
						}
						break;
					case 2:
						if (CheckAvailable (Direction.Left)) {
							//add to list
							selectedList.Add(lastIndex - 1);
							hasAdded = true;
							break;
						}
						break;
					case 3:
						if (CheckAvailable (Direction.Right)) {
							//add to list
							selectedList.Add(lastIndex + 1);
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

	int maxX = 0;
	int maxY = 0;
	void SimulateInAdvanceLevel(TempGameMode gameMode) {
		int i = 0;
		int random = 0;
		int randomIndex = 0;
		int row = 0;
		int col = 0;
		int tMaxX = 0;
		int tMaxY = 0;
		bool deadChess = false;
		while (i < SimCount) {
			random = UnityEngine.Random.Range (0, chessList.Count);
			randomIndex = UnityEngine.Random.Range (0, 4);
			row = random / maxCol;
			col = random % maxCol;
			deadChess = false;
			randomIndex = 0;
			switch (randomIndex) {
			case 0:
				if (gameMode == TempGameMode.LinkJ) {
					maxX = 3;
					maxY = 3;
				} else if (gameMode == TempGameMode.LinkL) {
					maxX = 2;
					maxY = 3;
				}
				if (CheckAvailableInAdvanceMode (random, row, col)) {
					Debug.Log ("Simulate 0");
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						if(j / maxCol >= row && j % maxCol >= col && j / maxCol <= tMaxY && j % maxCol <= tMaxX) {
							//							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = j / maxCol - row;
							int answerY = j % maxCol - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j] = (chessList[j] == 0 ? 1 : 0);
						}
					}
				} else {
					deadChess = true;
				}
				break;
			case 1:
				if (gameMode == TempGameMode.LinkJ) {
					maxX = 3;
					maxY = 3;
				} else if (gameMode == TempGameMode.LinkL) {
					maxX = 3;
					maxY = 2;
				} 

				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						Debug.Log ("Simulate 1");
						if(j / maxCol >= row && j % maxCol >= col && j / maxCol <= tMaxY && j % maxCol <= tMaxX) {
//							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = j / maxCol - row;
							int answerY = j % maxCol - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j] = (chessList[j] == 0 ? 1 : 0);
						}
					}
				} else {
					deadChess = true;
				}
				break;
			case 2:
				if (gameMode == TempGameMode.LinkJ) {
					maxX = 3;
					maxY = 3;
				} else if (gameMode == TempGameMode.LinkL) {
					maxX = 2;
					maxY = 3;
				}

				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						Debug.Log ("Simulate 2");
						if(j / maxCol >= row && j % maxCol >= col && j / maxCol <= tMaxY && j % maxCol <= tMaxX) {
//							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = j / maxCol - row;
							int answerY = j % maxCol - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j] = (chessList[j] == 0 ? 1 : 0);
						}
					}
				} else {
					deadChess = true;
				}
				break;
			case 3:
				if (gameMode == TempGameMode.LinkJ) {
					maxX = 3;
					maxY = 3;
				} else if (gameMode == TempGameMode.LinkL) {
					maxX = 3;
					maxY = 2;
				}

				if (CheckAvailableInAdvanceMode (random, row, col)) {
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						Debug.Log ("Simulate 3");
						if(j / maxCol >= row && j % maxCol >= col && j / maxCol <= tMaxY && j % maxCol <= tMaxX) {
//							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
							//							chessList[j].Convert();
							int answerX = j / maxCol - row;
							int answerY = j % maxCol - col;
							if (answerList [randomIndex] [answerX * maxX + answerY] == 1)
								chessList [j] = (chessList[j] == 0 ? 1 : 0);
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

	bool CheckAlive(int itemIndex) {
		int row = itemIndex / maxCol;
		int col = itemIndex % maxCol;
		/*if (row == 0 && col == 0) {
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
		}*/
		if (row == 0 && col == 0) {
			if (SelectListContainsItem(selectedList,itemIndex + 1) && SelectListContainsItem(selectedList,itemIndex + maxCol)) {
				Debug.Log ("1");
				return false;
			}
		} else if (row == 0 && col == maxCol - 1) {
			if (SelectListContainsItem(selectedList,itemIndex - 1) && SelectListContainsItem(selectedList,itemIndex + maxCol)) {
				Debug.Log ("2");
				return false;
			}
		} else if (row == maxRow - 1 && col == 0) {
			if (SelectListContainsItem(selectedList,itemIndex + 1) && SelectListContainsItem(selectedList,itemIndex - maxCol)) {
				Debug.Log ("3");
				return false;
			}
		} else if (row == maxRow - 1 && col == maxCol - 1) {
			if (SelectListContainsItem(selectedList,itemIndex - 1) && SelectListContainsItem(selectedList,itemIndex - maxCol)) {
				Debug.Log ("4");
				return false;
			}
		}
		return true;
	}

	bool SelectListContainsItem(List<int> list, int value) {
		bool contains = false;
		for (int i = 0; i < list.Count; i++) {
			if (list [i] == value) {
				contains = true;
				break;
			}
		}
		return contains;
	}

	void ConvertItems() {
		for (int i = 0; i < selectedList.Count; i++) {
			if (curDiff == GameDiff.Easy) {
				chessList[selectedList [i]] = (chessList[selectedList [i]] == 0 ? 1 : 0);
			} else if (curDiff == GameDiff.Hard) {
				if (i != maxLinkCount / 2) {
					chessList[selectedList [i]] = (chessList[selectedList [i]] == 0 ? 1 : 0);
				}
			} else if (curDiff == GameDiff.Ultra) {
				if (i == (maxLinkCount / 2 + 1) || i == (maxLinkCount / 2 - 1)) {
					// do nothing
				}
				else {
					chessList[selectedList [i]] = (chessList[selectedList [i]] == 0 ? 1 : 0);
				}
			}
		}
	}

	bool CheckAvailable(Direction dir) {
		if(selectedList.Count == 0)
			return true;
		//get row and col of the last item
		int curIndex = selectedList[selectedList.Count - 1];
		int row = curIndex / maxCol;
		int col = curIndex % maxCol;
		switch (dir) {
		case Direction.Up:
			if (row == 0)
				return false;
			else if (SelectListContainsItem(selectedList, curIndex - maxCol))
				return false;
			break;
		case Direction.Down:
			if (row == maxRow - 1)
				return false;
			else if (SelectListContainsItem(selectedList, curIndex + maxCol))
				return false;
			break;
		case Direction.Left:
			if (col == 0)
				return false;
			else if (SelectListContainsItem(selectedList, curIndex - 1))
				return false;
			break;
		case Direction.Right:
			if (col == maxCol - 1)
				return false;
			else if (SelectListContainsItem(selectedList, curIndex + 1))
				return false;
			break;
		default:
			break;
		}
		return true;
	}

	void printChessList() {
		string str = "";
		for (int i = 0; i < maxRow; i++) {
			str = "";
			for (int j = 0; j < maxCol; j++) {
				str += chessList [i * maxCol + j];
				if (j != maxCol - 1) {
					str += ",";
				}
			}
			Debug.Log (str);
		}
	}

	public void SetLinkModeData() {
		answerList.Clear ();
		if (curGameMode == TempGameMode.LinkJ) {
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
//			string str = "";
//			for (int i = 0; i < answerList.Count; i++) {
//				str = "";
//				for (int j = 0; j < answerList [i].Count; j++) {
//					str += answerList [i] [j] + " ";
//				}
//				Debug.Log (str);
//			}
		} else if (curGameMode == TempGameMode.LinkL) {
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

//			string str = "";
//			for (int i = 0; i < answerList.Count; i++) {
//				str = "";
//				for (int j = 0; j < answerList [i].Count; j++) {
//					str += answerList [i] [j] + " ";
//				}
//				Debug.Log (str);
//			}
		}
	}

	void ConfigureLList() {
		switch (curDiff) {
		case GameDiff.Easy:
			LList.Add (1);
			LList.Add (0);
			LList.Add (1);
			LList.Add (0);
			LList.Add (1);
			LList.Add (1);
			break;
		case GameDiff.Hard:
			LList.Add (1);
			LList.Add (0);
			LList.Add (1);
			LList.Add (0);
			LList.Add (0);
			LList.Add (1);
			break;
		case GameDiff.Ultra:
			LList.Add (1);
			LList.Add (0);
			LList.Add (0);
			LList.Add (0);
			LList.Add (1);
			LList.Add (0);
			break;
		default:
			break;
		}
	}

	void ConfigureJList() {
		JList.Clear ();
		switch (curDiff) {
		case GameDiff.Easy:
			JList.Add (1);
			JList.Add (1);
			JList.Add (1);
			JList.Add (0);
			JList.Add (0);
			JList.Add (1);
			JList.Add (0);
			JList.Add (1);
			JList.Add (1);
			break;
		case GameDiff.Hard:
			JList.Add (1);
			JList.Add (1);
			JList.Add (1);
			JList.Add (0);
			JList.Add (0);
			JList.Add (0);
			JList.Add (0);
			JList.Add (1);
			JList.Add (1);
			break;
		case GameDiff.Ultra:
			JList.Add (1);
			JList.Add (1);
			JList.Add (0);
			JList.Add (0);
			JList.Add (0);
			JList.Add (1);
			JList.Add (0);
			JList.Add (1);
			JList.Add (0);
			break;
		default:
			break;
		}
	}
}
