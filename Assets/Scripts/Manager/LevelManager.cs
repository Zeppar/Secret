using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class LevelInfo {
	public bool isLocked;
	public int score;
	public int starCount;
	public int stepCount;
	public float timer;
}

[Serializable]
public class CommonInfo {
	public int score;
	public float timer;
}

[Serializable]
public class LevelList {
	public List<LevelInfo> levelList = new List<LevelInfo> ();
}

[Serializable]
public class CommonList {
	public List<CommonInfo> CommonList3L = new List<CommonInfo> (3);
	public List<CommonInfo> CommonList4L = new List<CommonInfo> (3);
	public List<CommonInfo> CommonList5L = new List<CommonInfo> (3);
	public List<CommonInfo> CommonListLL = new List<CommonInfo> (3);
	public List<CommonInfo> CommonListJL = new List<CommonInfo> (3);
}

[Serializable]
public class ChallengeInfo {
	public int score;
	public int level;
	public string creator;
}

public class LevelManager : MonoBehaviour {

	public static LevelManager manager = null;
	public ChessItem chessItemPrefab;
	public Transform content;
	public float itemWidth = 0.85f;
	public float itemHeight = 0.85f;
	public int currentLevel = 0;
	public int levelCount = 99;
	public LevelList allLevelList;
	public CommonList allCommonList = new CommonList ();
	public ChallengeInfo challengeInfo = new ChallengeInfo ();

	void Awake() {
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
		} else if (manager != this) {
			Destroy (gameObject);
		}
	}

	// load next level
	public void LoadNextLevel() {
		LoadLevel (currentLevel + 1);
	}
		
	//load certain level
	public void LoadLevel(int level) {
		currentLevel = level;
		string filepath = "level_" + level.ToString ();
		string fullPath = "levelInfo/" + filepath;
//		string text = Resources.Load (fullPath).ToString ();
		TextAsset textAsset = Resources.Load(fullPath) as TextAsset;
		//parse
		print("Load filepath data : " + fullPath);
		print ("text : " + textAsset.text);
		string[] lines = textAsset.text.Split(new char[] {'\n'});
		string mode = "mode";
		for (int i = 0; i < lines.Length; i++) {
			string line = lines [i];
			if (line.StartsWith ("Mode")) {
				mode = line.Replace ("Mode", string.Empty).Trim ();
				switch (mode) {
				case "3L":
					GameController.manager.maxLinkCount = 3;
					GameController.manager.curLinkMode = LinkMode.Basic;
					GameController.manager.JLinkMode = false;
					GameController.manager.LLinkMode = false;
					GameController.manager.CtmLinkMode = false;
					GameController.manager.hasStartGame = true;
					break;
				case "4L":
					GameController.manager.maxLinkCount = 4;
					GameController.manager.curLinkMode = LinkMode.Basic;
					GameController.manager.JLinkMode = false;
					GameController.manager.LLinkMode = false;
					GameController.manager.CtmLinkMode = false;
					GameController.manager.hasStartGame = true;
					break;
				case "5L":
					GameController.manager.maxLinkCount = 5;
					GameController.manager.curLinkMode = LinkMode.Basic;
					GameController.manager.JLinkMode = false;
					GameController.manager.LLinkMode = false;
					GameController.manager.CtmLinkMode = false;
					GameController.manager.hasStartGame = true;
					break;
				case "LL":
					GameController.manager.maxLinkCount = 4;
					GameController.manager.curLinkMode = LinkMode.Advance;
					GameController.manager.JLinkMode = false;
					GameController.manager.LLinkMode = true;
					GameController.manager.CtmLinkMode = false;
					GameController.manager.hasStartGame = true;
					break;
				case "JL":
					GameController.manager.maxLinkCount = 6;
					GameController.manager.curLinkMode = LinkMode.Advance;
					GameController.manager.JLinkMode = true;
					GameController.manager.LLinkMode = false;
					GameController.manager.CtmLinkMode = false;
					GameController.manager.hasStartGame = true;
					break;
				default:
					break;
				}
			} else if (line.StartsWith ("Diff")) {
				string diff = line.Replace ("Diff", string.Empty).Trim ();
				switch (diff) {
				case "easy":
					GameController.manager.curDiff = GameDiff.Easy;
					break;
				case "hard":
					GameController.manager.curDiff = GameDiff.Hard;
					break;
				case "ultra":
					GameController.manager.curDiff = GameDiff.Ultra;
					break;
				default:
					break;
				}
			} else if (line.StartsWith ("Size")) {
				string size = line.Replace ("Size", string.Empty).Trim ();
				string[] s = size.Split (new char[] { '/' });
				GameController.manager.maxCol = int.Parse (s [0]);
				GameController.manager.maxRow = int.Parse (s [1]);
				GameController.manager.chessValueList = new List<int> (GameController.manager.maxCol * GameController.manager.maxRow);
				GameController.manager.chessList = new List<ChessItem> (GameController.manager.maxCol * GameController.manager.maxRow);
			} else if (line.StartsWith ("Star")) {
				string star = line.Replace ("Star", string.Empty).Trim ();
				string[] s = star.Split (new char[] { '/' });
				GameController.manager.star3Time = int.Parse (s [0]);
				GameController.manager.star2Time = int.Parse (s [1]);
				GameController.manager.star1Time = int.Parse (s [2]);
			} else if (line.StartsWith ("level")) {
				continue;
			} else {
				string[] s = line.Split (new char[] { ',' });
				for (int j = 0; j < s.Length; j++) {
					GameController.manager.chessValueList.Add (int.Parse(s [j]));
				}
			}
		}
		print ("finish parsing data");
		AddChessItems ();

		if (GameController.manager.JLinkMode) {
			GameController.manager.SetLinkModeData (AdvanceLinkMode.J);
		} else if (GameController.manager.LLinkMode) {
			GameController.manager.SetLinkModeData (AdvanceLinkMode.L);
		} else if (GameController.manager.CtmLinkMode) {
			GameController.manager.SetLinkModeData (AdvanceLinkMode.CTM);
		}
		GameController.manager.setAnswerPanelData ();

		Hashtable table = new Hashtable ();
		table ["level"] = level;
		table ["mode"] = mode;
		print ("Post Notification");
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowLevelBottomData", table), NotificationLayer.UI);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("updateItemCount", null), NotificationLayer.UI);
	}

	//add chessitem to gamelayer
	public void AddChessItems() {
		float originX = 0;
		float originY = 0;
		float offset = 0.1f;
		itemWidth = chessItemPrefab.GetComponent<Renderer> ().bounds.size.x;
		itemHeight = chessItemPrefab.GetComponent<Renderer> ().bounds.size.y;
		if (GameController.manager.maxCol % 2 == 0) {
			originX = -0.5f * offset - (GameController.manager.maxCol / 2) * (itemWidth + offset) + 0.5f * itemWidth;
			if (GameController.manager.maxRow % 2 == 0) {
				originY = -0.5f * offset + (GameController.manager.maxRow / 2) * (itemHeight + offset) - 0.5f * itemHeight;
			} else {
				originY = -0.5f * itemHeight + (GameController.manager.maxRow / 2) * (itemHeight + offset) - 0.5f * itemHeight;
			}
		} else {
			originX = -0.5f * itemWidth - (GameController.manager.maxCol / 2) * (itemWidth + offset) + 0.5f * itemWidth;
			if (GameController.manager.maxRow % 2 == 0) {
				originY = -0.5f * offset + (GameController.manager.maxRow / 2) * (itemHeight + offset) - 0.5f * itemHeight;
			} else {
				originY = -0.5f * itemHeight + (GameController.manager.maxRow / 2) * (itemHeight + offset) - 0.5f * itemHeight;
			}
		}
		for (int i = 0; i < GameController.manager.maxRow; i++) {
			for (int j = 0; j < GameController.manager.maxCol; j++) {
				ChessItem item = (ChessItem)PoolManager.manager.getPool (chessItemPrefab).getObject ();
				item.transform.SetParent (content);
				item.transform.localPosition = new Vector3 (originX + j * (offset + itemWidth), originY - i * (offset + itemHeight), 0);
				item.setIndex (i * GameController.manager.maxCol + j);
				item.setType (GameController.manager.chessValueList[i * GameController.manager.maxCol + j] == 1 ? ChessType.Black : ChessType.White);
				GameController.manager.chessList.Add (item);
			}
		}
	}

	//return all chessitems to ObjectPool
	public void DestoryItems() {
		for (int i = GameController.manager.chessList.Count - 1; i >=0; i--) {
			GameController.manager.chessList [i].returnToPool ();
			GameController.manager.chessList [i].reset ();
		}
		GameController.manager.chessList.Clear ();
	}

	//load mission levelinfo from file levelInfo.data 
	public void LoadAllLevelInfo() {
		string filePath = Path.Combine (Application.persistentDataPath, "LevelInfo.data");
		if (!File.Exists (filePath)) {
			print ("Don not exist : " + filePath);
			LevelList list = new LevelList ();
			for (int i = 0; i < levelCount; i++) {
				LevelInfo info = new LevelInfo ();
				if(i == 0)
					info.isLocked = false;
				else 
					info.isLocked = true;
				info.starCount = 0;
				info.score = 0;
				info.stepCount = 0;
				info.timer = 0;
				list.levelList.Add (info);
			}
			SerializeLevelInfoMethod (filePath, list);
			allLevelList = list;
		} else {
			print ("exist level");
			DeserializeLevelInfoMethod (filePath);
		}
	}

	//Deserialize
	void DeserializeLevelInfoMethod(string filePath) {
		FileStream fs = new FileStream (filePath, FileMode.Open);
		BinaryFormatter bf = new BinaryFormatter ();
		LevelList list = bf.Deserialize (fs) as LevelList;
		allLevelList = list;
		fs.Close ();
	}

	//Serialize 
	void SerializeLevelInfoMethod(string filePath, LevelList list) {
		FileStream fs = new FileStream (filePath, FileMode.Create);
		BinaryFormatter bf = new BinaryFormatter ();
		bf.Serialize (fs, list);
		fs.Close ();
	}

	public void LoadAllCommonData() {
		string filePath = Path.Combine (Application.persistentDataPath, "CommonInfo.data");
		if (!File.Exists (filePath)) {
			print ("Don not exist : " + filePath);
			for (int i = 0; i < 3; i++) {
				CommonInfo info = new CommonInfo ();
				info.score = 0;
				info.timer = 3600;
				allCommonList.CommonList3L.Add (info);
			}
			for (int i = 0; i < 3; i++) {
				CommonInfo info = new CommonInfo ();
				info.score = 0;
				info.timer = 3600;
				allCommonList.CommonList4L.Add (info);
			}
			for (int i = 0; i < 3; i++) {
				CommonInfo info = new CommonInfo ();
				info.score = 0;
				info.timer = 3600;
				allCommonList.CommonList5L.Add (info);
			}
			for (int i = 0; i < 3; i++) {
				CommonInfo info = new CommonInfo ();
				info.score = 0;
				info.timer = 3600;
				allCommonList.CommonListLL.Add (info);
			}
			for (int i = 0; i < 3; i++) {
				CommonInfo info = new CommonInfo ();
				info.score = 0;
				info.timer = 3600;
				allCommonList.CommonListJL.Add (info);
			}
			SerializeCommonInfoMethod (filePath, allCommonList);
		} else {
			print ("exist common");
			DeserializeCommonInfoMethod (filePath);
		}
	}

	//Deserialize
	void DeserializeCommonInfoMethod(string filePath) {
		FileStream fs = new FileStream (filePath, FileMode.Open);
		BinaryFormatter bf = new BinaryFormatter ();
		allCommonList = bf.Deserialize (fs) as CommonList;
		fs.Close ();
	}

	//Serialize 
	void SerializeCommonInfoMethod(string filePath, CommonList list) {
		FileStream fs = new FileStream (filePath, FileMode.Create);
		BinaryFormatter bf = new BinaryFormatter ();
		bf.Serialize (fs, list);
		fs.Close ();
	}

	public void WriteCommonDataToFile() {
		CommonInfo commonInfo = null;
		switch (GameController.manager.curLinkMode) {
		case LinkMode.Basic:
			switch (GameController.manager.maxLinkCount) {
			case 3:
				switch (GameController.manager.curDiff) {
				case GameDiff.Easy:
					commonInfo = allCommonList.CommonList3L [0];
					break;
				case GameDiff.Hard:
					commonInfo = allCommonList.CommonList3L [1];
					break;
				case GameDiff.Ultra:
					commonInfo = allCommonList.CommonList3L [2];
					break;
				default:
					break;
				}
				break;
			case 4:
				switch (GameController.manager.curDiff) {
				case GameDiff.Easy:
					commonInfo = allCommonList.CommonList4L [0];
					break;
				case GameDiff.Hard:
					commonInfo = allCommonList.CommonList4L [1];
					break;
				case GameDiff.Ultra:
					commonInfo = allCommonList.CommonList4L [2];
					break;
				default:
					break;
				}
				break;
			case 5:
				switch (GameController.manager.curDiff) {
				case GameDiff.Easy:
					commonInfo = allCommonList.CommonList5L [0];
					break;
				case GameDiff.Hard:
					commonInfo = allCommonList.CommonList5L [1];
					break;
				case GameDiff.Ultra:
					commonInfo = allCommonList.CommonList5L [2];
					break;
				default:
					break;
				}
				break;
			default:
				break;
			}
			break;
		case LinkMode.Advance:
			switch (GameController.manager.curDiff) {
			case GameDiff.Easy:
				if (GameController.manager.JLinkMode) {
					commonInfo = allCommonList.CommonListJL [0];
				} else if (GameController.manager.LLinkMode) {
					commonInfo = allCommonList.CommonListLL [0];
				}
				break;
			case GameDiff.Hard:
				if (GameController.manager.JLinkMode) {
					commonInfo = allCommonList.CommonListJL [1];
				} else if (GameController.manager.LLinkMode) {
					commonInfo = allCommonList.CommonListLL [1];
				}
				break;
			case GameDiff.Ultra:
				if (GameController.manager.JLinkMode) {
					commonInfo = allCommonList.CommonListJL [2];
				} else if (GameController.manager.LLinkMode) {
					commonInfo = allCommonList.CommonListLL [2];
				}
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}
		if (GameController.manager.score >= commonInfo.score)
			commonInfo.score = GameController.manager.score;
		if(GameController.manager.timer <= commonInfo.timer)
			commonInfo.timer = GameController.manager.timer;
		string filePath = Path.Combine (Application.persistentDataPath, "CommonInfo.data");
		SerializeCommonInfoMethod (filePath, allCommonList);
	}

	//write new information to file levelInfo.data when certain level has been passed
	public void WriteLevelDataToFile() {
		string filePath = Path.Combine (Application.persistentDataPath, "LevelInfo.data");
		LevelInfo info = new LevelInfo ();
		info.isLocked = false;
		info.starCount = GameController.manager.GetStarLevel ();
		info.stepCount = GameController.manager.step;
		info.timer = GameController.manager.timer;
		info.score = (1000 + GameController.manager.GetStarLevel() * 100 - (int)GameController.manager.timer - GameController.manager.step * 5);
		if(allLevelList.levelList[LevelManager.manager.currentLevel].score <= info.score)
			allLevelList.levelList [LevelManager.manager.currentLevel] = info;

		if ((LevelManager.manager.currentLevel + 1 < LevelManager.manager.levelCount) && allLevelList.levelList [LevelManager.manager.currentLevel + 1].isLocked) {
			print ("next");
			LevelInfo nextInfo = new LevelInfo ();
			nextInfo.isLocked = false;
			nextInfo.starCount = 0;
			nextInfo.score = 0;
			nextInfo.stepCount = 0;
			nextInfo.timer = 0;
			allLevelList.levelList [LevelManager.manager.currentLevel + 1] = nextInfo;
		}
		SerializeLevelInfoMethod (filePath, allLevelList);
	}

	public void createChallengeScene() {
		GameController.manager.maxCol = 7;
		GameController.manager.maxRow = 6;
		GameController.manager.chessValueList = new List<int> (GameController.manager.maxCol * GameController.manager.maxRow);
		for (int i = 0; i < GameController.manager.maxCol * GameController.manager.maxRow; i++) {
			GameController.manager.chessValueList.Add (0);
		}
		AddChessItems ();

		int index = 0;
		switch (GameController.manager.challengeMode) {
		case ChallengeMode.Easy:
			index = UnityEngine.Random.Range (0, 3);
			if (index == 0) {
				GameController.manager.maxLinkCount = 3;
			} else if (index == 1) {
				GameController.manager.maxLinkCount = 4;
			} else if (index == 2) {
				GameController.manager.maxLinkCount = 5;
			}
			GameController.manager.curLinkMode = LinkMode.Basic;
			GameController.manager.JLinkMode = false;
			GameController.manager.LLinkMode = false;
			GameController.manager.CtmLinkMode = false;
			GameController.manager.hasStartGame = true;
			GameController.manager.SimulateInBasicLevel ();
			break;
		case ChallengeMode.Middle:
			index = UnityEngine.Random.Range (0, 2);
			if (index == 0) {
				GameController.manager.maxLinkCount = 4;
				GameController.manager.JLinkMode = false;
				GameController.manager.LLinkMode = true;
				GameController.manager.SetLinkModeData (AdvanceLinkMode.L);
				GameController.manager.setAnswerPanelData ();
			} else if (index == 1) {
				GameController.manager.maxLinkCount = 6;
				GameController.manager.JLinkMode = true;
				GameController.manager.LLinkMode = false;
				GameController.manager.SetLinkModeData (AdvanceLinkMode.J);
				GameController.manager.setAnswerPanelData ();
			}
			GameController.manager.curLinkMode = LinkMode.Advance;
			GameController.manager.CtmLinkMode = false;
			GameController.manager.hasStartGame = true;
			GameController.manager.SimulateInAdvanceLevel ();
			break;
		case ChallengeMode.Hard:
			break;
		default:
			break;
		}
	}

	public void createFreeScene() {
		GameController.manager.hasStartGame = true;
		GameController.manager.maxCol = 7;
		GameController.manager.maxRow = 6;
		GameController.manager.chessValueList = new List<int> (GameController.manager.maxCol * GameController.manager.maxRow);
		for (int i = 0; i < GameController.manager.maxCol * GameController.manager.maxRow; i++) {
			GameController.manager.chessValueList.Add (0);
		}
		LevelManager.manager.AddChessItems ();
		GameController.manager.SimulateInBasicLevel ();
	}

	public void createLModeScene() {
		GameController.manager.maxLinkCount = 4;
		GameController.manager.curLinkMode = LinkMode.Advance;
		GameController.manager.JLinkMode = false;
		GameController.manager.LLinkMode = true;
		GameController.manager.CtmLinkMode = false;
		GameController.manager.hasStartGame = true;
		GameController.manager.maxCol = 7;
		GameController.manager.maxRow = 6;
		GameController.manager.chessValueList = new List<int> (GameController.manager.maxCol * GameController.manager.maxRow);
		for (int i = 0; i < GameController.manager.maxCol * GameController.manager.maxRow; i++) {
			GameController.manager.chessValueList.Add (0);
		}
		LevelManager.manager.AddChessItems ();
		GameController.manager.SetLinkModeData (AdvanceLinkMode.L);
		GameController.manager.setAnswerPanelData ();
		GameController.manager.SimulateInAdvanceLevel ();
	}

	public void createJModeScene() {
		GameController.manager.maxLinkCount = 6;
		GameController.manager.curLinkMode = LinkMode.Advance;
		GameController.manager.JLinkMode = true;
		GameController.manager.LLinkMode = false;
		GameController.manager.CtmLinkMode = false;
		GameController.manager.hasStartGame = true;
		GameController.manager.maxCol = 7;
		GameController.manager.maxRow = 6;
		GameController.manager.chessValueList = new List<int> (GameController.manager.maxCol * GameController.manager.maxRow);
		for (int i = 0; i < GameController.manager.maxCol * GameController.manager.maxRow; i++) {
			GameController.manager.chessValueList.Add (0);
		}
		LevelManager.manager.AddChessItems ();
		GameController.manager.SetLinkModeData (AdvanceLinkMode.J);
		GameController.manager.setAnswerPanelData ();
		GameController.manager.SimulateInAdvanceLevel ();
	}

	public void createCTMModeScene() {
		GameController.manager.hasConfirmSimulate = true;
		GameController.manager.hasStartGame = true;
		GameController.manager.maxCol = 7;
		GameController.manager.maxRow = 6;
		GameController.manager.chessValueList = new List<int> (GameController.manager.maxCol * GameController.manager.maxRow);
		for (int i = 0; i < GameController.manager.maxCol * GameController.manager.maxRow; i++) {
			GameController.manager.chessValueList.Add (0);
		}
		LevelManager.manager.AddChessItems ();
		GameController.manager.SetLinkModeData (AdvanceLinkMode.CTM);
		GameController.manager.setAnswerPanelData ();
		GameController.manager.SimulateInAdvanceLevel ();
	}

	public CommonInfo GetCurrentCommonInfo() {
		CommonInfo commonInfo = null;
		switch (GameController.manager.curLinkMode) {
		case LinkMode.Basic:
			switch (GameController.manager.maxLinkCount) {
			case 3:
				switch (GameController.manager.curDiff) {
				case GameDiff.Easy:
					commonInfo = allCommonList.CommonList3L [0];
					break;
				case GameDiff.Hard:
					commonInfo = allCommonList.CommonList3L [1];
					break;
				case GameDiff.Ultra:
					commonInfo = allCommonList.CommonList3L [2];
					break;
				default:
					break;
				}
				break;
			case 4:
				switch (GameController.manager.curDiff) {
				case GameDiff.Easy:
					commonInfo = allCommonList.CommonList4L [0];
					break;
				case GameDiff.Hard:
					commonInfo = allCommonList.CommonList4L [1];
					break;
				case GameDiff.Ultra:
					commonInfo = allCommonList.CommonList4L [2];
					break;
				default:
					break;
				}
				break;
			case 5:
				switch (GameController.manager.curDiff) {
				case GameDiff.Easy:
					commonInfo = allCommonList.CommonList5L [0];
					break;
				case GameDiff.Hard:
					commonInfo = allCommonList.CommonList5L [1];
					break;
				case GameDiff.Ultra:
					commonInfo = allCommonList.CommonList5L [2];
					break;
				default:
					break;
				}
				break;
			default:
				break;
			}
			break;
		case LinkMode.Advance:
			switch (GameController.manager.curDiff) {
			case GameDiff.Easy:
				if (GameController.manager.JLinkMode) {
					commonInfo = allCommonList.CommonListJL [0];
				} else if (GameController.manager.LLinkMode) {
					commonInfo = allCommonList.CommonListLL [0];
				}
				break;
			case GameDiff.Hard:
				if (GameController.manager.JLinkMode) {
					commonInfo = allCommonList.CommonListJL [1];
				} else if (GameController.manager.LLinkMode) {
					commonInfo = allCommonList.CommonListLL [1];
				}
				break;
			case GameDiff.Ultra:
				if (GameController.manager.JLinkMode) {
					commonInfo = allCommonList.CommonListJL [2];
				} else if (GameController.manager.LLinkMode) {
					commonInfo = allCommonList.CommonListLL [2];
				}
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}
		return commonInfo;
	}

	public void LoadChallengeData() {
		string filePath = Path.Combine (Application.persistentDataPath, "ChallengeInfo.data");
		if (!File.Exists (filePath)) {
			print ("Don not exist : " + filePath);
			ChallengeInfo info = new ChallengeInfo ();
			info.creator = "NoBody";
			info.level = 1;
			info.score = 0;
			SerializeChallengeInfoMethod (filePath, info);
			challengeInfo = info;
		} else {
			print ("exist challenge");
			DeserializeChallengeInfoMethod (filePath);
		}
	}

	//Deserialize
	void DeserializeChallengeInfoMethod(string filePath) {
		FileStream fs = new FileStream (filePath, FileMode.Open);
		BinaryFormatter bf = new BinaryFormatter ();
		challengeInfo = bf.Deserialize (fs) as ChallengeInfo;
//		print (challengeInfo.level);
//		print (challengeInfo.score);
//		print (challengeInfo.creator);
		fs.Close ();
	}

	//Serialize 
	void SerializeChallengeInfoMethod(string filePath, ChallengeInfo info) {
		FileStream fs = new FileStream (filePath, FileMode.Create);
		BinaryFormatter bf = new BinaryFormatter ();
		bf.Serialize (fs, info);
		fs.Close ();
	}

	public void WriteChallengeDataToFile(string creator) {
		string filePath = Path.Combine (Application.persistentDataPath, "ChallengeInfo.data");
		ChallengeInfo info = new ChallengeInfo ();
		info.level = GameController.manager.challengeLevel;
		info.creator = creator;
		info.score = GameController.manager.score;
		challengeInfo = info;
//		print (challengeInfo.level);
//		print (challengeInfo.score);
//		print (challengeInfo.creator);
		SerializeChallengeInfoMethod (filePath, challengeInfo);
	}

}
