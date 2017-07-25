#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// NotificationCenter
struct NotificationCenter_t4076733310;
// System.Collections.Generic.Dictionary`2<NotificationLayer,System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<UnityEngine.Component>>>
struct Dictionary_2_t2310159188;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// NotificationCenter
struct  NotificationCenter_t4076733310  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.Dictionary`2<NotificationLayer,System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<UnityEngine.Component>>> NotificationCenter::notiDict
	Dictionary_2_t2310159188 * ___notiDict_3;

public:
	inline static int32_t get_offset_of_notiDict_3() { return static_cast<int32_t>(offsetof(NotificationCenter_t4076733310, ___notiDict_3)); }
	inline Dictionary_2_t2310159188 * get_notiDict_3() const { return ___notiDict_3; }
	inline Dictionary_2_t2310159188 ** get_address_of_notiDict_3() { return &___notiDict_3; }
	inline void set_notiDict_3(Dictionary_2_t2310159188 * value)
	{
		___notiDict_3 = value;
		Il2CppCodeGenWriteBarrier(&___notiDict_3, value);
	}
};

struct NotificationCenter_t4076733310_StaticFields
{
public:
	// NotificationCenter NotificationCenter::defaultCenter
	NotificationCenter_t4076733310 * ___defaultCenter_2;

public:
	inline static int32_t get_offset_of_defaultCenter_2() { return static_cast<int32_t>(offsetof(NotificationCenter_t4076733310_StaticFields, ___defaultCenter_2)); }
	inline NotificationCenter_t4076733310 * get_defaultCenter_2() const { return ___defaultCenter_2; }
	inline NotificationCenter_t4076733310 ** get_address_of_defaultCenter_2() { return &___defaultCenter_2; }
	inline void set_defaultCenter_2(NotificationCenter_t4076733310 * value)
	{
		___defaultCenter_2 = value;
		Il2CppCodeGenWriteBarrier(&___defaultCenter_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
