#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// MissionItem
struct MissionItem_t767264539;
// UnityEngine.Transform
struct Transform_t3275118058;
// System.Collections.Generic.List`1<MissionItem>
struct List_1_t136385671;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MissionController
struct  MissionController_t1751066590  : public MonoBehaviour_t1158329972
{
public:
	// MissionItem MissionController::missionItem
	MissionItem_t767264539 * ___missionItem_2;
	// UnityEngine.Transform MissionController::content
	Transform_t3275118058 * ___content_3;
	// System.Collections.Generic.List`1<MissionItem> MissionController::itemList
	List_1_t136385671 * ___itemList_4;

public:
	inline static int32_t get_offset_of_missionItem_2() { return static_cast<int32_t>(offsetof(MissionController_t1751066590, ___missionItem_2)); }
	inline MissionItem_t767264539 * get_missionItem_2() const { return ___missionItem_2; }
	inline MissionItem_t767264539 ** get_address_of_missionItem_2() { return &___missionItem_2; }
	inline void set_missionItem_2(MissionItem_t767264539 * value)
	{
		___missionItem_2 = value;
		Il2CppCodeGenWriteBarrier(&___missionItem_2, value);
	}

	inline static int32_t get_offset_of_content_3() { return static_cast<int32_t>(offsetof(MissionController_t1751066590, ___content_3)); }
	inline Transform_t3275118058 * get_content_3() const { return ___content_3; }
	inline Transform_t3275118058 ** get_address_of_content_3() { return &___content_3; }
	inline void set_content_3(Transform_t3275118058 * value)
	{
		___content_3 = value;
		Il2CppCodeGenWriteBarrier(&___content_3, value);
	}

	inline static int32_t get_offset_of_itemList_4() { return static_cast<int32_t>(offsetof(MissionController_t1751066590, ___itemList_4)); }
	inline List_1_t136385671 * get_itemList_4() const { return ___itemList_4; }
	inline List_1_t136385671 ** get_address_of_itemList_4() { return &___itemList_4; }
	inline void set_itemList_4(List_1_t136385671 * value)
	{
		___itemList_4 = value;
		Il2CppCodeGenWriteBarrier(&___itemList_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
