using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionWinPanel : MonoBehaviour {

	public Image[] starArr;
	public Text ScoreText;
	public Sprite normalStar;
	public Sprite highLightStar;
	public Text levelText;

	public void NextButtonOnClick() {
		LevelManager.manager.LoadNextLevel ();
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideMissionWinPanel", null), NotificationLayer.UI);
		GameController.manager.hasStartGame = true;
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
		GameController.manager.score = 0;
	}

	public void BackButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("BackToStart", null), NotificationLayer.UI);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideMissionWinPanel", null), NotificationLayer.UI);
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
		GameController.manager.score = 0;
	}

	public void InitData(int score) {
		int starLevel = GameController.manager.GetStarLevel ();

		for (int i = 0; i < starArr.Length; i++) {
			if (i < starLevel) {
				starArr [i].sprite = highLightStar;
			} else {
				starArr [i].sprite = normalStar;
			}
		}
		ScoreText.text = score.ToString ();
		levelText.text = LevelManager.manager.currentLevel.ToString ();
	}

	public void ResetData() {
		for (int i = 0; i < starArr.Length; i++) {
			starArr [i].sprite = highLightStar;
		}
		ScoreText.text = "";
		levelText.text = "";
	}

}
