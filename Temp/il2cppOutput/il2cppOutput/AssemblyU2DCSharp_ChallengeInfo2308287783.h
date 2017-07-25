#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ChallengeInfo
struct  ChallengeInfo_t2308287783  : public Il2CppObject
{
public:
	// System.Int32 ChallengeInfo::score
	int32_t ___score_0;
	// System.Int32 ChallengeInfo::level
	int32_t ___level_1;
	// System.String ChallengeInfo::creator
	String_t* ___creator_2;

public:
	inline static int32_t get_offset_of_score_0() { return static_cast<int32_t>(offsetof(ChallengeInfo_t2308287783, ___score_0)); }
	inline int32_t get_score_0() const { return ___score_0; }
	inline int32_t* get_address_of_score_0() { return &___score_0; }
	inline void set_score_0(int32_t value)
	{
		___score_0 = value;
	}

	inline static int32_t get_offset_of_level_1() { return static_cast<int32_t>(offsetof(ChallengeInfo_t2308287783, ___level_1)); }
	inline int32_t get_level_1() const { return ___level_1; }
	inline int32_t* get_address_of_level_1() { return &___level_1; }
	inline void set_level_1(int32_t value)
	{
		___level_1 = value;
	}

	inline static int32_t get_offset_of_creator_2() { return static_cast<int32_t>(offsetof(ChallengeInfo_t2308287783, ___creator_2)); }
	inline String_t* get_creator_2() const { return ___creator_2; }
	inline String_t** get_address_of_creator_2() { return &___creator_2; }
	inline void set_creator_2(String_t* value)
	{
		___creator_2 = value;
		Il2CppCodeGenWriteBarrier(&___creator_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
