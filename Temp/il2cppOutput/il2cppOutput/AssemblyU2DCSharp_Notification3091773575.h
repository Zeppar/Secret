#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// UnityEngine.Component
struct Component_t3819376471;
// System.String
struct String_t;
// System.Collections.Hashtable
struct Hashtable_t909839986;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Notification
struct  Notification_t3091773575  : public Il2CppObject
{
public:
	// UnityEngine.Component Notification::sender
	Component_t3819376471 * ___sender_0;
	// System.String Notification::name
	String_t* ___name_1;
	// System.Collections.Hashtable Notification::data
	Hashtable_t909839986 * ___data_2;

public:
	inline static int32_t get_offset_of_sender_0() { return static_cast<int32_t>(offsetof(Notification_t3091773575, ___sender_0)); }
	inline Component_t3819376471 * get_sender_0() const { return ___sender_0; }
	inline Component_t3819376471 ** get_address_of_sender_0() { return &___sender_0; }
	inline void set_sender_0(Component_t3819376471 * value)
	{
		___sender_0 = value;
		Il2CppCodeGenWriteBarrier(&___sender_0, value);
	}

	inline static int32_t get_offset_of_name_1() { return static_cast<int32_t>(offsetof(Notification_t3091773575, ___name_1)); }
	inline String_t* get_name_1() const { return ___name_1; }
	inline String_t** get_address_of_name_1() { return &___name_1; }
	inline void set_name_1(String_t* value)
	{
		___name_1 = value;
		Il2CppCodeGenWriteBarrier(&___name_1, value);
	}

	inline static int32_t get_offset_of_data_2() { return static_cast<int32_t>(offsetof(Notification_t3091773575, ___data_2)); }
	inline Hashtable_t909839986 * get_data_2() const { return ___data_2; }
	inline Hashtable_t909839986 ** get_address_of_data_2() { return &___data_2; }
	inline void set_data_2(Hashtable_t909839986 * value)
	{
		___data_2 = value;
		Il2CppCodeGenWriteBarrier(&___data_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
