using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System;

namespace ZRFramework {
	public class ZRConsole : MonoBehaviour {
		
		struct ConsoleMessage {
			public readonly string message;
			public readonly string stackTrace;
			public readonly LogType type;
			public ConsoleMessage(string message, string stackTrace, LogType type) {
				this.message = message;
				this.stackTrace = stackTrace;
				this.type = type;
			}
		}
		public delegate void OnGUICallback();
		public OnGUICallback onGUICallback = null;
		public delegate void OnUpdateCallback ();
		public OnUpdateCallback onUpdateCallback = null;
		private static ZRConsole instance = null;
		private bool showGUI = false;
		bool mTouch = false;
		List<ConsoleMessage> entries = new List<ConsoleMessage> ();
		const int margin = 20;
		bool collapse = true;
		bool scrollToBottom = false;
		Vector2 scrollPos;
		GUIContent clearLabel    = new GUIContent("Clear",    "Clear the contents of the console.");
		GUIContent collapseLabel = new GUIContent("Collapse", "Hide repeated messages.");
		GUIContent scrollToBottomLabel = new GUIContent("ScrollToBottom", "Scroll bar always at bottom");
		Rect windowRect = new Rect (margin ,margin + Screen.height * 0.5f - 2 * margin, Screen.width - 2 * margin, Screen.height * 0.5f - 2 * margin);
		private ZRFpsCounter fpsCounter = null;
		private ZRMemoryDetector memoryDetector = null;
		void Start() {
			Application.logMessageReceived += HandleLog;
		}

		void OnDestroy() {
			Application.logMessageReceived -= HandleLog;
		}

		public ZRConsole Awake() {
			if (instance == null) {
				instance = this;
				DontDestroyOnLoad (gameObject);
				fpsCounter = new ZRFpsCounter (this);
				memoryDetector = new ZRMemoryDetector (this);
			}
			return instance;
		}

		void HandleLog(string message, string stackTrace, LogType type) {
			ConsoleMessage entry = new ConsoleMessage (message, stackTrace, type);
			entries.Add (entry);
		}
			
		void Update() {
			#if UNITY_EDITOR
			if(Input.GetKeyUp(KeyCode.Space))
				this.showGUI = !this.showGUI;
			#elif UNITY_ANDROID
			if(Input.GetKeyUp(KeyCode.Escape))
				this.showGUI = !showGUI;
			#elif UNITY_IOS
			if(Input.touchCount == 4) 
				this.showGUI = !showGUI;
			#endif
			if (onUpdateCallback != null)
				onUpdateCallback ();
		}
		
		void OnGUI() {
			if (!this.showGUI)
			return;
			if (this.onGUICallback != null)
				this.onGUICallback ();
			windowRect = GUILayout.Window (123456, windowRect, ConsoleWindow, "Console"); 
		}
			
		void ConsoleWindow(int windowID) {
			if (scrollToBottom) {
				GUILayout.BeginScrollView (Vector2.up * entries.Count * 100.0f);
			} else {
				scrollPos = GUILayout.BeginScrollView (scrollPos);
			}
			for (int i = 0; i < entries.Count; i++) {
				ConsoleMessage entry = entries [i];
				if (collapse && i > 0 && entry.message == entries [i - 1].message) {
					continue;
				}
				switch (entry.type) {
				case LogType.Error:
				case LogType.Exception:
					GUI.contentColor = Color.red;
					break;
				case LogType.Warning:
					GUI.contentColor = Color.yellow;
					break;
				default:
					GUI.contentColor = Color.white;
					break;
				}
				if (entry.type == LogType.Exception) {
					GUILayout.Label (entry.message + " || " + entry.stackTrace);
				} else {
					GUILayout.Label (entry.message);
				}
			}
			GUI.contentColor = Color.white;
			GUILayout.EndScrollView ();
			GUILayout.BeginHorizontal ();
			if (GUILayout.Button(clearLabel)) {
				entries.Clear();
			}
			collapse = GUILayout.Toggle (collapse, collapseLabel, GUILayout.ExpandWidth (false));
			scrollToBottom = GUILayout.Toggle (scrollToBottom, scrollToBottomLabel, GUILayout.ExpandWidth (false));
			GUILayout.EndHorizontal ();
			GUI.DragWindow(new Rect(0, 0, 10000, 20));
		}
	}
}
