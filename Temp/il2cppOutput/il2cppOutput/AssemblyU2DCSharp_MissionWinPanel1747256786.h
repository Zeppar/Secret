#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Image[]
struct ImageU5BU5D_t590162004;
// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.Sprite
struct Sprite_t309593783;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MissionWinPanel
struct  MissionWinPanel_t1747256786  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Image[] MissionWinPanel::starArr
	ImageU5BU5D_t590162004* ___starArr_2;
	// UnityEngine.UI.Text MissionWinPanel::ScoreText
	Text_t356221433 * ___ScoreText_3;
	// UnityEngine.Sprite MissionWinPanel::normalStar
	Sprite_t309593783 * ___normalStar_4;
	// UnityEngine.Sprite MissionWinPanel::highLightStar
	Sprite_t309593783 * ___highLightStar_5;
	// UnityEngine.UI.Text MissionWinPanel::levelText
	Text_t356221433 * ___levelText_6;

public:
	inline static int32_t get_offset_of_starArr_2() { return static_cast<int32_t>(offsetof(MissionWinPanel_t1747256786, ___starArr_2)); }
	inline ImageU5BU5D_t590162004* get_starArr_2() const { return ___starArr_2; }
	inline ImageU5BU5D_t590162004** get_address_of_starArr_2() { return &___starArr_2; }
	inline void set_starArr_2(ImageU5BU5D_t590162004* value)
	{
		___starArr_2 = value;
		Il2CppCodeGenWriteBarrier(&___starArr_2, value);
	}

	inline static int32_t get_offset_of_ScoreText_3() { return static_cast<int32_t>(offsetof(MissionWinPanel_t1747256786, ___ScoreText_3)); }
	inline Text_t356221433 * get_ScoreText_3() const { return ___ScoreText_3; }
	inline Text_t356221433 ** get_address_of_ScoreText_3() { return &___ScoreText_3; }
	inline void set_ScoreText_3(Text_t356221433 * value)
	{
		___ScoreText_3 = value;
		Il2CppCodeGenWriteBarrier(&___ScoreText_3, value);
	}

	inline static int32_t get_offset_of_normalStar_4() { return static_cast<int32_t>(offsetof(MissionWinPanel_t1747256786, ___normalStar_4)); }
	inline Sprite_t309593783 * get_normalStar_4() const { return ___normalStar_4; }
	inline Sprite_t309593783 ** get_address_of_normalStar_4() { return &___normalStar_4; }
	inline void set_normalStar_4(Sprite_t309593783 * value)
	{
		___normalStar_4 = value;
		Il2CppCodeGenWriteBarrier(&___normalStar_4, value);
	}

	inline static int32_t get_offset_of_highLightStar_5() { return static_cast<int32_t>(offsetof(MissionWinPanel_t1747256786, ___highLightStar_5)); }
	inline Sprite_t309593783 * get_highLightStar_5() const { return ___highLightStar_5; }
	inline Sprite_t309593783 ** get_address_of_highLightStar_5() { return &___highLightStar_5; }
	inline void set_highLightStar_5(Sprite_t309593783 * value)
	{
		___highLightStar_5 = value;
		Il2CppCodeGenWriteBarrier(&___highLightStar_5, value);
	}

	inline static int32_t get_offset_of_levelText_6() { return static_cast<int32_t>(offsetof(MissionWinPanel_t1747256786, ___levelText_6)); }
	inline Text_t356221433 * get_levelText_6() const { return ___levelText_6; }
	inline Text_t356221433 ** get_address_of_levelText_6() { return &___levelText_6; }
	inline void set_levelText_6(Text_t356221433 * value)
	{
		___levelText_6 = value;
		Il2CppCodeGenWriteBarrier(&___levelText_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
