using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomWinPanel : MonoBehaviour {

	public Text scoreText;
	public Text bestScoreText;
	public Text timeText;
	public Text bestTimeText;

	public void BackButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("BackToStart", null), NotificationLayer.UI);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideCustomWinPanel", null), NotificationLayer.UI);
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
	}

	public void RestartButtonOnClick() {
		//reset item
		//simulate
		LevelManager.manager.AddChessItems ();
		if (GameController.manager.LLinkMode) {
			GameController.manager.SetLinkModeData (AdvanceLinkMode.L);
		} else if (GameController.manager.JLinkMode) {
			GameController.manager.SetLinkModeData (AdvanceLinkMode.J);
		} else if (GameController.manager.CtmLinkMode) {
			GameController.manager.SetLinkModeData (AdvanceLinkMode.CTM);
		}
		GameController.manager.setAnswerPanelData ();
		GameController.manager.SimulateInAdvanceLevel ();
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideCustomWinPanel", null), NotificationLayer.UI);
		GameController.manager.hasStartGame = true;
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
	}

	public void SetContent(int score, float time) {
		scoreText.text = score.ToString ();
		timeText.text = ((int)time / 60).ToString ().PadLeft (2, '0') + " : " + ((int)time % 60).ToString ().PadLeft (2, '0');
		CommonInfo commonInfo = LevelManager.manager.GetCurrentCommonInfo ();
		bestScoreText.text = commonInfo.score.ToString ();
		bestTimeText.text = ((int)commonInfo.timer / 60).ToString ().PadLeft (2, '0') + " : " + ((int)commonInfo.timer % 60).ToString ().PadLeft (2, '0');
	}
}
