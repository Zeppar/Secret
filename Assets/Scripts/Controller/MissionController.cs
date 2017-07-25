using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour {

	public MissionItem missionItem;
	public Transform content;
	public List<MissionItem> itemList = new List<MissionItem> ();

	public void CloseButtonOnClick() {
		gameObject.SetActive (false);
	}

	public void InitMission() {
		print ("Init Mission");
		for (int i = 0; i < LevelManager.manager.levelCount; i++) {
			MissionItem item = (MissionItem)PoolManager.manager.getPool (missionItem).getObject ();
			item.transform.SetParent (content, false);
			item.setContent (i, LevelManager.manager.allLevelList.levelList [i]);
			itemList.Add (item);
		}
	}

	public void DestoryAllItems() {
		for (int i = 0; i < itemList.Count; i++) {
			itemList [i].returnToPool ();
		}
		itemList.Clear ();
	}
}
