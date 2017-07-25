using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour {

	public ObjectPool pool;

	public void returnToPool() {
		if (pool != null) {
			pool.returnObject (this);
		} else {
			Destroy (gameObject);
		}
	}

}
