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

// LevelInfo
struct  LevelInfo_t2713086606  : public Il2CppObject
{
public:
	// System.Boolean LevelInfo::isLocked
	bool ___isLocked_0;
	// System.Int32 LevelInfo::score
	int32_t ___score_1;
	// System.Int32 LevelInfo::starCount
	int32_t ___starCount_2;
	// System.Int32 LevelInfo::stepCount
	int32_t ___stepCount_3;
	// System.Single LevelInfo::timer
	float ___timer_4;

public:
	inline static int32_t get_offset_of_isLocked_0() { return static_cast<int32_t>(offsetof(LevelInfo_t2713086606, ___isLocked_0)); }
	inline bool get_isLocked_0() const { return ___isLocked_0; }
	inline bool* get_address_of_isLocked_0() { return &___isLocked_0; }
	inline void set_isLocked_0(bool value)
	{
		___isLocked_0 = value;
	}

	inline static int32_t get_offset_of_score_1() { return static_cast<int32_t>(offsetof(LevelInfo_t2713086606, ___score_1)); }
	inline int32_t get_score_1() const { return ___score_1; }
	inline int32_t* get_address_of_score_1() { return &___score_1; }
	inline void set_score_1(int32_t value)
	{
		___score_1 = value;
	}

	inline static int32_t get_offset_of_starCount_2() { return static_cast<int32_t>(offsetof(LevelInfo_t2713086606, ___starCount_2)); }
	inline int32_t get_starCount_2() const { return ___starCount_2; }
	inline int32_t* get_address_of_starCount_2() { return &___starCount_2; }
	inline void set_starCount_2(int32_t value)
	{
		___starCount_2 = value;
	}

	inline static int32_t get_offset_of_stepCount_3() { return static_cast<int32_t>(offsetof(LevelInfo_t2713086606, ___stepCount_3)); }
	inline int32_t get_stepCount_3() const { return ___stepCount_3; }
	inline int32_t* get_address_of_stepCount_3() { return &___stepCount_3; }
	inline void set_stepCount_3(int32_t value)
	{
		___stepCount_3 = value;
	}

	inline static int32_t get_offset_of_timer_4() { return static_cast<int32_t>(offsetof(LevelInfo_t2713086606, ___timer_4)); }
	inline float get_timer_4() const { return ___timer_4; }
	inline float* get_address_of_timer_4() { return &___timer_4; }
	inline void set_timer_4(float value)
	{
		___timer_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
