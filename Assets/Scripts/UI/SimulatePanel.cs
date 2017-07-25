using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulatePanel : MonoBehaviour {

	public Button resetButton;
	public Button confirmButton;
	public Button goButton;

	void Update() {
		goButton.interactable = GameController.manager.hasConfirmSimulate;
	}

	public void confirmButtonOnClick() {
		if (!GameController.manager.CheckSimulateAvailable ())
			return;
		GameController.manager.ConfirmSimulateList ();
		GameController.manager.curLinkMode = LinkMode.Advance;
		GameController.manager.JLinkMode = false;
		GameController.manager.LLinkMode = false;
		GameController.manager.CtmLinkMode = true;
		GameController.manager.CalculateCtmList ();
		resetButton.gameObject.SetActive (true);
		confirmButton.gameObject.SetActive (false);
		GameController.manager.hasConfirmSimulate = true;
	}

	public void resetButtonOnClick() {
		GameController.manager.ResetSimulteByResetBtn ();
		resetButton.gameObject.SetActive (false);
		confirmButton.gameObject.SetActive (true);
	}

	public void ResetButton() {
		resetButton.gameObject.SetActive (false);
		confirmButton.gameObject.SetActive (true);
	}

	public void closeButtonOnClick() {
		gameObject.SetActive (false);
		if (!GameController.manager.hasConfirmSimulate) {
			GameController.manager.ResetSimulate ();
		}
	}

	public void goButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("StartGame", null), NotificationLayer.UI);
		LevelManager.manager.createCTMModeScene ();
		NotificationCenter.defaultCenter.PostNotification (new Notification ("updateItemCount", null), NotificationLayer.UI);
	}

}
