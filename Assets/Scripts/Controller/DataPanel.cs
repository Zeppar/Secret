using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPanel : MonoBehaviour {

	public Text modeText;
	public Text scoreText;
	public Image[] starArr;
	public Text timeText;
	public Sprite normalStar;
	public Sprite highlightStar;

	public void setContent(string modeStr, int score, int starCount, int time) {
		modeText.text = modeStr;
		scoreText.text = score.ToString ();
		for (int i = 0; i < starArr.Length; i++) {
			if (i < starCount) {
				starArr [i].sprite = highlightStar;
			} else {
				starArr [i].sprite = normalStar;
			}
		}
		timeText.text = time.ToString ();
	}

}
