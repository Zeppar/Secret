using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomDiffPanel : MonoBehaviour {

	public Toggle easyToggle;
	public Toggle hardToggle;
	public Toggle ultraToggle;
	void Start () {
		GameController.manager.curDiff = GameDiff.Easy;
		easyToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, easyToggle.gameObject);
		});
		hardToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, hardToggle.gameObject);
		});
		ultraToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, ultraToggle.gameObject);
		});
	}

	public void OnDiffToggleValueChange(bool isOn, GameObject sender) {
		if (isOn) {
			switch (sender.name) {
			case "Easy":
				GameController.manager.curDiff = GameDiff.Easy;
				break;
			case "Hard":
				GameController.manager.curDiff = GameDiff.Hard;
				break;
			case "Ultra":
				GameController.manager.curDiff = GameDiff.Ultra;
				break;
			default:
				break;
			}
		}
	}

	public void OnEnable() {
		easyToggle.isOn = true;
		GameController.manager.curDiff = GameDiff.Easy;
	}

	public void goButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("StartGame", null), NotificationLayer.UI);
		if (GameController.manager.LLinkMode) {
			LevelManager.manager.createLModeScene ();
		} else if (GameController.manager.JLinkMode) {
			LevelManager.manager.createJModeScene ();
		}
		NotificationCenter.defaultCenter.PostNotification (new Notification ("updateItemCount", null), NotificationLayer.UI);
	}

	public void closeButtonOnClick() {
		gameObject.SetActive (false);
	}

}
