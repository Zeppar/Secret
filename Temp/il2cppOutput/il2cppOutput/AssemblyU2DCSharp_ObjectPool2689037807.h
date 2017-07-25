#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.Collections.Generic.List`1<PoolObject>
struct List_1_t3866881627;
// PoolObject
struct PoolObject_t202793199;
// System.Action`1<PoolObject>
struct Action_1_t4592581;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ObjectPool
struct  ObjectPool_t2689037807  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.List`1<PoolObject> ObjectPool::activeList
	List_1_t3866881627 * ___activeList_2;
	// System.Collections.Generic.List`1<PoolObject> ObjectPool::inactiveList
	List_1_t3866881627 * ___inactiveList_3;
	// System.Collections.Generic.List`1<PoolObject> ObjectPool::removeList
	List_1_t3866881627 * ___removeList_4;
	// PoolObject ObjectPool::prefab
	PoolObject_t202793199 * ___prefab_5;
	// System.Int32 ObjectPool::LenghtAddCount
	int32_t ___LenghtAddCount_6;
	// System.Boolean ObjectPool::autoRelease
	bool ___autoRelease_7;
	// System.Single ObjectPool::autoReleaseTime
	float ___autoReleaseTime_8;
	// System.Single ObjectPool::autoReleaseCountPerTime
	float ___autoReleaseCountPerTime_9;
	// System.Int32 ObjectPool::minRemainCount
	int32_t ___minRemainCount_10;
	// System.Single ObjectPool::time
	float ___time_11;

public:
	inline static int32_t get_offset_of_activeList_2() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___activeList_2)); }
	inline List_1_t3866881627 * get_activeList_2() const { return ___activeList_2; }
	inline List_1_t3866881627 ** get_address_of_activeList_2() { return &___activeList_2; }
	inline void set_activeList_2(List_1_t3866881627 * value)
	{
		___activeList_2 = value;
		Il2CppCodeGenWriteBarrier(&___activeList_2, value);
	}

	inline static int32_t get_offset_of_inactiveList_3() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___inactiveList_3)); }
	inline List_1_t3866881627 * get_inactiveList_3() const { return ___inactiveList_3; }
	inline List_1_t3866881627 ** get_address_of_inactiveList_3() { return &___inactiveList_3; }
	inline void set_inactiveList_3(List_1_t3866881627 * value)
	{
		___inactiveList_3 = value;
		Il2CppCodeGenWriteBarrier(&___inactiveList_3, value);
	}

	inline static int32_t get_offset_of_removeList_4() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___removeList_4)); }
	inline List_1_t3866881627 * get_removeList_4() const { return ___removeList_4; }
	inline List_1_t3866881627 ** get_address_of_removeList_4() { return &___removeList_4; }
	inline void set_removeList_4(List_1_t3866881627 * value)
	{
		___removeList_4 = value;
		Il2CppCodeGenWriteBarrier(&___removeList_4, value);
	}

	inline static int32_t get_offset_of_prefab_5() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___prefab_5)); }
	inline PoolObject_t202793199 * get_prefab_5() const { return ___prefab_5; }
	inline PoolObject_t202793199 ** get_address_of_prefab_5() { return &___prefab_5; }
	inline void set_prefab_5(PoolObject_t202793199 * value)
	{
		___prefab_5 = value;
		Il2CppCodeGenWriteBarrier(&___prefab_5, value);
	}

	inline static int32_t get_offset_of_LenghtAddCount_6() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___LenghtAddCount_6)); }
	inline int32_t get_LenghtAddCount_6() const { return ___LenghtAddCount_6; }
	inline int32_t* get_address_of_LenghtAddCount_6() { return &___LenghtAddCount_6; }
	inline void set_LenghtAddCount_6(int32_t value)
	{
		___LenghtAddCount_6 = value;
	}

	inline static int32_t get_offset_of_autoRelease_7() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___autoRelease_7)); }
	inline bool get_autoRelease_7() const { return ___autoRelease_7; }
	inline bool* get_address_of_autoRelease_7() { return &___autoRelease_7; }
	inline void set_autoRelease_7(bool value)
	{
		___autoRelease_7 = value;
	}

	inline static int32_t get_offset_of_autoReleaseTime_8() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___autoReleaseTime_8)); }
	inline float get_autoReleaseTime_8() const { return ___autoReleaseTime_8; }
	inline float* get_address_of_autoReleaseTime_8() { return &___autoReleaseTime_8; }
	inline void set_autoReleaseTime_8(float value)
	{
		___autoReleaseTime_8 = value;
	}

	inline static int32_t get_offset_of_autoReleaseCountPerTime_9() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___autoReleaseCountPerTime_9)); }
	inline float get_autoReleaseCountPerTime_9() const { return ___autoReleaseCountPerTime_9; }
	inline float* get_address_of_autoReleaseCountPerTime_9() { return &___autoReleaseCountPerTime_9; }
	inline void set_autoReleaseCountPerTime_9(float value)
	{
		___autoReleaseCountPerTime_9 = value;
	}

	inline static int32_t get_offset_of_minRemainCount_10() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___minRemainCount_10)); }
	inline int32_t get_minRemainCount_10() const { return ___minRemainCount_10; }
	inline int32_t* get_address_of_minRemainCount_10() { return &___minRemainCount_10; }
	inline void set_minRemainCount_10(int32_t value)
	{
		___minRemainCount_10 = value;
	}

	inline static int32_t get_offset_of_time_11() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807, ___time_11)); }
	inline float get_time_11() const { return ___time_11; }
	inline float* get_address_of_time_11() { return &___time_11; }
	inline void set_time_11(float value)
	{
		___time_11 = value;
	}
};

struct ObjectPool_t2689037807_StaticFields
{
public:
	// System.Action`1<PoolObject> ObjectPool::<>f__am$cache0
	Action_1_t4592581 * ___U3CU3Ef__amU24cache0_12;

public:
	inline static int32_t get_offset_of_U3CU3Ef__amU24cache0_12() { return static_cast<int32_t>(offsetof(ObjectPool_t2689037807_StaticFields, ___U3CU3Ef__amU24cache0_12)); }
	inline Action_1_t4592581 * get_U3CU3Ef__amU24cache0_12() const { return ___U3CU3Ef__amU24cache0_12; }
	inline Action_1_t4592581 ** get_address_of_U3CU3Ef__amU24cache0_12() { return &___U3CU3Ef__amU24cache0_12; }
	inline void set_U3CU3Ef__amU24cache0_12(Action_1_t4592581 * value)
	{
		___U3CU3Ef__amU24cache0_12 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__amU24cache0_12, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
