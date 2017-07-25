using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeWinPanel : MonoBehaviour {

	public Text levelText;
	public Text scoreText;

	public InputField input;

	public void confirmButtonOnClick() {
		if (input.text.Trim () == "")
			return;
		LevelManager.manager.WriteChallengeDataToFile (input.text);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("BackToStart", null), NotificationLayer.UI);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideChallengeWinPanel", null), NotificationLayer.UI);
		GameController.manager.timer = 0;
		GameController.manager.step = 0;
		GameController.manager.challengeLevel = 1;
		GameController.manager.score = 0;
	}

	public void SetContent(int level, int score) {
		levelText.text = level.ToString ();
		scoreText.text = score.ToString ();
	}
}
