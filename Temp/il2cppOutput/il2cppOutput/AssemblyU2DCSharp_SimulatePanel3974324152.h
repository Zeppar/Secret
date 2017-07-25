#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Button
struct Button_t2872111280;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SimulatePanel
struct  SimulatePanel_t3974324152  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Button SimulatePanel::resetButton
	Button_t2872111280 * ___resetButton_2;
	// UnityEngine.UI.Button SimulatePanel::confirmButton
	Button_t2872111280 * ___confirmButton_3;
	// UnityEngine.UI.Button SimulatePanel::goButton
	Button_t2872111280 * ___goButton_4;

public:
	inline static int32_t get_offset_of_resetButton_2() { return static_cast<int32_t>(offsetof(SimulatePanel_t3974324152, ___resetButton_2)); }
	inline Button_t2872111280 * get_resetButton_2() const { return ___resetButton_2; }
	inline Button_t2872111280 ** get_address_of_resetButton_2() { return &___resetButton_2; }
	inline void set_resetButton_2(Button_t2872111280 * value)
	{
		___resetButton_2 = value;
		Il2CppCodeGenWriteBarrier(&___resetButton_2, value);
	}

	inline static int32_t get_offset_of_confirmButton_3() { return static_cast<int32_t>(offsetof(SimulatePanel_t3974324152, ___confirmButton_3)); }
	inline Button_t2872111280 * get_confirmButton_3() const { return ___confirmButton_3; }
	inline Button_t2872111280 ** get_address_of_confirmButton_3() { return &___confirmButton_3; }
	inline void set_confirmButton_3(Button_t2872111280 * value)
	{
		___confirmButton_3 = value;
		Il2CppCodeGenWriteBarrier(&___confirmButton_3, value);
	}

	inline static int32_t get_offset_of_goButton_4() { return static_cast<int32_t>(offsetof(SimulatePanel_t3974324152, ___goButton_4)); }
	inline Button_t2872111280 * get_goButton_4() const { return ___goButton_4; }
	inline Button_t2872111280 ** get_address_of_goButton_4() { return &___goButton_4; }
	inline void set_goButton_4(Button_t2872111280 * value)
	{
		___goButton_4 = value;
		Il2CppCodeGenWriteBarrier(&___goButton_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
