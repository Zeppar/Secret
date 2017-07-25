using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameBottomPanel : MonoBehaviour, IPointerClickHandler {

	public Text topText;
	public GameObject answerPanel;
	public GameObject dataPanel;

	public void OnPointerClick(PointerEventData data) {
		if (GameController.manager.curLinkMode == LinkMode.Advance) {
			answerPanel.gameObject.SetActive (!answerPanel.gameObject.activeSelf);
			dataPanel.gameObject.SetActive (!dataPanel.gameObject.activeSelf);
			if (dataPanel.activeSelf)
				topText.text = "Data";
			else
				topText.text = "Pattern";
		}
	}

	void Update() {
		if (GameController.manager.curLinkMode == LinkMode.Basic) {
			if (answerPanel.gameObject.activeSelf)
				answerPanel.gameObject.SetActive (false);
			if (!dataPanel.gameObject.activeSelf)
				dataPanel.gameObject.SetActive (true);
		}
	}

}
