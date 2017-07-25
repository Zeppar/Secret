#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_ValueType3507792607.h"
#include "UnityEngine_UnityEngine_LogType1559732862.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ZRFramework.ZRConsole/ConsoleMessage
struct  ConsoleMessage_t495249360 
{
public:
	// System.String ZRFramework.ZRConsole/ConsoleMessage::message
	String_t* ___message_0;
	// System.String ZRFramework.ZRConsole/ConsoleMessage::stackTrace
	String_t* ___stackTrace_1;
	// UnityEngine.LogType ZRFramework.ZRConsole/ConsoleMessage::type
	int32_t ___type_2;

public:
	inline static int32_t get_offset_of_message_0() { return static_cast<int32_t>(offsetof(ConsoleMessage_t495249360, ___message_0)); }
	inline String_t* get_message_0() const { return ___message_0; }
	inline String_t** get_address_of_message_0() { return &___message_0; }
	inline void set_message_0(String_t* value)
	{
		___message_0 = value;
		Il2CppCodeGenWriteBarrier(&___message_0, value);
	}

	inline static int32_t get_offset_of_stackTrace_1() { return static_cast<int32_t>(offsetof(ConsoleMessage_t495249360, ___stackTrace_1)); }
	inline String_t* get_stackTrace_1() const { return ___stackTrace_1; }
	inline String_t** get_address_of_stackTrace_1() { return &___stackTrace_1; }
	inline void set_stackTrace_1(String_t* value)
	{
		___stackTrace_1 = value;
		Il2CppCodeGenWriteBarrier(&___stackTrace_1, value);
	}

	inline static int32_t get_offset_of_type_2() { return static_cast<int32_t>(offsetof(ConsoleMessage_t495249360, ___type_2)); }
	inline int32_t get_type_2() const { return ___type_2; }
	inline int32_t* get_address_of_type_2() { return &___type_2; }
	inline void set_type_2(int32_t value)
	{
		___type_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of ZRFramework.ZRConsole/ConsoleMessage
struct ConsoleMessage_t495249360_marshaled_pinvoke
{
	char* ___message_0;
	char* ___stackTrace_1;
	int32_t ___type_2;
};
// Native definition for COM marshalling of ZRFramework.ZRConsole/ConsoleMessage
struct ConsoleMessage_t495249360_marshaled_com
{
	Il2CppChar* ___message_0;
	Il2CppChar* ___stackTrace_1;
	int32_t ___type_2;
};
