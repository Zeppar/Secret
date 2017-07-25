using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionItem : PoolObject {

	public Sprite normalSprite;
	public Sprite lockSprite;
	public Image backgroundImage;
	public Text levelText;
	int level = -1;
	bool locked;
	public LevelInfo missionInfo;
	public Image[] starArr;
	public Sprite normalStar;
	public Sprite highlightStar;

	public void setContent(int _level, LevelInfo info) {
		missionInfo = info;
		locked = info.isLocked;
		level = _level;
		levelText.text = level.ToString ();
		if (locked) {
			backgroundImage.sprite = lockSprite;
		} else {
			backgroundImage.sprite = normalSprite;
		}
		for (int i = 0; i < starArr.Length; i++) {
			if (i < info.starCount) {
				starArr [i].sprite = highlightStar;
			} else {
				starArr [i].sprite = normalStar;
			}
		}
	}

	public void clickSelf() {
		if (locked)
			return;
		LevelManager.manager.LoadLevel (level);
		NotificationCenter.defaultCenter.PostNotification (new Notification ("StartGame", null), NotificationLayer.UI);
	}
}
