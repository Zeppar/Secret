#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.Collections.Generic.Dictionary`2<System.String,ObjectPool>
struct Dictionary_2_t308849773;
// PoolManager
struct PoolManager_t2106959589;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PoolManager
struct  PoolManager_t2106959589  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,ObjectPool> PoolManager::poolDict
	Dictionary_2_t308849773 * ___poolDict_2;

public:
	inline static int32_t get_offset_of_poolDict_2() { return static_cast<int32_t>(offsetof(PoolManager_t2106959589, ___poolDict_2)); }
	inline Dictionary_2_t308849773 * get_poolDict_2() const { return ___poolDict_2; }
	inline Dictionary_2_t308849773 ** get_address_of_poolDict_2() { return &___poolDict_2; }
	inline void set_poolDict_2(Dictionary_2_t308849773 * value)
	{
		___poolDict_2 = value;
		Il2CppCodeGenWriteBarrier(&___poolDict_2, value);
	}
};

struct PoolManager_t2106959589_StaticFields
{
public:
	// PoolManager PoolManager::manager
	PoolManager_t2106959589 * ___manager_3;

public:
	inline static int32_t get_offset_of_manager_3() { return static_cast<int32_t>(offsetof(PoolManager_t2106959589_StaticFields, ___manager_3)); }
	inline PoolManager_t2106959589 * get_manager_3() const { return ___manager_3; }
	inline PoolManager_t2106959589 ** get_address_of_manager_3() { return &___manager_3; }
	inline void set_manager_3(PoolManager_t2106959589 * value)
	{
		___manager_3 = value;
		Il2CppCodeGenWriteBarrier(&___manager_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
