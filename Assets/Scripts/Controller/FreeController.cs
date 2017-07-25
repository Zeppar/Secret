using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeController : MonoBehaviour {
	
	public Toggle link3Toggle;
	public Toggle link4Toggle;
	public Toggle link5Toggle;
	public Toggle easyToggle;
	public Toggle hardToggle;
	public Toggle ultraToggle;

	void Start() {
		link3Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, link3Toggle.gameObject);
		});
		link4Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, link4Toggle.gameObject);
		});
		link5Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, link5Toggle.gameObject);
		});
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

	public void OnLinkToggleValueChange(bool isOn, GameObject sender) {
		if (isOn) {
			switch (sender.name) {
			case "3Link":
				GameController.manager.maxLinkCount = 3;
				GameController.manager.curLinkMode = LinkMode.Basic;
				GameController.manager.JLinkMode = false;
				GameController.manager.LLinkMode = false;
				GameController.manager.CtmLinkMode = false;
				break;
			case "4Link":
				GameController.manager.maxLinkCount = 4;
				GameController.manager.curLinkMode = LinkMode.Basic;
				GameController.manager.JLinkMode = false;
				GameController.manager.LLinkMode = false;
				GameController.manager.CtmLinkMode = false;
				break;
			case "5Link":
				GameController.manager.maxLinkCount = 5;
				GameController.manager.curLinkMode = LinkMode.Basic;
				GameController.manager.JLinkMode = false;
				GameController.manager.LLinkMode = false;
				GameController.manager.CtmLinkMode = false;
				break;
			default:
				break;
			}
		}
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
		link3Toggle.isOn = true;
		easyToggle.isOn = true;
		GameController.manager.maxLinkCount = 3;
		GameController.manager.curDiff = GameDiff.Easy;
	}

	public void CloseButtonOnClick() {
		gameObject.SetActive (false);
	}

	public void PlayButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("StartGame", null), NotificationLayer.UI);
		LevelManager.manager.createFreeScene ();
	}
}
