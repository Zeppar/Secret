using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZRFramework {
	public class ZRFpsCounter {
		private const float calcRate = 0.5f;
		private int frameCount = 0;
		private float rateDuration = 0;
		private int fps = 0;

		public ZRFpsCounter(ZRConsole console) {
			console.onUpdateCallback += Update;
			console.onGUICallback += OnGUI;
		}

		void Update() {
			this.frameCount++;
			this.rateDuration += Time.deltaTime;
			if (this.rateDuration > calcRate) {
				this.fps = (int)(this.frameCount / this.rateDuration);
				this.frameCount = 0;
				this.rateDuration = 0;
			}
		}

		void OnGUI() {
			GUI.color = Color.black;
			GUI.Label (new Rect (80, 20, 120, 20), "fps : " + this.fps);
		}
	}


}