#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CommonInfo
struct  CommonInfo_t2301512861  : public Il2CppObject
{
public:
	// System.Int32 CommonInfo::score
	int32_t ___score_0;
	// System.Single CommonInfo::timer
	float ___timer_1;

public:
	inline static int32_t get_offset_of_score_0() { return static_cast<int32_t>(offsetof(CommonInfo_t2301512861, ___score_0)); }
	inline int32_t get_score_0() const { return ___score_0; }
	inline int32_t* get_address_of_score_0() { return &___score_0; }
	inline void set_score_0(int32_t value)
	{
		___score_0 = value;
	}

	inline static int32_t get_offset_of_timer_1() { return static_cast<int32_t>(offsetof(CommonInfo_t2301512861, ___timer_1)); }
	inline float get_timer_1() const { return ___timer_1; }
	inline float* get_address_of_timer_1() { return &___timer_1; }
	inline void set_timer_1(float value)
	{
		___timer_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
