using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIController : MonoBehaviour {

	public StartContoller startContoller;
	public SettingController settingController;
	public MissionController missionController;
	public FreeController freeController;
	public CustomController customController;
	public ChallengeController challengeController;
	public SelectMusicController selectMusicController;
	public GameUIController gameUIController;
	public MissionWinPanel missionWinPanel;
	public FreeWinPanel freeWinPanel;
	public DataPanel dataPanel;
	public SimulatePanel simulatePanel;
	public CustomWinPanel customWinPanel;
	public ChallengeWinPanel challengeWinPanel;
	public CustomDiffPanel customDiffPanel;

	void Start() {
		//add Observer
		NotificationCenter.defaultCenter.AddObserver (this, "ShowSetting", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowMission", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowFree", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowCustom", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowChallenge", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowSelectMusic", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "InitMusicList", NotificationLayer.Sound);
		NotificationCenter.defaultCenter.AddObserver (this, "StartGame", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "BackToStart", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowMissionWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "HideMissionWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowLevelBottomData", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowCustomBottomData", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowFreeWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "HideFreeWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowSimulatePanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowCustomWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "HideCustomWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowChallengeWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "HideChallengeWinPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ResetSimulatePanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "ShowCustomDiffPanel", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "updateItemCount", NotificationLayer.UI);
		NotificationCenter.defaultCenter.AddObserver (this, "HideCustomAllPanel", NotificationLayer.UI);
	}

	public void HideCustomAllPanel() {
		if (simulatePanel.gameObject.activeSelf)
			simulatePanel.gameObject.SetActive (false);
		if (customDiffPanel.gameObject.activeSelf)
			customDiffPanel.gameObject.SetActive (false);
	}

	public void updateItemCount() {
		gameUIController.updateItemCount ();
	}

	public void ShowChallengeWinPanel() {
//		ChallengeInfo info = LevelManager.manager.challangeInfo;
		challengeWinPanel.SetContent (GameController.manager.challengeLevel, GameController.manager.score);
		challengeWinPanel.gameObject.SetActive (true);
	}

	public void ShowCustomDiffPanel() {
		customDiffPanel.gameObject.SetActive (true);
	}

	public void ResetSimulatePanel() {
		simulatePanel.resetButtonOnClick ();
	}

	public void HideFreeWinPanel() {
		freeWinPanel.gameObject.SetActive (false);
	}

	public void HideCustomWinPanel() {
		customWinPanel.gameObject.SetActive (false);
	}

	public void HideChallengeWinPanel() {
		challengeWinPanel.gameObject.SetActive (false);
	}

	public void ShowCustomWinPanel() {
		customWinPanel.SetContent (GameController.manager.score, GameController.manager.timer);
		customWinPanel.gameObject.SetActive (true);
	}

	public void ShowFreeWinPanel() {
		freeWinPanel.SetContent (GameController.manager.score, GameController.manager.timer);
		freeWinPanel.gameObject.SetActive (true);
	}

	public void ShowSetting() {
		settingController.gameObject.SetActive (true);
	}	

	public void ShowMission() {
		missionController.InitMission ();
		missionController.gameObject.SetActive (true);
	}

	public void ShowFree() {
		freeController.gameObject.SetActive (true);
	}

	public void ShowCustom() {
		customController.gameObject.SetActive (true);
	}

	public void ShowChallenge() {
		challengeController.gameObject.SetActive (true);
	}

	public void ShowSelectMusic() {
		selectMusicController.gameObject.SetActive (true);
	}

	public void InitMusicList() {
		selectMusicController.InitMusicList ();
	}

	public void StartGame() {
		startContoller.gameObject.SetActive (false);
		if (missionController.gameObject.activeSelf) {
			missionController.gameObject.SetActive (false);
			missionController.DestoryAllItems ();
		}
		if (freeController.gameObject.activeSelf) {
			freeController.gameObject.SetActive (false);
		}
		if (customController.gameObject.activeSelf) {
			customController.gameObject.SetActive (false);
			//Simulate panel TODO
			if (simulatePanel.gameObject.activeSelf)
				simulatePanel.gameObject.SetActive (false);
		}
		if (challengeController.gameObject.activeSelf) {
			challengeController.gameObject.SetActive (false);
		}
		gameUIController.gameObject.SetActive (true);
	}

	public void BackToStart() {
		startContoller.gameObject.SetActive (true);
		gameUIController.gameObject.SetActive (false);
		//beautiful!!!
		GameController.manager.ResetToNormal ();
	}

	public void ShowMissionWinPanel() {
		GameController.manager.score = 1000 + GameController.manager.GetStarLevel () * 100 - (int)GameController.manager.timer - GameController.manager.step * 5;
		missionWinPanel.InitData (GameController.manager.score);
		missionWinPanel.gameObject.SetActive (true);
	}

	public void HideMissionWinPanel() {
		missionWinPanel.gameObject.SetActive (false);
		missionWinPanel.ResetData ();
	}

	public void ShowLevelBottomData(Notification notification) {
//		print (notification.data ["level"]);
		int level = (int)notification.data ["level"];
		LevelInfo info = LevelManager.manager.allLevelList.levelList [level];
		dataPanel.setContent ((string)notification.data ["mode"], info.score, info.starCount, (int)info.timer);
	}

	public void ShowCustomBottomData(Notification notification) {
		
	}

	public void ShowSimulatePanel() {
		simulatePanel.gameObject.SetActive (true);
	}
		
}
