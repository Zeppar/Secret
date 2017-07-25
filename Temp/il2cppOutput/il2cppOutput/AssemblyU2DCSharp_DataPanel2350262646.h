#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.UI.Image[]
struct ImageU5BU5D_t590162004;
// UnityEngine.Sprite
struct Sprite_t309593783;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// DataPanel
struct  DataPanel_t2350262646  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text DataPanel::modeText
	Text_t356221433 * ___modeText_2;
	// UnityEngine.UI.Text DataPanel::scoreText
	Text_t356221433 * ___scoreText_3;
	// UnityEngine.UI.Image[] DataPanel::starArr
	ImageU5BU5D_t590162004* ___starArr_4;
	// UnityEngine.UI.Text DataPanel::timeText
	Text_t356221433 * ___timeText_5;
	// UnityEngine.Sprite DataPanel::normalStar
	Sprite_t309593783 * ___normalStar_6;
	// UnityEngine.Sprite DataPanel::highlightStar
	Sprite_t309593783 * ___highlightStar_7;

public:
	inline static int32_t get_offset_of_modeText_2() { return static_cast<int32_t>(offsetof(DataPanel_t2350262646, ___modeText_2)); }
	inline Text_t356221433 * get_modeText_2() const { return ___modeText_2; }
	inline Text_t356221433 ** get_address_of_modeText_2() { return &___modeText_2; }
	inline void set_modeText_2(Text_t356221433 * value)
	{
		___modeText_2 = value;
		Il2CppCodeGenWriteBarrier(&___modeText_2, value);
	}

	inline static int32_t get_offset_of_scoreText_3() { return static_cast<int32_t>(offsetof(DataPanel_t2350262646, ___scoreText_3)); }
	inline Text_t356221433 * get_scoreText_3() const { return ___scoreText_3; }
	inline Text_t356221433 ** get_address_of_scoreText_3() { return &___scoreText_3; }
	inline void set_scoreText_3(Text_t356221433 * value)
	{
		___scoreText_3 = value;
		Il2CppCodeGenWriteBarrier(&___scoreText_3, value);
	}

	inline static int32_t get_offset_of_starArr_4() { return static_cast<int32_t>(offsetof(DataPanel_t2350262646, ___starArr_4)); }
	inline ImageU5BU5D_t590162004* get_starArr_4() const { return ___starArr_4; }
	inline ImageU5BU5D_t590162004** get_address_of_starArr_4() { return &___starArr_4; }
	inline void set_starArr_4(ImageU5BU5D_t590162004* value)
	{
		___starArr_4 = value;
		Il2CppCodeGenWriteBarrier(&___starArr_4, value);
	}

	inline static int32_t get_offset_of_timeText_5() { return static_cast<int32_t>(offsetof(DataPanel_t2350262646, ___timeText_5)); }
	inline Text_t356221433 * get_timeText_5() const { return ___timeText_5; }
	inline Text_t356221433 ** get_address_of_timeText_5() { return &___timeText_5; }
	inline void set_timeText_5(Text_t356221433 * value)
	{
		___timeText_5 = value;
		Il2CppCodeGenWriteBarrier(&___timeText_5, value);
	}

	inline static int32_t get_offset_of_normalStar_6() { return static_cast<int32_t>(offsetof(DataPanel_t2350262646, ___normalStar_6)); }
	inline Sprite_t309593783 * get_normalStar_6() const { return ___normalStar_6; }
	inline Sprite_t309593783 ** get_address_of_normalStar_6() { return &___normalStar_6; }
	inline void set_normalStar_6(Sprite_t309593783 * value)
	{
		___normalStar_6 = value;
		Il2CppCodeGenWriteBarrier(&___normalStar_6, value);
	}

	inline static int32_t get_offset_of_highlightStar_7() { return static_cast<int32_t>(offsetof(DataPanel_t2350262646, ___highlightStar_7)); }
	inline Sprite_t309593783 * get_highlightStar_7() const { return ___highlightStar_7; }
	inline Sprite_t309593783 ** get_address_of_highlightStar_7() { return &___highlightStar_7; }
	inline void set_highlightStar_7(Sprite_t309593783 * value)
	{
		___highlightStar_7 = value;
		Il2CppCodeGenWriteBarrier(&___highlightStar_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
