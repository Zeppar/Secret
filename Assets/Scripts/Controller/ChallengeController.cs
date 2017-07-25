using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeController : MonoBehaviour {

	public Text scoreText;
	public Text levelText;
	public Text creatorText;

	public Toggle easyToggle;
	public Toggle middleToggle;
	public Toggle hardToggle;


	void Start() {
		easyToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffValueChanged (isOn, easyToggle.gameObject);
		});
		middleToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffValueChanged (isOn, middleToggle.gameObject);
		});
		hardToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffValueChanged (isOn, hardToggle.gameObject);
		});
	}

	void OnEnable() {
		scoreText.text = LevelManager.manager.challengeInfo.score.ToString ();
		levelText.text = LevelManager.manager.challengeInfo.level.ToString ();
		creatorText.text = LevelManager.manager.challengeInfo.creator;
	}

	void OnDiffValueChanged(bool isOn, GameObject sender) {
		if (isOn) {
			switch (sender.name) {
			case "Easy":
				GameController.manager.challengeMode = ChallengeMode.Easy;
				break;
			case "Middle":
				GameController.manager.challengeMode = ChallengeMode.Middle;
				break;
			case "Hard":
				GameController.manager.challengeMode = ChallengeMode.Hard;
				break;
			default:
				break;
			}
		}
	}
		
	public void CloseButtonOnClick() {
		gameObject.SetActive (false);
	}

	public void goButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("StartGame", null), NotificationLayer.UI);
		GameController.manager.timer = 30f;
		LevelManager.manager.createChallengeScene ();

	}


}
