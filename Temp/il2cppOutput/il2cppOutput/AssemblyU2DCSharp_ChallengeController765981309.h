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
// UnityEngine.UI.Toggle
struct Toggle_t3976754468;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ChallengeController
struct  ChallengeController_t765981309  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text ChallengeController::scoreText
	Text_t356221433 * ___scoreText_2;
	// UnityEngine.UI.Text ChallengeController::levelText
	Text_t356221433 * ___levelText_3;
	// UnityEngine.UI.Text ChallengeController::creatorText
	Text_t356221433 * ___creatorText_4;
	// UnityEngine.UI.Toggle ChallengeController::easyToggle
	Toggle_t3976754468 * ___easyToggle_5;
	// UnityEngine.UI.Toggle ChallengeController::middleToggle
	Toggle_t3976754468 * ___middleToggle_6;
	// UnityEngine.UI.Toggle ChallengeController::hardToggle
	Toggle_t3976754468 * ___hardToggle_7;

public:
	inline static int32_t get_offset_of_scoreText_2() { return static_cast<int32_t>(offsetof(ChallengeController_t765981309, ___scoreText_2)); }
	inline Text_t356221433 * get_scoreText_2() const { return ___scoreText_2; }
	inline Text_t356221433 ** get_address_of_scoreText_2() { return &___scoreText_2; }
	inline void set_scoreText_2(Text_t356221433 * value)
	{
		___scoreText_2 = value;
		Il2CppCodeGenWriteBarrier(&___scoreText_2, value);
	}

	inline static int32_t get_offset_of_levelText_3() { return static_cast<int32_t>(offsetof(ChallengeController_t765981309, ___levelText_3)); }
	inline Text_t356221433 * get_levelText_3() const { return ___levelText_3; }
	inline Text_t356221433 ** get_address_of_levelText_3() { return &___levelText_3; }
	inline void set_levelText_3(Text_t356221433 * value)
	{
		___levelText_3 = value;
		Il2CppCodeGenWriteBarrier(&___levelText_3, value);
	}

	inline static int32_t get_offset_of_creatorText_4() { return static_cast<int32_t>(offsetof(ChallengeController_t765981309, ___creatorText_4)); }
	inline Text_t356221433 * get_creatorText_4() const { return ___creatorText_4; }
	inline Text_t356221433 ** get_address_of_creatorText_4() { return &___creatorText_4; }
	inline void set_creatorText_4(Text_t356221433 * value)
	{
		___creatorText_4 = value;
		Il2CppCodeGenWriteBarrier(&___creatorText_4, value);
	}

	inline static int32_t get_offset_of_easyToggle_5() { return static_cast<int32_t>(offsetof(ChallengeController_t765981309, ___easyToggle_5)); }
	inline Toggle_t3976754468 * get_easyToggle_5() const { return ___easyToggle_5; }
	inline Toggle_t3976754468 ** get_address_of_easyToggle_5() { return &___easyToggle_5; }
	inline void set_easyToggle_5(Toggle_t3976754468 * value)
	{
		___easyToggle_5 = value;
		Il2CppCodeGenWriteBarrier(&___easyToggle_5, value);
	}

	inline static int32_t get_offset_of_middleToggle_6() { return static_cast<int32_t>(offsetof(ChallengeController_t765981309, ___middleToggle_6)); }
	inline Toggle_t3976754468 * get_middleToggle_6() const { return ___middleToggle_6; }
	inline Toggle_t3976754468 ** get_address_of_middleToggle_6() { return &___middleToggle_6; }
	inline void set_middleToggle_6(Toggle_t3976754468 * value)
	{
		___middleToggle_6 = value;
		Il2CppCodeGenWriteBarrier(&___middleToggle_6, value);
	}

	inline static int32_t get_offset_of_hardToggle_7() { return static_cast<int32_t>(offsetof(ChallengeController_t765981309, ___hardToggle_7)); }
	inline Toggle_t3976754468 * get_hardToggle_7() const { return ___hardToggle_7; }
	inline Toggle_t3976754468 ** get_address_of_hardToggle_7() { return &___hardToggle_7; }
	inline void set_hardToggle_7(Toggle_t3976754468 * value)
	{
		___hardToggle_7 = value;
		Il2CppCodeGenWriteBarrier(&___hardToggle_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
