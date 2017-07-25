using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartContoller : MonoBehaviour {

	public void MissionButtonOnClick() {
		GameController.manager.curGameMode = GameMode.Mission;
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowMission", null), NotificationLayer.UI);
	}

	public void FreeButtonOnClick() {
		GameController.manager.curGameMode = GameMode.Free;
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowFree", null), NotificationLayer.UI);
	}

	public void CustonButtonOnClick() {
		GameController.manager.curGameMode = GameMode.Custom;
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowCustom", null), NotificationLayer.UI);
	}

	public void ChallengeButtonOnClick() {
		GameController.manager.curGameMode = GameMode.Challenge;
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowChallenge", null), NotificationLayer.UI);
	}

	public void SettingButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowSetting", null), NotificationLayer.UI);
	}
}
