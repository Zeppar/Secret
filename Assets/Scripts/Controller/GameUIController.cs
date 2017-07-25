using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour {

	public Text stepText;
	public Text timeText;
	public Text blackText;
	public Text whiteText;

	public void SettingButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowSetting", null), NotificationLayer.UI);
		GameController.manager.pauseGame = true;
	}

	public void BackButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("BackToStart", null), NotificationLayer.UI);
		GameController.manager.step = 0;
		GameController.manager.timer = 0;
	}

	void Update() {
		stepText.text = GameController.manager.step.ToString ();
		timeText.text = ((int)GameController.manager.timer / 60).ToString ().PadLeft (2, '0') + " : " + ((int)GameController.manager.timer % 60).ToString ().PadLeft (2, '0');
	}

	public void updateItemCount() {
		blackText.text = GameController.manager.getItemsCount (ChessType.Black).ToString ();
		whiteText.text = GameController.manager.getItemsCount (ChessType.White).ToString ();
	}
}
