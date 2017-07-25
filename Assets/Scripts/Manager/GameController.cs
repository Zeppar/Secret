using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController manager = null;
	public int maxCol = 0;
	public int maxRow = 0;
	public int star1Time = 0;
	public int star2Time = 0;
	public int star3Time = 0;
	public List<int> chessValueList;
	public List<ChessItem> chessList;
	public bool hasStartGame = false;
	public bool hasStartLink = false;
	public List<ChessItem> selectedList = new List<ChessItem>();
	public int LinkCount = 0;
	public int maxLinkCount = 3;
	public ShowMode curShowMode = ShowMode.After;
	public LinkMode curLinkMode = LinkMode.Basic;
	public GameDiff curDiff = GameDiff.Easy;
	public List<AnswerPanel> answerPanelList;
	public List<List<int>> answerList = new List<List<int>> (4);
	public List<SimulateItem> simulateList = new List<SimulateItem> ();
	public List<int> ctmAnswerList = new List<int> ();
	public List<SimulateItem> tempSimulateSelectedList = new List<SimulateItem> ();
	public List<SimulateItem> simulateSelectedList = new List<SimulateItem> ();
	public bool hasStartSimulate = false;
	public bool hasConfirmSimulate = false;
	public int SimulateLinkCount = 0;
	public LineMode curLineMode = LineMode.Show;
	public float timer = 0;
	public int step = 0;
	public bool pauseGame = false;
	public bool JLinkMode = false;
	public bool LLinkMode = false;
	public bool CtmLinkMode = false;
	public List<int> LList = new List<int> (6);
	public List<int> JList = new List<int> (9);
	public int maxX = 0;
	public int maxY = 0;
	int simulateMaxX = 0;
	int simulateMaxY = 0;
	public GameMode curGameMode;
	public ChallengeMode challengeMode = ChallengeMode.Easy;
	public int score = 0;
	public int challengeLevel = 1;
	public List<int> LAnswerList = new List<int> (4);
	public List<int> JAnswerList = new List<int> (6);

	void Awake() {
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
		} else if (manager != this) {
			Destroy (gameObject);
		}
	}


	void Start() {
		//init sound
		SoundManager.manager.InitSound ();
		//init music panel
		SoundManager.manager.PlayRandomBgMusic ();
		NotificationCenter.defaultCenter.PostNotification(new Notification("InitMusicList", null), NotificationLayer.Sound);
		//Load Level
		LevelManager.manager.LoadAllLevelInfo();
		//Load Common
		LevelManager.manager.LoadAllCommonData();
		//Load Challenge
		LevelManager.manager.LoadChallengeData();
		//init L List
		LAnswerList.Add(0);
		LAnswerList.Add(3);
		LAnswerList.Add(6);
		LAnswerList.Add(7);
		//init J List
		JAnswerList.Add(0);
		JAnswerList.Add(1);
		JAnswerList.Add(2);
		JAnswerList.Add(5);
		JAnswerList.Add(8);
		JAnswerList.Add(7);
	}

	//convert items state
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

	//check if the game is over
	public bool CheckIfWinTheGame() {
		ChessType type = chessList [0].curType;
		bool win = true;
		for (int i = 0; i < chessList.Count; i++) {
			if (chessList [i].curType != type) {
				win = false;
				break;
			}
		}
		NotificationCenter.defaultCenter.PostNotification (new Notification ("updateItemCount", null), NotificationLayer.UI);
		return win;
	}

	/*public void RevertItemsInShowModeNow() {
		for (int i = 0; i < selectedList.Count; i++) {
			if (curDiff == GameDiff.Easy || curDiff == GameDiff.Super) {
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
	}*/

	public void ShowWinOperation() {
		hasStartGame = false;
		ResetToNormal ();
		if (curGameMode == GameMode.Mission) {
			GameController.manager.score = 1000 - (int)GameController.manager.timer - GameController.manager.step * 5;
			LevelManager.manager.WriteLevelDataToFile ();
			NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowMissionWinPanel", null), NotificationLayer.UI);
		} else if (curGameMode == GameMode.Free) {
			GameController.manager.score = 1000 - (int)GameController.manager.timer - GameController.manager.step * 5;
			LevelManager.manager.WriteCommonDataToFile ();
			NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowFreeWinPanel", null), NotificationLayer.UI);
		} else if (curGameMode == GameMode.Custom) {
			GameController.manager.score = 1000 - (int)GameController.manager.timer - GameController.manager.step * 5;
			LevelManager.manager.WriteCommonDataToFile ();
			NotificationCenter.defaultCenter.PostNotification(new Notification ("ShowCustomWinPanel", null), NotificationLayer.UI);
		} else if (curGameMode == GameMode.Challenge) {
			hasStartGame = true;
			timer += 30f;
			challengeLevel++;
			LevelManager.manager.createChallengeScene ();
			step = 0;
		}
	}

	//reset data to normal state
	public void ResetToNormal() {
		hasStartGame = false;
		hasStartLink = false;
		LinkCount = 0;
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
		ResetSimulate ();
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ResetSimulatePanel", null), NotificationLayer.UI);
//		ResetSimulteByResetBtn ();
		LevelManager.manager.DestoryItems ();

	}

	//reset simualte data to normal
	public void ResetSimulate() {
		if (!(curGameMode == GameMode.Custom && CtmLinkMode))
			ctmAnswerList.Clear ();
		for (int i = 0; i < tempSimulateSelectedList.Count; i++) {
			tempSimulateSelectedList [i].reset ();
		}
		tempSimulateSelectedList.Clear ();
		hasStartSimulate = false;
		hasConfirmSimulate = false;
	}

	//TODO uselessful ????
	public void ResetSimulteByResetBtn() {
		for (int i = 0; i < simulateSelectedList.Count; i++) {
			simulateSelectedList [i].reset();
		}
		simulateSelectedList.Clear ();
		tempSimulateSelectedList.Clear ();
		hasConfirmSimulate = false;
		SimulateLinkCount = 0;
	}

	//check if the pattern is fit for answers
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
//		int count = 0;
		for (int i = 0; i < chessList.Count; i++) {
			if (chessList [i].col >= minX && chessList [i].row >= minY && chessList [i].col <= maxX && chessList [i].row <= maxY) {	
				// 不使用select进行判断
//				tempList.Add (chessList [i].isSelected ? 1 : 0);
				if (selectedList.Contains (chessList [i]) && chessList[i].isSelected) {
					tempList.Add (1);
				} else {
					tempList.Add (0);
				}
			}
		}

		string str = "";
		for (int i = 0; i < tempList.Count; i++) {
			str += tempList [i].ToString ();
		}
		print (str);

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

	void Update() {

		ShowSelectedItems ();
		if (!hasStartGame) {
			if (hasConfirmSimulate)
				ShowSimulateSelectItem ();
			else
				ShowTempSimualteSelectItem ();
			ShowSimulateLine ();
		} else {
			if (!GameController.manager.pauseGame) {
				if (curGameMode == GameMode.Challenge) {
					timer -= Time.deltaTime;
					if (timer <= 0) {
						GameController.manager.hasStartGame = false;
						GameController.manager.score = 1000 * challengeLevel - GameController.manager.step * 5;
						NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowChallengeWinPanel", null), NotificationLayer.UI);
					}
				}
				else
					timer += Time.deltaTime;
			}
		}

		if (curLineMode == LineMode.Show) {
			ShowLine ();
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
					} else {
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

	//get star count from the result
	public int GetStarLevel() {
		if (timer <= star3Time) {
			return 3;
		} else if (timer <= star2Time) {
			return 2;
		} else if (timer <= star1Time) {
			return 1;
		}
		return 0;
	}

	//setData
	public void SetLinkModeData(AdvanceLinkMode alm) {
		answerList.Clear ();
		if (alm == AdvanceLinkMode.J) {
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
				List<int> temp = new List<int> (9);
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

	//llist
	void ConfigureLList() {
//		LList.Clear ();
//		LList.Add (1);
//		LList.Add (0);
//		LList.Add (1);
//		LList.Add (0);
//		LList.Add (1);
//		LList.Add (1);
		switch (GameController.manager.curDiff) {
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

	//jlist
	void ConfigureJList() {
		JList.Clear ();
//		JList.Add (1);
//		JList.Add (1);
//		JList.Add (1);
//		JList.Add (0);
//		JList.Add (0);
//		JList.Add (1);
//		JList.Add (0);
//		JList.Add (1);
//		JList.Add (1);
		switch (GameController.manager.curDiff) {
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

	//set data to answer panel
	public void setAnswerPanelData() {
		for (int i = 0; i < answerPanelList.Count; i++) {
			if (JLinkMode) {
				maxX = 3;
				maxY = 3;
				answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
			} else if (LLinkMode) {
				switch (i) {
				case 0:
					maxX = 2;
					maxY = 3;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				case 1:
					maxX = 3;
					maxY = 2;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				case 2:
					maxX = 2;
					maxY = 3;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				case 3:
					maxX = 3;
					maxY = 2;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				default:
					break;
				}
			} else if (CtmLinkMode) {
				switch (i) {
				case 0:
					maxX = simulateMaxX;
					maxY = simulateMaxY;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				case 1:
					maxX = simulateMaxY;
					maxY = simulateMaxX;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				case 2:
					maxX = simulateMaxX;
					maxY = simulateMaxY;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				case 3:
					maxX = simulateMaxY;
					maxY = simulateMaxX;
					answerPanelList [i].setAnswerList (answerList[0], maxX, maxY);
					break;
				default:
					break;
				}
//				maxX = simulateMaxX;
//				maxY = simulateMaxY;
//				answerPanelList [i].setAnswerList (answerList[i], maxX, maxY);
			}
		}
	}

	public void SimulateInBasicLevel () {
		int i = 0;
		bool deadChess = false;
		bool hasAdded = false;
		int random = 0;
		int RandomDir = 0;
		int lastIndex = 0;
//		int SimCount = Random.Range (25, 75);
		int SimCount = 1;
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

	public void SimulateInAdvanceLevel() {
		int i = 0;
		int random = 0;
		int randomIndex = 0;
		int row = 0;
		int col = 0;
		int tMaxX = 0;
		int tMaxY = 0;
		bool deadChess = false;
//		int SimCount = Random.Range (25, 75);
		int SimCount = 1;
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
					print ("0");
					tMaxX = col + maxX - 1;
					tMaxY = row + maxY - 1;
					for(int j = 0;j < chessList.Count;j++) {
						if(chessList[j].row >= row && chessList[j].col >= col && chessList[j].row <= tMaxY && chessList[j].col <= tMaxX) {
//							print ("row : " + chessList [j].row + " col : " + chessList [j].col);
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
					print ("1");
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
					print ("2");
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
					print ("3");
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

	//check if the random index is availble
	bool CheckAvailableInAdvanceMode(int randomIndex, int row, int col) {
		if (row + maxY - 1 > maxRow - 1)
			return false;
		if (col + maxX - 1 > maxCol - 1)
			return false;
		return true;
	}

	//judge if the item is alive
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

	//check if the item in dir i available
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

	//number of simulate list must bigger than 3
	public bool CheckSimulateAvailable() {
		return SimulateLinkCount >= 3;
	}

	//set temp simulate list to true simulate list
	public void ConfirmSimulateList() {
		simulateSelectedList.Clear ();
		for (int i = 0; i < tempSimulateSelectedList.Count; i++) {
			simulateSelectedList.Add (tempSimulateSelectedList [i]);
		}
	}

	//cal answerList in custom mode
	public void CalculateCtmList() {
		print ("CalculateCtmList");
		int tMinX = 3;
		int tMinY = 3;
		int tMaxX = 0;
		int tMaxY = 0;

		ctmAnswerList.Clear ();

		for (int i = 0; i < simulateSelectedList.Count; i++) {
//			print ("row : " + simulateSelectedList [i].row + " col : " + simulateSelectedList [i].col);
			if (simulateSelectedList [i].col >= tMaxX)
				tMaxX = simulateSelectedList [i].col;
			if (simulateSelectedList [i].col <= tMinX)
				tMinX = simulateSelectedList [i].col;
			if (simulateSelectedList [i].row >= tMaxY)
				tMaxY = simulateSelectedList [i].row;
			if (simulateSelectedList [i].row <= tMinY)
				tMinY = simulateSelectedList [i].row;
		}

//		print (tMinX);
//		print (tMaxX);
//		print (tMinY);
//		print (tMaxY);

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
//		print ("ctm list : " + str);

	}

	//clear temp simulate list
	public void ClearAllSimulateItems() {
		for (int i = 0; i < tempSimulateSelectedList.Count; i++)
			tempSimulateSelectedList [i].Convert ();
		tempSimulateSelectedList.Clear ();
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

	public void printIntList(List<int> list) {
		string str = "";
		for (int i = 0; i < list.Count; i++) {
			str += list [i];
			str += "";
		}
		print (str);
	}

	public int getItemsCount(ChessType type) {
		int count = 0;
		for (int i = 0; i < chessList.Count; i++) {
			if (chessList [i].curType == type)
				count++;
		}
		return count;
	}

}
