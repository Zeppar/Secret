﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Collections.Generic.Dictionary`2<NotificationLayer,System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<UnityEngine.Component>>>
struct Dictionary_2_t2310159188;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2/ValueCollection<NotificationLayer,System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<UnityEngine.Component>>>
struct  ValueCollection_t1013219031  : public Il2CppObject
{
public:
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/ValueCollection::dictionary
	Dictionary_2_t2310159188 * ___dictionary_0;

public:
	inline static int32_t get_offset_of_dictionary_0() { return static_cast<int32_t>(offsetof(ValueCollection_t1013219031, ___dictionary_0)); }
	inline Dictionary_2_t2310159188 * get_dictionary_0() const { return ___dictionary_0; }
	inline Dictionary_2_t2310159188 ** get_address_of_dictionary_0() { return &___dictionary_0; }
	inline void set_dictionary_0(Dictionary_2_t2310159188 * value)
	{
		___dictionary_0 = value;
		Il2CppCodeGenWriteBarrier(&___dictionary_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif