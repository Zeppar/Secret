using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public class SoundManager : MonoBehaviour {

	public static SoundManager manager = null;
	public AudioSource bgAudio;
	public AudioSource effectAduio;
	public Dictionary<string,AudioClip> musicDictionary = new Dictionary<string, AudioClip>();
	public Dictionary<string,AudioClip> effectDictionary = new Dictionary<string, AudioClip>();
	public AudioClip[] musicClipArr;
	public AudioClip[] effectClipArr;
	public string currentMusicName = "";

	void Awake() {
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
		} else if (manager != this) {
			Destroy (gameObject);
		}
	}

	//init sound
	public void InitSound() {
		//load default music and effect
		LoadDefaultClip();
	}

	void Start() {
		
	}

	//load clip from resources
	void LoadDefaultClip() {
		musicClipArr = Resources.LoadAll<AudioClip>("innerMusic");
		for (int i = 0; i < musicClipArr.Length; i++) {
			musicDictionary.Add (musicClipArr [i].name, musicClipArr [i]);
		}

		effectClipArr = Resources.LoadAll<AudioClip>("innerEffect");
		for (int i = 0; i < effectClipArr.Length; i++) {
			effectDictionary.Add (effectClipArr [i].name, effectClipArr [i]);
		}
	}

	public void setBackgroundVolume(float volume) {
		if (volume < 0 || volume > 100)
			return;
		bgAudio.volume = volume;
	}

	public void setEffectVolume(float volume) {
		if (volume < 0 || volume > 100)
			return;
		effectAduio.volume = volume;
	}

	//load clip from local Directory
	void LoadCustomClip() {
		if (Application.platform != RuntimePlatform.WindowsEditor)
			return;
		//get mydocument oath
		string myDoc = System.Environment.GetFolderPath (System.Environment.SpecialFolder.MyDocuments);
		string mainPath = Path.Combine (myDoc, "MusicEffect");
		if (!Directory.Exists (mainPath)) {
			Directory.CreateDirectory (mainPath);
		}
		string musicPath = Path.Combine (mainPath, "Music");
		string effectPath = Path.Combine (mainPath, "Effect");
		if (!Directory.Exists (musicPath)) {
			Directory.CreateDirectory (musicPath);
		}
		if (!Directory.Exists (effectPath)) {
			Directory.CreateDirectory (effectPath);
		}
		//load Music
		List<string> musicFilePaths = new List<string>();
		string musicType = "*.aiff|*.wav|*.mp3|*.ogg";
		string[] types = musicType.Split ('|');
		for (int i = 0; i < types.Length; i++) {
			string[] dirs = Directory.GetFiles (musicPath, types [i]);
			for (int j = 0; j < dirs.Length; j++) {
				musicFilePaths.Add (dirs [j]);
			}
		}

		for (int i = 0; i < musicFilePaths.Count; i++) {
//			StartCoroutine (LoadMusicAndEffect (musicFilePaths [i], musicDictionary));
		}
		//load effect
		List<string> effectFilePaths = new List<string>();
		for (int i = 0; i < types.Length; i++) {
			string[] dirs = Directory.GetFiles (effectPath, types [i]);
			for (int j = 0; j < dirs.Length; j++) {
				effectFilePaths.Add (dirs [j]);
			}
		}

		for (int i = 0; i < effectFilePaths.Count; i++) {
//			StartCoroutine (LoadMusicAndEffect (effectFilePaths [i], effectDictionary));
		}

	}

	//Function TODO
	IEnumerator LoadMusicAndEffect(string filePath, Dictionary<string, AudioClip> dict) {
		yield return null;
	}


	public void PlayBackgroundMusic(string musicName) {
		if (musicName.Trim () == "")
			return;
		if (musicDictionary.ContainsKey (musicName) && musicName != currentMusicName) {
			if (bgAudio.isPlaying)
				bgAudio.Stop ();
			bgAudio.clip = musicDictionary [musicName];
			bgAudio.Play ();
			currentMusicName = musicName;
		}
	}

	public void PlayEffect(string effectName) {
		if (effectName.Trim () == "")
			return;
		if (effectDictionary.ContainsKey (effectName)) {
			if (effectAduio.isPlaying)
				effectAduio.Stop ();
			effectAduio.clip = effectDictionary [effectName];
			effectAduio.Play ();
		}
	}

	public void PlayRandomBgMusic() {
		PlayBackgroundMusic (GetRandomKeyInDictionary (musicDictionary));
	}

	public void PlayRandomEffect() {
		PlayEffect (GetRandomKeyInDictionary (effectDictionary));
	}

	string GetRandomKeyInDictionary(Dictionary<string,AudioClip> dict) {
		int randomIndex = UnityEngine.Random.Range (0, dict.Keys.Count);
		string randomKey = "";
		int tempIndex = 0;
		foreach (var item in dict.Keys) {
			if (tempIndex == randomIndex) {
				randomKey = item;
				break;
			} else {
				tempIndex++;
			}
		}
		return randomKey;
	}


}
