using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum NotificationLayer {
	All,
	UI,
	Sound,
	Game
}

public class Notification {
	public Component sender;
	public string name;
	public Hashtable data;

	//针对性通知
	public Notification(string aName) {
		name = aName;
		data = null;
	}

	public Notification(string aName, Hashtable aData) {
		name = aName;
		data = aData;
	}
}

public class NotificationCenter : MonoBehaviour {

	public static NotificationCenter defaultCenter = null;
	Dictionary<NotificationLayer, Dictionary<string, List<Component>>> notiDict = new Dictionary<NotificationLayer, Dictionary<string, List<Component>>>();

	void Awake() {
		if (defaultCenter == null) {
			defaultCenter = this;
			DontDestroyOnLoad (gameObject);
		} else if (defaultCenter != this) {
			Destroy (gameObject);
		}
	}

	//添加观察者
	public void AddObserver(Component observer, string name, NotificationLayer layer) {
		if (name == "") {
			Debug.Log ("name is empty");
			return;
		}
		if (layer == NotificationLayer.All) {
			Debug.Log ("can not set layer to all");
			return;
		}
		if (!notiDict.ContainsKey (layer)) {
			notiDict [layer] = new Dictionary<string, List<Component>> ();
		}
		Dictionary<string, List<Component>> childDict = notiDict [layer];
		if (!childDict.ContainsKey (name)) {
			childDict [name] = new List<Component> ();
		}
		List<Component> observerList = childDict [name];
		if (!observerList.Contains (observer)) {
			observerList.Add (observer);
		}
	}

	//移除单个通知
	public void RemoveObserver(Component observer, string name, NotificationLayer layer) {
		if (layer == NotificationLayer.All) {
			Debug.Log ("can not set layer to all");
			return;
		}
		if (!notiDict.ContainsKey (layer)) {
			Debug.Log ("can not find this layer");
			return;
		}
		Dictionary<string, List<Component>> childDict = notiDict [layer];
		if (!childDict.ContainsKey (name)) {
			Debug.Log ("can not find this notification : " + name);
			return;
		}
		List<Component> observerList = childDict [name];
		if (observerList != null) {
			if (observerList.Contains (observer)) { 
				observerList.Remove (observer);
			}
			if (observerList.Count == 0) {
				childDict.Remove (name);
			}
		}
	}

	//移除所有通知
	public void RemoveObserver(Component observer, NotificationLayer layer) {
		if (layer == NotificationLayer.All) {
			Debug.Log ("can not set layer to all");
			return;
		}
		if (!notiDict.ContainsKey (layer)) {
			Debug.Log ("can not find this layer");
			return;
		}
		Dictionary<string, List<Component>> childDict = notiDict [layer];
		List<string> keyToRemove = new List<string> ();
		foreach (string key in childDict.Keys) {
			List<Component> observerList = childDict [key];
			if (observerList != null) {
				if (observerList.Contains (observer)) {
					observerList.Remove (observer);
				}
				if (observerList.Count == 0) {
					keyToRemove.Add (key);
				}
			}
		}
		for (int i = 0; i < keyToRemove.Count; i++) {
			childDict.Remove (keyToRemove [i]);
		}
	}

	//发送不含数据的通知
//	public void PostNotification(string name) {
//		PostNotification (name, null);
//	}

	//发送包含数据的通知
	public void PostNotification(string name, Hashtable data, NotificationLayer layer) {
		PostNotification (new Notification (name, data), layer);
	}

	public void PostNotification(Notification aNotification, NotificationLayer layer) {
		if (aNotification.name == "") {
			Debug.Log ("name is empty");
			return;
		}
		if (!notiDict.ContainsKey (layer)) {
			Debug.Log ("can not find this layer");
			return;
		}
		Dictionary<string, List<Component>> childDict = notiDict [layer];
		if (!childDict.ContainsKey(aNotification.name)) {
			Debug.Log ("can not find this notification : " + aNotification.name);
			return;
		}
		List<Component> observerList = childDict [aNotification.name];
		List<Component> observersToRemove = new List<Component> ();
		foreach (Component observer in observerList) {
			if (!observer) {
				observersToRemove.Add (observer);
			} else {
				observer.SendMessage (aNotification.name, aNotification, SendMessageOptions.DontRequireReceiver);
			}
		}

		foreach (Component observer in observersToRemove) {
			observerList.Remove (observer);
		}
	}
}
