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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameUIController
struct  GameUIController_t2638725024  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text GameUIController::stepText
	Text_t356221433 * ___stepText_2;
	// UnityEngine.UI.Text GameUIController::timeText
	Text_t356221433 * ___timeText_3;
	// UnityEngine.UI.Text GameUIController::blackText
	Text_t356221433 * ___blackText_4;
	// UnityEngine.UI.Text GameUIController::whiteText
	Text_t356221433 * ___whiteText_5;

public:
	inline static int32_t get_offset_of_stepText_2() { return static_cast<int32_t>(offsetof(GameUIController_t2638725024, ___stepText_2)); }
	inline Text_t356221433 * get_stepText_2() const { return ___stepText_2; }
	inline Text_t356221433 ** get_address_of_stepText_2() { return &___stepText_2; }
	inline void set_stepText_2(Text_t356221433 * value)
	{
		___stepText_2 = value;
		Il2CppCodeGenWriteBarrier(&___stepText_2, value);
	}

	inline static int32_t get_offset_of_timeText_3() { return static_cast<int32_t>(offsetof(GameUIController_t2638725024, ___timeText_3)); }
	inline Text_t356221433 * get_timeText_3() const { return ___timeText_3; }
	inline Text_t356221433 ** get_address_of_timeText_3() { return &___timeText_3; }
	inline void set_timeText_3(Text_t356221433 * value)
	{
		___timeText_3 = value;
		Il2CppCodeGenWriteBarrier(&___timeText_3, value);
	}

	inline static int32_t get_offset_of_blackText_4() { return static_cast<int32_t>(offsetof(GameUIController_t2638725024, ___blackText_4)); }
	inline Text_t356221433 * get_blackText_4() const { return ___blackText_4; }
	inline Text_t356221433 ** get_address_of_blackText_4() { return &___blackText_4; }
	inline void set_blackText_4(Text_t356221433 * value)
	{
		___blackText_4 = value;
		Il2CppCodeGenWriteBarrier(&___blackText_4, value);
	}

	inline static int32_t get_offset_of_whiteText_5() { return static_cast<int32_t>(offsetof(GameUIController_t2638725024, ___whiteText_5)); }
	inline Text_t356221433 * get_whiteText_5() const { return ___whiteText_5; }
	inline Text_t356221433 ** get_address_of_whiteText_5() { return &___whiteText_5; }
	inline void set_whiteText_5(Text_t356221433 * value)
	{
		___whiteText_5 = value;
		Il2CppCodeGenWriteBarrier(&___whiteText_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
