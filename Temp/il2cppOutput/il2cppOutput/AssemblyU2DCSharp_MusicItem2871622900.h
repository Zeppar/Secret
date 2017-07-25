#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_PoolObject202793199.h"

// UnityEngine.UI.Text
struct Text_t356221433;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MusicItem
struct  MusicItem_t2871622900  : public PoolObject_t202793199
{
public:
	// UnityEngine.UI.Text MusicItem::nameText
	Text_t356221433 * ___nameText_3;
	// System.Boolean MusicItem::selected
	bool ___selected_4;

public:
	inline static int32_t get_offset_of_nameText_3() { return static_cast<int32_t>(offsetof(MusicItem_t2871622900, ___nameText_3)); }
	inline Text_t356221433 * get_nameText_3() const { return ___nameText_3; }
	inline Text_t356221433 ** get_address_of_nameText_3() { return &___nameText_3; }
	inline void set_nameText_3(Text_t356221433 * value)
	{
		___nameText_3 = value;
		Il2CppCodeGenWriteBarrier(&___nameText_3, value);
	}

	inline static int32_t get_offset_of_selected_4() { return static_cast<int32_t>(offsetof(MusicItem_t2871622900, ___selected_4)); }
	inline bool get_selected_4() const { return ___selected_4; }
	inline bool* get_address_of_selected_4() { return &___selected_4; }
	inline void set_selected_4(bool value)
	{
		___selected_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
