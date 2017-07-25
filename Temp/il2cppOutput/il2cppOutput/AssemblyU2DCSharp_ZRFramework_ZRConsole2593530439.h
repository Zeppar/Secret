#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"
#include "UnityEngine_UnityEngine_Rect3681755626.h"

// ZRFramework.ZRConsole/OnGUICallback
struct OnGUICallback_t283275955;
// ZRFramework.ZRConsole/OnUpdateCallback
struct OnUpdateCallback_t1935591433;
// ZRFramework.ZRConsole
struct ZRConsole_t2593530439;
// System.Collections.Generic.List`1<ZRFramework.ZRConsole/ConsoleMessage>
struct List_1_t4159337788;
// UnityEngine.GUIContent
struct GUIContent_t4210063000;
// ZRFramework.ZRFpsCounter
struct ZRFpsCounter_t3293699493;
// ZRFramework.ZRMemoryDetector
struct ZRMemoryDetector_t595100351;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ZRFramework.ZRConsole
struct  ZRConsole_t2593530439  : public MonoBehaviour_t1158329972
{
public:
	// ZRFramework.ZRConsole/OnGUICallback ZRFramework.ZRConsole::onGUICallback
	OnGUICallback_t283275955 * ___onGUICallback_2;
	// ZRFramework.ZRConsole/OnUpdateCallback ZRFramework.ZRConsole::onUpdateCallback
	OnUpdateCallback_t1935591433 * ___onUpdateCallback_3;
	// System.Boolean ZRFramework.ZRConsole::showGUI
	bool ___showGUI_5;
	// System.Boolean ZRFramework.ZRConsole::mTouch
	bool ___mTouch_6;
	// System.Collections.Generic.List`1<ZRFramework.ZRConsole/ConsoleMessage> ZRFramework.ZRConsole::entries
	List_1_t4159337788 * ___entries_7;
	// System.Boolean ZRFramework.ZRConsole::collapse
	bool ___collapse_9;
	// System.Boolean ZRFramework.ZRConsole::scrollToBottom
	bool ___scrollToBottom_10;
	// UnityEngine.Vector2 ZRFramework.ZRConsole::scrollPos
	Vector2_t2243707579  ___scrollPos_11;
	// UnityEngine.GUIContent ZRFramework.ZRConsole::clearLabel
	GUIContent_t4210063000 * ___clearLabel_12;
	// UnityEngine.GUIContent ZRFramework.ZRConsole::collapseLabel
	GUIContent_t4210063000 * ___collapseLabel_13;
	// UnityEngine.GUIContent ZRFramework.ZRConsole::scrollToBottomLabel
	GUIContent_t4210063000 * ___scrollToBottomLabel_14;
	// UnityEngine.Rect ZRFramework.ZRConsole::windowRect
	Rect_t3681755626  ___windowRect_15;
	// ZRFramework.ZRFpsCounter ZRFramework.ZRConsole::fpsCounter
	ZRFpsCounter_t3293699493 * ___fpsCounter_16;
	// ZRFramework.ZRMemoryDetector ZRFramework.ZRConsole::memoryDetector
	ZRMemoryDetector_t595100351 * ___memoryDetector_17;

public:
	inline static int32_t get_offset_of_onGUICallback_2() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___onGUICallback_2)); }
	inline OnGUICallback_t283275955 * get_onGUICallback_2() const { return ___onGUICallback_2; }
	inline OnGUICallback_t283275955 ** get_address_of_onGUICallback_2() { return &___onGUICallback_2; }
	inline void set_onGUICallback_2(OnGUICallback_t283275955 * value)
	{
		___onGUICallback_2 = value;
		Il2CppCodeGenWriteBarrier(&___onGUICallback_2, value);
	}

	inline static int32_t get_offset_of_onUpdateCallback_3() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___onUpdateCallback_3)); }
	inline OnUpdateCallback_t1935591433 * get_onUpdateCallback_3() const { return ___onUpdateCallback_3; }
	inline OnUpdateCallback_t1935591433 ** get_address_of_onUpdateCallback_3() { return &___onUpdateCallback_3; }
	inline void set_onUpdateCallback_3(OnUpdateCallback_t1935591433 * value)
	{
		___onUpdateCallback_3 = value;
		Il2CppCodeGenWriteBarrier(&___onUpdateCallback_3, value);
	}

	inline static int32_t get_offset_of_showGUI_5() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___showGUI_5)); }
	inline bool get_showGUI_5() const { return ___showGUI_5; }
	inline bool* get_address_of_showGUI_5() { return &___showGUI_5; }
	inline void set_showGUI_5(bool value)
	{
		___showGUI_5 = value;
	}

	inline static int32_t get_offset_of_mTouch_6() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___mTouch_6)); }
	inline bool get_mTouch_6() const { return ___mTouch_6; }
	inline bool* get_address_of_mTouch_6() { return &___mTouch_6; }
	inline void set_mTouch_6(bool value)
	{
		___mTouch_6 = value;
	}

	inline static int32_t get_offset_of_entries_7() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___entries_7)); }
	inline List_1_t4159337788 * get_entries_7() const { return ___entries_7; }
	inline List_1_t4159337788 ** get_address_of_entries_7() { return &___entries_7; }
	inline void set_entries_7(List_1_t4159337788 * value)
	{
		___entries_7 = value;
		Il2CppCodeGenWriteBarrier(&___entries_7, value);
	}

	inline static int32_t get_offset_of_collapse_9() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___collapse_9)); }
	inline bool get_collapse_9() const { return ___collapse_9; }
	inline bool* get_address_of_collapse_9() { return &___collapse_9; }
	inline void set_collapse_9(bool value)
	{
		___collapse_9 = value;
	}

	inline static int32_t get_offset_of_scrollToBottom_10() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___scrollToBottom_10)); }
	inline bool get_scrollToBottom_10() const { return ___scrollToBottom_10; }
	inline bool* get_address_of_scrollToBottom_10() { return &___scrollToBottom_10; }
	inline void set_scrollToBottom_10(bool value)
	{
		___scrollToBottom_10 = value;
	}

	inline static int32_t get_offset_of_scrollPos_11() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___scrollPos_11)); }
	inline Vector2_t2243707579  get_scrollPos_11() const { return ___scrollPos_11; }
	inline Vector2_t2243707579 * get_address_of_scrollPos_11() { return &___scrollPos_11; }
	inline void set_scrollPos_11(Vector2_t2243707579  value)
	{
		___scrollPos_11 = value;
	}

	inline static int32_t get_offset_of_clearLabel_12() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___clearLabel_12)); }
	inline GUIContent_t4210063000 * get_clearLabel_12() const { return ___clearLabel_12; }
	inline GUIContent_t4210063000 ** get_address_of_clearLabel_12() { return &___clearLabel_12; }
	inline void set_clearLabel_12(GUIContent_t4210063000 * value)
	{
		___clearLabel_12 = value;
		Il2CppCodeGenWriteBarrier(&___clearLabel_12, value);
	}

	inline static int32_t get_offset_of_collapseLabel_13() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___collapseLabel_13)); }
	inline GUIContent_t4210063000 * get_collapseLabel_13() const { return ___collapseLabel_13; }
	inline GUIContent_t4210063000 ** get_address_of_collapseLabel_13() { return &___collapseLabel_13; }
	inline void set_collapseLabel_13(GUIContent_t4210063000 * value)
	{
		___collapseLabel_13 = value;
		Il2CppCodeGenWriteBarrier(&___collapseLabel_13, value);
	}

	inline static int32_t get_offset_of_scrollToBottomLabel_14() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___scrollToBottomLabel_14)); }
	inline GUIContent_t4210063000 * get_scrollToBottomLabel_14() const { return ___scrollToBottomLabel_14; }
	inline GUIContent_t4210063000 ** get_address_of_scrollToBottomLabel_14() { return &___scrollToBottomLabel_14; }
	inline void set_scrollToBottomLabel_14(GUIContent_t4210063000 * value)
	{
		___scrollToBottomLabel_14 = value;
		Il2CppCodeGenWriteBarrier(&___scrollToBottomLabel_14, value);
	}

	inline static int32_t get_offset_of_windowRect_15() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___windowRect_15)); }
	inline Rect_t3681755626  get_windowRect_15() const { return ___windowRect_15; }
	inline Rect_t3681755626 * get_address_of_windowRect_15() { return &___windowRect_15; }
	inline void set_windowRect_15(Rect_t3681755626  value)
	{
		___windowRect_15 = value;
	}

	inline static int32_t get_offset_of_fpsCounter_16() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___fpsCounter_16)); }
	inline ZRFpsCounter_t3293699493 * get_fpsCounter_16() const { return ___fpsCounter_16; }
	inline ZRFpsCounter_t3293699493 ** get_address_of_fpsCounter_16() { return &___fpsCounter_16; }
	inline void set_fpsCounter_16(ZRFpsCounter_t3293699493 * value)
	{
		___fpsCounter_16 = value;
		Il2CppCodeGenWriteBarrier(&___fpsCounter_16, value);
	}

	inline static int32_t get_offset_of_memoryDetector_17() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439, ___memoryDetector_17)); }
	inline ZRMemoryDetector_t595100351 * get_memoryDetector_17() const { return ___memoryDetector_17; }
	inline ZRMemoryDetector_t595100351 ** get_address_of_memoryDetector_17() { return &___memoryDetector_17; }
	inline void set_memoryDetector_17(ZRMemoryDetector_t595100351 * value)
	{
		___memoryDetector_17 = value;
		Il2CppCodeGenWriteBarrier(&___memoryDetector_17, value);
	}
};

struct ZRConsole_t2593530439_StaticFields
{
public:
	// ZRFramework.ZRConsole ZRFramework.ZRConsole::instance
	ZRConsole_t2593530439 * ___instance_4;

public:
	inline static int32_t get_offset_of_instance_4() { return static_cast<int32_t>(offsetof(ZRConsole_t2593530439_StaticFields, ___instance_4)); }
	inline ZRConsole_t2593530439 * get_instance_4() const { return ___instance_4; }
	inline ZRConsole_t2593530439 ** get_address_of_instance_4() { return &___instance_4; }
	inline void set_instance_4(ZRConsole_t2593530439 * value)
	{
		___instance_4 = value;
		Il2CppCodeGenWriteBarrier(&___instance_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
