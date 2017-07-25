using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMusicController : MonoBehaviour {

	public Transform musicContent;
	public MusicItem musicItemPrefab;
	public static MusicItem selectedMusicItem = null;
	public Button confirmButton;

	void Start() {
		
	}

	void Update() {
		confirmButton.interactable = (selectedMusicItem != null);
	}

	public void InitMusicList() {
		foreach (string key in SoundManager.manager.musicDictionary.Keys) {
			MusicItem item = (MusicItem)PoolManager.manager.getPool (musicItemPrefab).getObject ();
			item.setContent (key);
			if (key == SoundManager.manager.currentMusicName)
				SelectMusicController.selectedMusicItem = item;
			item.transform.SetParent (musicContent, false);
		}
	}

	public void CloseButtonOnClick() {
		gameObject.SetActive (false);
	}

	public void ConfirmButtonOnClick() {
		gameObject.SetActive (false);
		SoundManager.manager.PlayBackgroundMusic (selectedMusicItem.getMusicName ());
	}
}
