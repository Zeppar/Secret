using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController2 : MonoBehaviour {

	public static SoundController2 manager = null;
	public AudioSource bgMusic;
	public Dictionary<string, AudioClip> _soundDictionary = new Dictionary<string, AudioClip> ();
	public List<AudioClip> audioList = new List<AudioClip> (2);
	public bool shouldPlayMusic = true;
	public bool lastShouldPlayMusic = true;
	public string curMusicKey = "";
	public string preMusicKey = "";

	void Awake() {
		if (manager == null) {
			manager = this;
			DontDestroyOnLoad (gameObject);
		} else if (manager != this) {
			Destroy (gameObject);
		}
	}

	public float GetVolume() {
		return bgMusic.volume;
	}

	void Start() {
		for (int i = 0; i < audioList.Count; i++) {
			_soundDictionary.Add ("Music" + (i + 1).ToString (), audioList [i]);
		}
		PlayBackgroundMusic ("Music1");
	}

	public void PlayBackgroundMusic(string MusicKey) {
		if (!shouldPlayMusic) {
			bgMusic.Stop ();
			return;
		}
		if (_soundDictionary.ContainsKey(MusicKey)) {
			if (MusicKey != preMusicKey || !lastShouldPlayMusic) {
				curMusicKey = MusicKey;
				preMusicKey = MusicKey;
				bgMusic.clip = _soundDictionary [MusicKey];
				bgMusic.Play ();
			}
		}
	}

	public void SetVolume(float volume) {
		bgMusic.volume = volume;
	}
		
}
