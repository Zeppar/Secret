#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"
#include "UnityEngine_UnityEngine_Rect3681755626.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ZRFramework.ZRMemoryDetector
struct  ZRMemoryDetector_t595100351  : public Il2CppObject
{
public:
	// System.Single ZRFramework.ZRMemoryDetector::ByteToM
	float ___ByteToM_5;
	// UnityEngine.Rect ZRFramework.ZRMemoryDetector::allocMemoryRect
	Rect_t3681755626  ___allocMemoryRect_6;
	// UnityEngine.Rect ZRFramework.ZRMemoryDetector::reservedMemoryRect
	Rect_t3681755626  ___reservedMemoryRect_7;
	// UnityEngine.Rect ZRFramework.ZRMemoryDetector::unusedReservedMemoryRect
	Rect_t3681755626  ___unusedReservedMemoryRect_8;
	// UnityEngine.Rect ZRFramework.ZRMemoryDetector::monoHeapRect
	Rect_t3681755626  ___monoHeapRect_9;
	// UnityEngine.Rect ZRFramework.ZRMemoryDetector::monoUsedRect
	Rect_t3681755626  ___monoUsedRect_10;
	// System.Int32 ZRFramework.ZRMemoryDetector::x
	int32_t ___x_11;
	// System.Int32 ZRFramework.ZRMemoryDetector::y
	int32_t ___y_12;
	// System.Int32 ZRFramework.ZRMemoryDetector::w
	int32_t ___w_13;
	// System.Int32 ZRFramework.ZRMemoryDetector::h
	int32_t ___h_14;

public:
	inline static int32_t get_offset_of_ByteToM_5() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___ByteToM_5)); }
	inline float get_ByteToM_5() const { return ___ByteToM_5; }
	inline float* get_address_of_ByteToM_5() { return &___ByteToM_5; }
	inline void set_ByteToM_5(float value)
	{
		___ByteToM_5 = value;
	}

	inline static int32_t get_offset_of_allocMemoryRect_6() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___allocMemoryRect_6)); }
	inline Rect_t3681755626  get_allocMemoryRect_6() const { return ___allocMemoryRect_6; }
	inline Rect_t3681755626 * get_address_of_allocMemoryRect_6() { return &___allocMemoryRect_6; }
	inline void set_allocMemoryRect_6(Rect_t3681755626  value)
	{
		___allocMemoryRect_6 = value;
	}

	inline static int32_t get_offset_of_reservedMemoryRect_7() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___reservedMemoryRect_7)); }
	inline Rect_t3681755626  get_reservedMemoryRect_7() const { return ___reservedMemoryRect_7; }
	inline Rect_t3681755626 * get_address_of_reservedMemoryRect_7() { return &___reservedMemoryRect_7; }
	inline void set_reservedMemoryRect_7(Rect_t3681755626  value)
	{
		___reservedMemoryRect_7 = value;
	}

	inline static int32_t get_offset_of_unusedReservedMemoryRect_8() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___unusedReservedMemoryRect_8)); }
	inline Rect_t3681755626  get_unusedReservedMemoryRect_8() const { return ___unusedReservedMemoryRect_8; }
	inline Rect_t3681755626 * get_address_of_unusedReservedMemoryRect_8() { return &___unusedReservedMemoryRect_8; }
	inline void set_unusedReservedMemoryRect_8(Rect_t3681755626  value)
	{
		___unusedReservedMemoryRect_8 = value;
	}

	inline static int32_t get_offset_of_monoHeapRect_9() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___monoHeapRect_9)); }
	inline Rect_t3681755626  get_monoHeapRect_9() const { return ___monoHeapRect_9; }
	inline Rect_t3681755626 * get_address_of_monoHeapRect_9() { return &___monoHeapRect_9; }
	inline void set_monoHeapRect_9(Rect_t3681755626  value)
	{
		___monoHeapRect_9 = value;
	}

	inline static int32_t get_offset_of_monoUsedRect_10() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___monoUsedRect_10)); }
	inline Rect_t3681755626  get_monoUsedRect_10() const { return ___monoUsedRect_10; }
	inline Rect_t3681755626 * get_address_of_monoUsedRect_10() { return &___monoUsedRect_10; }
	inline void set_monoUsedRect_10(Rect_t3681755626  value)
	{
		___monoUsedRect_10 = value;
	}

	inline static int32_t get_offset_of_x_11() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___x_11)); }
	inline int32_t get_x_11() const { return ___x_11; }
	inline int32_t* get_address_of_x_11() { return &___x_11; }
	inline void set_x_11(int32_t value)
	{
		___x_11 = value;
	}

	inline static int32_t get_offset_of_y_12() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___y_12)); }
	inline int32_t get_y_12() const { return ___y_12; }
	inline int32_t* get_address_of_y_12() { return &___y_12; }
	inline void set_y_12(int32_t value)
	{
		___y_12 = value;
	}

	inline static int32_t get_offset_of_w_13() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___w_13)); }
	inline int32_t get_w_13() const { return ___w_13; }
	inline int32_t* get_address_of_w_13() { return &___w_13; }
	inline void set_w_13(int32_t value)
	{
		___w_13 = value;
	}

	inline static int32_t get_offset_of_h_14() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351, ___h_14)); }
	inline int32_t get_h_14() const { return ___h_14; }
	inline int32_t* get_address_of_h_14() { return &___h_14; }
	inline void set_h_14(int32_t value)
	{
		___h_14 = value;
	}
};

struct ZRMemoryDetector_t595100351_StaticFields
{
public:
	// System.String ZRFramework.ZRMemoryDetector::TotalAllocMemroyFormation
	String_t* ___TotalAllocMemroyFormation_0;
	// System.String ZRFramework.ZRMemoryDetector::TotalReservedMemoryFormation
	String_t* ___TotalReservedMemoryFormation_1;
	// System.String ZRFramework.ZRMemoryDetector::TotalUnusedReservedMemoryFormation
	String_t* ___TotalUnusedReservedMemoryFormation_2;
	// System.String ZRFramework.ZRMemoryDetector::MonoHeapFormation
	String_t* ___MonoHeapFormation_3;
	// System.String ZRFramework.ZRMemoryDetector::MonoUsedFormation
	String_t* ___MonoUsedFormation_4;

public:
	inline static int32_t get_offset_of_TotalAllocMemroyFormation_0() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351_StaticFields, ___TotalAllocMemroyFormation_0)); }
	inline String_t* get_TotalAllocMemroyFormation_0() const { return ___TotalAllocMemroyFormation_0; }
	inline String_t** get_address_of_TotalAllocMemroyFormation_0() { return &___TotalAllocMemroyFormation_0; }
	inline void set_TotalAllocMemroyFormation_0(String_t* value)
	{
		___TotalAllocMemroyFormation_0 = value;
		Il2CppCodeGenWriteBarrier(&___TotalAllocMemroyFormation_0, value);
	}

	inline static int32_t get_offset_of_TotalReservedMemoryFormation_1() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351_StaticFields, ___TotalReservedMemoryFormation_1)); }
	inline String_t* get_TotalReservedMemoryFormation_1() const { return ___TotalReservedMemoryFormation_1; }
	inline String_t** get_address_of_TotalReservedMemoryFormation_1() { return &___TotalReservedMemoryFormation_1; }
	inline void set_TotalReservedMemoryFormation_1(String_t* value)
	{
		___TotalReservedMemoryFormation_1 = value;
		Il2CppCodeGenWriteBarrier(&___TotalReservedMemoryFormation_1, value);
	}

	inline static int32_t get_offset_of_TotalUnusedReservedMemoryFormation_2() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351_StaticFields, ___TotalUnusedReservedMemoryFormation_2)); }
	inline String_t* get_TotalUnusedReservedMemoryFormation_2() const { return ___TotalUnusedReservedMemoryFormation_2; }
	inline String_t** get_address_of_TotalUnusedReservedMemoryFormation_2() { return &___TotalUnusedReservedMemoryFormation_2; }
	inline void set_TotalUnusedReservedMemoryFormation_2(String_t* value)
	{
		___TotalUnusedReservedMemoryFormation_2 = value;
		Il2CppCodeGenWriteBarrier(&___TotalUnusedReservedMemoryFormation_2, value);
	}

	inline static int32_t get_offset_of_MonoHeapFormation_3() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351_StaticFields, ___MonoHeapFormation_3)); }
	inline String_t* get_MonoHeapFormation_3() const { return ___MonoHeapFormation_3; }
	inline String_t** get_address_of_MonoHeapFormation_3() { return &___MonoHeapFormation_3; }
	inline void set_MonoHeapFormation_3(String_t* value)
	{
		___MonoHeapFormation_3 = value;
		Il2CppCodeGenWriteBarrier(&___MonoHeapFormation_3, value);
	}

	inline static int32_t get_offset_of_MonoUsedFormation_4() { return static_cast<int32_t>(offsetof(ZRMemoryDetector_t595100351_StaticFields, ___MonoUsedFormation_4)); }
	inline String_t* get_MonoUsedFormation_4() const { return ___MonoUsedFormation_4; }
	inline String_t** get_address_of_MonoUsedFormation_4() { return &___MonoUsedFormation_4; }
	inline void set_MonoUsedFormation_4(String_t* value)
	{
		___MonoUsedFormation_4 = value;
		Il2CppCodeGenWriteBarrier(&___MonoUsedFormation_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
