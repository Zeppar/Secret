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
// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameBottomPanel
struct  GameBottomPanel_t2241133101  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text GameBottomPanel::topText
	Text_t356221433 * ___topText_2;
	// UnityEngine.GameObject GameBottomPanel::answerPanel
	GameObject_t1756533147 * ___answerPanel_3;
	// UnityEngine.GameObject GameBottomPanel::dataPanel
	GameObject_t1756533147 * ___dataPanel_4;

public:
	inline static int32_t get_offset_of_topText_2() { return static_cast<int32_t>(offsetof(GameBottomPanel_t2241133101, ___topText_2)); }
	inline Text_t356221433 * get_topText_2() const { return ___topText_2; }
	inline Text_t356221433 ** get_address_of_topText_2() { return &___topText_2; }
	inline void set_topText_2(Text_t356221433 * value)
	{
		___topText_2 = value;
		Il2CppCodeGenWriteBarrier(&___topText_2, value);
	}

	inline static int32_t get_offset_of_answerPanel_3() { return static_cast<int32_t>(offsetof(GameBottomPanel_t2241133101, ___answerPanel_3)); }
	inline GameObject_t1756533147 * get_answerPanel_3() const { return ___answerPanel_3; }
	inline GameObject_t1756533147 ** get_address_of_answerPanel_3() { return &___answerPanel_3; }
	inline void set_answerPanel_3(GameObject_t1756533147 * value)
	{
		___answerPanel_3 = value;
		Il2CppCodeGenWriteBarrier(&___answerPanel_3, value);
	}

	inline static int32_t get_offset_of_dataPanel_4() { return static_cast<int32_t>(offsetof(GameBottomPanel_t2241133101, ___dataPanel_4)); }
	inline GameObject_t1756533147 * get_dataPanel_4() const { return ___dataPanel_4; }
	inline GameObject_t1756533147 ** get_address_of_dataPanel_4() { return &___dataPanel_4; }
	inline void set_dataPanel_4(GameObject_t1756533147 * value)
	{
		___dataPanel_4 = value;
		Il2CppCodeGenWriteBarrier(&___dataPanel_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
