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
// UnityEngine.UI.InputField
struct InputField_t1631627530;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ChallengeWinPanel
struct  ChallengeWinPanel_t452409403  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text ChallengeWinPanel::levelText
	Text_t356221433 * ___levelText_2;
	// UnityEngine.UI.Text ChallengeWinPanel::scoreText
	Text_t356221433 * ___scoreText_3;
	// UnityEngine.UI.InputField ChallengeWinPanel::input
	InputField_t1631627530 * ___input_4;

public:
	inline static int32_t get_offset_of_levelText_2() { return static_cast<int32_t>(offsetof(ChallengeWinPanel_t452409403, ___levelText_2)); }
	inline Text_t356221433 * get_levelText_2() const { return ___levelText_2; }
	inline Text_t356221433 ** get_address_of_levelText_2() { return &___levelText_2; }
	inline void set_levelText_2(Text_t356221433 * value)
	{
		___levelText_2 = value;
		Il2CppCodeGenWriteBarrier(&___levelText_2, value);
	}

	inline static int32_t get_offset_of_scoreText_3() { return static_cast<int32_t>(offsetof(ChallengeWinPanel_t452409403, ___scoreText_3)); }
	inline Text_t356221433 * get_scoreText_3() const { return ___scoreText_3; }
	inline Text_t356221433 ** get_address_of_scoreText_3() { return &___scoreText_3; }
	inline void set_scoreText_3(Text_t356221433 * value)
	{
		___scoreText_3 = value;
		Il2CppCodeGenWriteBarrier(&___scoreText_3, value);
	}

	inline static int32_t get_offset_of_input_4() { return static_cast<int32_t>(offsetof(ChallengeWinPanel_t452409403, ___input_4)); }
	inline InputField_t1631627530 * get_input_4() const { return ___input_4; }
	inline InputField_t1631627530 ** get_address_of_input_4() { return &___input_4; }
	inline void set_input_4(InputField_t1631627530 * value)
	{
		___input_4 = value;
		Il2CppCodeGenWriteBarrier(&___input_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
