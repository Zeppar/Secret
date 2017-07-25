#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Toggle
struct Toggle_t3976754468;
// UnityEngine.UI.Slider
struct Slider_t297367283;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SettingController
struct  SettingController_t758060492  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Toggle SettingController::showModeNowToggle
	Toggle_t3976754468 * ___showModeNowToggle_2;
	// UnityEngine.UI.Toggle SettingController::showModeAfterToggle
	Toggle_t3976754468 * ___showModeAfterToggle_3;
	// UnityEngine.UI.Toggle SettingController::lineModeShowToggle
	Toggle_t3976754468 * ___lineModeShowToggle_4;
	// UnityEngine.UI.Toggle SettingController::lineModeHideToggle
	Toggle_t3976754468 * ___lineModeHideToggle_5;
	// UnityEngine.UI.Slider SettingController::musicSlider
	Slider_t297367283 * ___musicSlider_6;
	// UnityEngine.UI.Slider SettingController::effectSlider
	Slider_t297367283 * ___effectSlider_7;

public:
	inline static int32_t get_offset_of_showModeNowToggle_2() { return static_cast<int32_t>(offsetof(SettingController_t758060492, ___showModeNowToggle_2)); }
	inline Toggle_t3976754468 * get_showModeNowToggle_2() const { return ___showModeNowToggle_2; }
	inline Toggle_t3976754468 ** get_address_of_showModeNowToggle_2() { return &___showModeNowToggle_2; }
	inline void set_showModeNowToggle_2(Toggle_t3976754468 * value)
	{
		___showModeNowToggle_2 = value;
		Il2CppCodeGenWriteBarrier(&___showModeNowToggle_2, value);
	}

	inline static int32_t get_offset_of_showModeAfterToggle_3() { return static_cast<int32_t>(offsetof(SettingController_t758060492, ___showModeAfterToggle_3)); }
	inline Toggle_t3976754468 * get_showModeAfterToggle_3() const { return ___showModeAfterToggle_3; }
	inline Toggle_t3976754468 ** get_address_of_showModeAfterToggle_3() { return &___showModeAfterToggle_3; }
	inline void set_showModeAfterToggle_3(Toggle_t3976754468 * value)
	{
		___showModeAfterToggle_3 = value;
		Il2CppCodeGenWriteBarrier(&___showModeAfterToggle_3, value);
	}

	inline static int32_t get_offset_of_lineModeShowToggle_4() { return static_cast<int32_t>(offsetof(SettingController_t758060492, ___lineModeShowToggle_4)); }
	inline Toggle_t3976754468 * get_lineModeShowToggle_4() const { return ___lineModeShowToggle_4; }
	inline Toggle_t3976754468 ** get_address_of_lineModeShowToggle_4() { return &___lineModeShowToggle_4; }
	inline void set_lineModeShowToggle_4(Toggle_t3976754468 * value)
	{
		___lineModeShowToggle_4 = value;
		Il2CppCodeGenWriteBarrier(&___lineModeShowToggle_4, value);
	}

	inline static int32_t get_offset_of_lineModeHideToggle_5() { return static_cast<int32_t>(offsetof(SettingController_t758060492, ___lineModeHideToggle_5)); }
	inline Toggle_t3976754468 * get_lineModeHideToggle_5() const { return ___lineModeHideToggle_5; }
	inline Toggle_t3976754468 ** get_address_of_lineModeHideToggle_5() { return &___lineModeHideToggle_5; }
	inline void set_lineModeHideToggle_5(Toggle_t3976754468 * value)
	{
		___lineModeHideToggle_5 = value;
		Il2CppCodeGenWriteBarrier(&___lineModeHideToggle_5, value);
	}

	inline static int32_t get_offset_of_musicSlider_6() { return static_cast<int32_t>(offsetof(SettingController_t758060492, ___musicSlider_6)); }
	inline Slider_t297367283 * get_musicSlider_6() const { return ___musicSlider_6; }
	inline Slider_t297367283 ** get_address_of_musicSlider_6() { return &___musicSlider_6; }
	inline void set_musicSlider_6(Slider_t297367283 * value)
	{
		___musicSlider_6 = value;
		Il2CppCodeGenWriteBarrier(&___musicSlider_6, value);
	}

	inline static int32_t get_offset_of_effectSlider_7() { return static_cast<int32_t>(offsetof(SettingController_t758060492, ___effectSlider_7)); }
	inline Slider_t297367283 * get_effectSlider_7() const { return ___effectSlider_7; }
	inline Slider_t297367283 ** get_address_of_effectSlider_7() { return &___effectSlider_7; }
	inline void set_effectSlider_7(Slider_t297367283 * value)
	{
		___effectSlider_7 = value;
		Il2CppCodeGenWriteBarrier(&___effectSlider_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
