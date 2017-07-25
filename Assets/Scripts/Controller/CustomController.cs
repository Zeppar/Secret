using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomController : MonoBehaviour {

	public void CloseButtonOnClick() {
		gameObject.SetActive (false);
	}

	public void LLinkModeOnClick() {
		GameController.manager.LLinkMode = true;
		GameController.manager.JLinkMode = false;
		GameController.manager.CtmLinkMode = false;
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowCustomDiffPanel", null), NotificationLayer.UI);
	}

	public void JLinkModeOnClick() {
		GameController.manager.LLinkMode = false;
		GameController.manager.JLinkMode = true;
		GameController.manager.CtmLinkMode = false;
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowCustomDiffPanel", null), NotificationLayer.UI);
	}

	public void CustomLinkModeOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowSimulatePanel", null), NotificationLayer.UI);
	}

	void OnDisable() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("HideCustomAllPanel", null), NotificationLayer.UI);
	}

}
