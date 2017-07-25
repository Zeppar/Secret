#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// ObjectPool
struct ObjectPool_t2689037807;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PoolObject
struct  PoolObject_t202793199  : public MonoBehaviour_t1158329972
{
public:
	// ObjectPool PoolObject::pool
	ObjectPool_t2689037807 * ___pool_2;

public:
	inline static int32_t get_offset_of_pool_2() { return static_cast<int32_t>(offsetof(PoolObject_t202793199, ___pool_2)); }
	inline ObjectPool_t2689037807 * get_pool_2() const { return ___pool_2; }
	inline ObjectPool_t2689037807 ** get_address_of_pool_2() { return &___pool_2; }
	inline void set_pool_2(ObjectPool_t2689037807 * value)
	{
		___pool_2 = value;
		Il2CppCodeGenWriteBarrier(&___pool_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
