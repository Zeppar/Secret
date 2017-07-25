using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MusicItem : PoolObject, IPointerClickHandler {

	public Text nameText;
	bool selected = false;

	public void setContent(string musicName) {
		nameText.text = musicName;
	}

	public string getMusicName() {
		return nameText.text;
	}

	public void OnPointerClick(PointerEventData data) {
		SelectMusicController.selectedMusicItem = this;
	}

	void Update() {
		if (!selected && SelectMusicController.selectedMusicItem == this) {
			nameText.color = Color.blue;
			selected = true;
		}
		if (selected && SelectMusicController.selectedMusicItem != this) {
			nameText.color = Color.black;
			selected = false;
		}
	}


}
