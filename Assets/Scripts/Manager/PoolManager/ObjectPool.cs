using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {
	List<PoolObject> activeList = new List<PoolObject> (16);
	List<PoolObject> inactiveList = new List<PoolObject> (16);
	List<PoolObject> removeList = new List<PoolObject> (16);
	public PoolObject prefab;
	//每次扩充List的数量
	public int LenghtAddCount = 16;
	//自动释放相关
	public bool autoRelease = false;
	public float autoReleaseTime = 100f;
	public float autoReleaseCountPerTime = 5;
	//缓存池中最小的存留数量
	public int minRemainCount = 10;
	//自动清理计数器
	float time = 0f;

	public PoolObject getObject() {
		if (inactiveList.Count == 0) {
			PoolObject newItem = GameObject.Instantiate (prefab);
			newItem.pool = this;
			if (activeList.Count + 1 > activeList.Capacity) {
				activeList.Capacity += LenghtAddCount;
			}
			activeList.Add (newItem);
			return newItem;
		}
		PoolObject poolItem = inactiveList[inactiveList.Count - 1];
		poolItem.pool = this;
		activeList.Add (poolItem);
		inactiveList.Remove (poolItem);
		poolItem.gameObject.SetActive (true);
		return poolItem;
	}

	public void returnObject(PoolObject obj) {
		obj.transform.SetParent (obj.pool.transform);
		obj.gameObject.SetActive (false);
		activeList.Remove (obj);
		if (inactiveList.Count + 1 > inactiveList.Capacity) {
			inactiveList.Capacity += LenghtAddCount;
		}
		inactiveList.Add (obj);
	}

	void Update() {
		if (autoRelease) {
			time += Time.deltaTime;
			if (time >= autoReleaseTime) {
				time -= autoReleaseTime;
				removeSomeObjects ();
			}
		}
	}

	void removeSomeObjects() {
		removeList.Clear ();
		for (int i = inactiveList.Count - 1; i >= 0; i--) {
			if (inactiveList.Count <= minRemainCount)
				break;
			removeList.Add (inactiveList [i]);
			inactiveList.Remove (inactiveList [i]);
			if (removeList.Count >= autoReleaseCountPerTime)
				break;
		}
		removeList.ForEach (c => Destroy (c.gameObject));
	}
}
