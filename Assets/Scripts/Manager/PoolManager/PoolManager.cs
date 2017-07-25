using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {
	
	public Dictionary<string, ObjectPool> poolDict = new Dictionary<string, ObjectPool> ();
	public static PoolManager manager = null;

	void Awake() {
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
		} else if (manager != this) {
			Destroy (gameObject);
		}
	}

	public ObjectPool getPool(PoolObject prefab) {
		string poolName = prefab.name + "Pool";
		if (poolDict.ContainsKey (poolName)) {
			return poolDict [poolName];
		}
		GameObject poolGo = new GameObject(poolName);
		poolGo.transform.SetParent (transform, false);
		poolGo.AddComponent<ObjectPool> ();
		poolGo.GetComponent<ObjectPool> ().prefab = prefab;
		poolDict [poolName] = poolGo.GetComponent<ObjectPool> ();
		return poolDict [poolName];
	}
}
