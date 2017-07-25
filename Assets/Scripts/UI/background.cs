using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class background : MonoBehaviour {

	public Text desText;
	public Toggle Link3Toggle;
	public Toggle Link4Toggle;
	public Toggle Link5Toggle;
	public Toggle LinkLToggle;
	public Toggle LinkZToggle;
	public Toggle LinkCtmToggle;
	public Toggle EasyToggle;
	public Toggle DifficultToggle;
	public Toggle UltraToggle;
	public Toggle SuperToggle;
	public Toggle ShowLineToggle;
	public Toggle HideLineToggle;
	public Toggle ShowNowToggle;
	public Toggle ShowAfterToggle;
	public Toggle MusicOnToggle;
	public Toggle MusicOffToggle;
	public Toggle Music1Toggle;
	public Toggle Music2Toggle;
	public InputField SimCountField;
	public Image inputArea;
	public Image SettingArea;
	public Image WinArea;
	public Slider volumeSlider;
	public SimulatePanel simulatePanel;
	void Start() {
		volumeSlider.value = SoundController2.manager.GetVolume ();
		desText.text = "连线个数为每次连续选中的个数 每次选中图案个数等于连线个数时 图像进行翻转 否则操作无效 游戏难度分为简单和困难两种难度 简单难度每次所有的方块都会进行翻转 困难模式第n/2+1块方块不会进行翻转 胜利的标志是所有方块翻转成相同的图案 开始游戏吧！PS:不能斜着进行连线";
		Link3Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, Link3Toggle.gameObject);
		});
		Link4Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, Link4Toggle.gameObject);
		});
		Link5Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, Link5Toggle.gameObject);
		});
		LinkLToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, LinkLToggle.gameObject);
		});
		LinkZToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, LinkZToggle.gameObject);
		});
		LinkCtmToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLinkToggleValueChange (isOn, LinkCtmToggle.gameObject);
		});
		EasyToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, EasyToggle.gameObject);
		});
		DifficultToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, DifficultToggle.gameObject);
		});
		UltraToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, UltraToggle.gameObject);
		});
		SuperToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnDiffToggleValueChange (isOn, SuperToggle.gameObject);
		});
		ShowLineToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLineModeToggleValueChange (isOn, ShowLineToggle.gameObject);
		});
		HideLineToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnLineModeToggleValueChange (isOn, HideLineToggle.gameObject);
		});
		ShowNowToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnShowModeToggleValueChange (isOn, ShowNowToggle.gameObject);
		});
		ShowAfterToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnShowModeToggleValueChange (isOn, ShowAfterToggle.gameObject);
		});
		MusicOnToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnMusicToggleValueChange (isOn, MusicOnToggle.gameObject);
		});
		MusicOffToggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnMusicToggleValueChange (isOn, MusicOffToggle.gameObject);
		});
		Music1Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnMusicSelectToggleValueChange (isOn, Music1Toggle.gameObject);
		});
		Music2Toggle.onValueChanged.AddListener (delegate(bool isOn) {
			this.OnMusicSelectToggleValueChange (isOn, Music2Toggle.gameObject);
		});
	}

	public void StartButtonOnClick() {
		if (SimCountField.text == "" || int.Parse (SimCountField.text) <= 0)
			return;
		GameController2.manager.SimCount = int.Parse (SimCountField.text);
		GameController2.manager.CreateAllItems ();
		if (GameController2.manager.curLinkMode == LinkMode.Advance) {
			if (GameController2.manager.JLinkMode) {
				GameController2.manager.SetLinkModeData (AdvanceLinkMode.J);
			} else if (GameController2.manager.LLinkMode) {
				GameController2.manager.SetLinkModeData (AdvanceLinkMode.L);
			} else if (GameController2.manager.CtmLinkMode) {
				GameController2.manager.SetLinkModeData (AdvanceLinkMode.CTM);
			}
		}
		GameController2.manager.setAnswerPanelData ();
		if (GameController2.manager.curLinkMode == LinkMode.Advance)
			GameController2.manager.SimulateInMiddleLevel ();
		else 
			GameController2.manager.SimulateInLowLevel ();
		inputArea.gameObject.SetActive (false);
		SettingArea.gameObject.SetActive (true);
		GameController2.manager.hasStartGame = true;
		SoundController2.manager.PlayBackgroundMusic (SoundController2.manager.curMusicKey);
	}

	public void OnLinkToggleValueChange(bool isOn, GameObject sender) {
		if(isOn) {
			switch (sender.name) {
			case "3Link":
				GameController2.manager.maxLinkCount = 3;
				GameController2.manager.curLinkMode = LinkMode.Basic;
				GameController2.manager.JLinkMode = false;
				GameController2.manager.LLinkMode = false;
				GameController2.manager.CtmLinkMode = false;
				EasyToggle.interactable = true;
				DifficultToggle.interactable = true;
				UltraToggle.interactable = true;
				SuperToggle.interactable = false;
				if (SuperToggle.isOn) {
					EasyToggle.isOn = true;
				}
				break;
			case "4Link":
				GameController2.manager.maxLinkCount = 4;
				GameController2.manager.curLinkMode = LinkMode.Basic;
				GameController2.manager.JLinkMode = false;
				GameController2.manager.LLinkMode = false;
				GameController2.manager.CtmLinkMode = false;
				EasyToggle.interactable = true;
				DifficultToggle.interactable = true;
				UltraToggle.interactable = true;
				SuperToggle.interactable = false;
				if (SuperToggle.isOn) {
					EasyToggle.isOn = true;
				}
				break;
			case "5Link":
				GameController2.manager.maxLinkCount = 5;
				GameController2.manager.curLinkMode = LinkMode.Basic;
				GameController2.manager.JLinkMode = false;
				GameController2.manager.LLinkMode = false;
				GameController2.manager.CtmLinkMode = false;
				EasyToggle.interactable = true;
				DifficultToggle.interactable = true;
				UltraToggle.interactable = true;
				SuperToggle.interactable = false;
				if (SuperToggle.isOn) {
					EasyToggle.isOn = true;
				}
				break;
			case "LLink":
				GameController2.manager.maxLinkCount = 4;
				GameController2.manager.curLinkMode = LinkMode.Advance;
				GameController2.manager.JLinkMode = false;
				GameController2.manager.LLinkMode = true;
				GameController2.manager.CtmLinkMode = false;
				EasyToggle.interactable = false;
				DifficultToggle.interactable = false;
				UltraToggle.interactable = false;
				SuperToggle.interactable = true;
				SuperToggle.isOn = true;
				break;
			case "JLink":
				GameController2.manager.maxLinkCount = 6;
				GameController2.manager.curLinkMode = LinkMode.Advance;
				GameController2.manager.JLinkMode = true;
				GameController2.manager.LLinkMode = false;
				EasyToggle.interactable = false;
				DifficultToggle.interactable = false;
				UltraToggle.interactable = false;
				SuperToggle.interactable = true;
				SuperToggle.isOn = true;
				break;
			case "CtmLink":
				
				simulatePanel.gameObject.SetActive (true);
				ShowNowToggle.isOn = false;
				ShowAfterToggle.isOn = true;
				if (GameController2.manager.hasConfirmSimulate) {
					confirmCtmLink ();
				}
//				GameController.manager.curLinkMode = LinkMode.Advance;
//				GameController.manager.JLinkMode = false;
//				GameController.manager.LLinkMode = false;
//				GameController.manager.CtmLinkMode = true;
//				EasyToggle.interactable = false;
//				DifficultToggle.interactable = false;
//				UltraToggle.interactable = false;
//				SuperToggle.interactable = true;
//				SuperToggle.isOn = true;
				break;
			default:
				break;
			}
		}
	}

	public void confirmCtmLink() {
		GameController2.manager.curLinkMode = LinkMode.Advance;
		GameController2.manager.JLinkMode = false;
		GameController2.manager.LLinkMode = false;
		GameController2.manager.CtmLinkMode = true;
		EasyToggle.interactable = false;
		DifficultToggle.interactable = false;
		UltraToggle.interactable = false;
		SuperToggle.interactable = true;
		SuperToggle.isOn = true;
		GameController2.manager.CalculateCtmList ();
	}

	public void ResetSimulate() {
		print ("ResetSimulate");
		GameController2.manager.maxLinkCount = 3;
		GameController2.manager.curLinkMode = LinkMode.Basic;
		GameController2.manager.JLinkMode = false;
		GameController2.manager.LLinkMode = false;
		GameController2.manager.CtmLinkMode = false;
		EasyToggle.interactable = true;
		DifficultToggle.interactable = true;
		UltraToggle.interactable = true;
		SuperToggle.interactable = false;
		Link3Toggle.isOn = true;
		EasyToggle.isOn = true;
	}

	public void OnDiffToggleValueChange(bool isOn, GameObject sender) {
		if(isOn) {
			switch (sender.name) {
			case "easy":
				GameController2.manager.curDiff = GameDiff.Easy;
				break;
			case "hard":
				GameController2.manager.curDiff = GameDiff.Hard;
				break;
			case "ultra":
				GameController2.manager.curDiff = GameDiff.Ultra;
				break;
			default:
				break;
			}
		}
	}

	public void OnLineModeToggleValueChange(bool isOn, GameObject sender) {
		if(isOn) {
			switch (sender.name) {
			case "ShowLine":
				GameController2.manager.curLineMode = LineMode.Show;
				break;
			case "HideLine":
				GameController2.manager.curLineMode = LineMode.Hide;
				break;
			default:
				break;
			}
		}
	}

	public void OnShowModeToggleValueChange(bool isOn, GameObject sender) {
		if(isOn) {
			switch (sender.name) {
			case "ShowNow":
				GameController2.manager.curShowMode = ShowMode.Now;
				break;
			case "ShowAfter":
				GameController2.manager.curShowMode = ShowMode.After;
				break;
			default:
				break;
			}
		}
	}

	public void OnMusicToggleValueChange(bool isOn, GameObject sender) {
		if(isOn) {
			switch (sender.name) {
			case "MusicOn":
				SoundController2.manager.lastShouldPlayMusic = SoundController2.manager.shouldPlayMusic;
				SoundController2.manager.shouldPlayMusic = true;
				break;
			case "MusicOff":
				SoundController2.manager.lastShouldPlayMusic = SoundController2.manager.shouldPlayMusic;
				SoundController2.manager.shouldPlayMusic = false;;
				break;
			default:
				break;
			}
		}
	}

	public void OnMusicSelectToggleValueChange(bool isOn, GameObject sender) {
		if(isOn) {
			SoundController2.manager.curMusicKey = sender.name; 
		}
	}

	public void RestartButtonOnClick() {
		inputArea.gameObject.SetActive (true);
		SettingArea.gameObject.SetActive (false);
		WinArea.gameObject.SetActive (false);
		GameController2.manager.ResetToNormal ();
		simulatePanel.ResetButton ();
	}

	public void ShowWinOperation() {
		inputArea.gameObject.SetActive (false);
		SettingArea.gameObject.SetActive (false);
		WinArea.gameObject.SetActive (true);
	}

	public void ExitButtonOnClick() {
		Application.Quit ();
	}

	public void VolumeValueChange(float value) {
		SoundController2.manager.SetVolume (value);
	}


}
