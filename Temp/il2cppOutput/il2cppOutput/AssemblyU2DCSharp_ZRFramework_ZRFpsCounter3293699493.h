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

// ZRFramework.ZRFpsCounter
struct  ZRFpsCounter_t3293699493  : public Il2CppObject
{
public:
	// System.Int32 ZRFramework.ZRFpsCounter::frameCount
	int32_t ___frameCount_1;
	// System.Single ZRFramework.ZRFpsCounter::rateDuration
	float ___rateDuration_2;
	// System.Int32 ZRFramework.ZRFpsCounter::fps
	int32_t ___fps_3;

public:
	inline static int32_t get_offset_of_frameCount_1() { return static_cast<int32_t>(offsetof(ZRFpsCounter_t3293699493, ___frameCount_1)); }
	inline int32_t get_frameCount_1() const { return ___frameCount_1; }
	inline int32_t* get_address_of_frameCount_1() { return &___frameCount_1; }
	inline void set_frameCount_1(int32_t value)
	{
		___frameCount_1 = value;
	}

	inline static int32_t get_offset_of_rateDuration_2() { return static_cast<int32_t>(offsetof(ZRFpsCounter_t3293699493, ___rateDuration_2)); }
	inline float get_rateDuration_2() const { return ___rateDuration_2; }
	inline float* get_address_of_rateDuration_2() { return &___rateDuration_2; }
	inline void set_rateDuration_2(float value)
	{
		___rateDuration_2 = value;
	}

	inline static int32_t get_offset_of_fps_3() { return static_cast<int32_t>(offsetof(ZRFpsCounter_t3293699493, ___fps_3)); }
	inline int32_t get_fps_3() const { return ___fps_3; }
	inline int32_t* get_address_of_fps_3() { return &___fps_3; }
	inline void set_fps_3(int32_t value)
	{
		___fps_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
