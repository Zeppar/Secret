using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour {

	public Toggle showModeNowToggle;
	public Toggle showModeAfterToggle;
	public Toggle lineModeShowToggle;
	public Toggle lineModeHideToggle;
	public Slider musicSlider;
	public Slider effectSlider;

	void Start() {
		showModeNowToggle.onValueChanged.AddListener (delegate(bool isOn) {
			OnShowModeToggleValueChange(isOn, showModeNowToggle.gameObject);	
		});
		showModeAfterToggle.onValueChanged.AddListener (delegate(bool isOn) {
			OnShowModeToggleValueChange(isOn, showModeAfterToggle.gameObject);	
		});
		lineModeShowToggle.onValueChanged.AddListener (delegate(bool isOn) {
			OnLineModeToggleValueChange(isOn, lineModeShowToggle.gameObject);	
		});
		lineModeHideToggle.onValueChanged.AddListener (delegate(bool isOn) {
			OnLineModeToggleValueChange(isOn, lineModeHideToggle.gameObject);	
		});
		musicSlider.value = SoundManager.manager.bgAudio.volume;
		effectSlider.value = SoundManager.manager.effectAduio.volume;
	}

	public void CloseButtonOnClick() {
		gameObject.SetActive (false);	
		GameController.manager.pauseGame = false;
	}

	public void SelectMusicButtonOnClick() {
		NotificationCenter.defaultCenter.PostNotification (new Notification ("ShowSelectMusic", null), NotificationLayer.UI);
	}

	//toggle function
	public void OnShowModeToggleValueChange(bool isOn, GameObject sender) {
		if (isOn) {
			switch (sender.name) {
			case "Now":
				GameController.manager.curShowMode = ShowMode.Now;
				break;
			case "After":
				GameController.manager.curShowMode = ShowMode.After;
				break;
			default:
				break;
			}
		}
	}

	public void OnLineModeToggleValueChange(bool isOn, GameObject sender) {
		if (isOn) {
			switch (sender.name) {
			case "Show":
				GameController.manager.curLineMode = LineMode.Show;
				break;
			case "Hide":
				GameController.manager.curLineMode = LineMode.Hide;
				break;
			default:
				break;
			}
		}
	}

	public void OnMusicValueChange() {
		print (musicSlider.value);
		SoundManager.manager.setBackgroundVolume (musicSlider.value);
	}

	public void OnEffectValueChange() {
		print (effectSlider.value);
		SoundManager.manager.setEffectVolume (effectSlider.value);
	}
}
