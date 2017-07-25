using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeWinPanel : MonoBehaviour {

	public Text scoreText;
	public Text bestScoreText;
	public Text timeText;
	public Text bestTimeText;

	public void BackButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("BackToStart", null), NotificationLayer.UI);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideFreeWinPanel", null), NotificationLayer.UI);
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
		GameController.manager.score = 0;
	}

	public void RestartButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideFreeWinPanel", null), NotificationLayer.UI);
		//restart
		LevelManager.manager.createFreeScene ();
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
		GameController.manager.score = 0;
	}

	public void SetContent(int score, float time) {
		scoreText.text = score.ToString ();
		timeText.text = ((int)time / 60).ToString ().PadLeft (2, '0') + " : " + ((int)time % 60).ToString ().PadLeft (2, '0');
		CommonInfo commonInfo = LevelManager.manager.GetCurrentCommonInfo ();
		bestScoreText.text = commonInfo.score.ToString ();
		bestTimeText.text = ((int)commonInfo.timer / 60).ToString ().PadLeft (2, '0') + " : " + ((int)commonInfo.timer % 60).ToString ().PadLeft (2, '0');
	}
}
