#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// LevelManager
struct LevelManager_t3355282079;
// ChessItem
struct ChessItem_t4142475053;
// UnityEngine.Transform
struct Transform_t3275118058;
// LevelList
struct LevelList_t535298330;
// CommonList
struct CommonList_t3854041961;
// ChallengeInfo
struct ChallengeInfo_t2308287783;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LevelManager
struct  LevelManager_t3355282079  : public MonoBehaviour_t1158329972
{
public:
	// ChessItem LevelManager::chessItemPrefab
	ChessItem_t4142475053 * ___chessItemPrefab_3;
	// UnityEngine.Transform LevelManager::content
	Transform_t3275118058 * ___content_4;
	// System.Single LevelManager::itemWidth
	float ___itemWidth_5;
	// System.Single LevelManager::itemHeight
	float ___itemHeight_6;
	// System.Int32 LevelManager::currentLevel
	int32_t ___currentLevel_7;
	// System.Int32 LevelManager::levelCount
	int32_t ___levelCount_8;
	// LevelList LevelManager::allLevelList
	LevelList_t535298330 * ___allLevelList_9;
	// CommonList LevelManager::allCommonList
	CommonList_t3854041961 * ___allCommonList_10;
	// ChallengeInfo LevelManager::challengeInfo
	ChallengeInfo_t2308287783 * ___challengeInfo_11;

public:
	inline static int32_t get_offset_of_chessItemPrefab_3() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___chessItemPrefab_3)); }
	inline ChessItem_t4142475053 * get_chessItemPrefab_3() const { return ___chessItemPrefab_3; }
	inline ChessItem_t4142475053 ** get_address_of_chessItemPrefab_3() { return &___chessItemPrefab_3; }
	inline void set_chessItemPrefab_3(ChessItem_t4142475053 * value)
	{
		___chessItemPrefab_3 = value;
		Il2CppCodeGenWriteBarrier(&___chessItemPrefab_3, value);
	}

	inline static int32_t get_offset_of_content_4() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___content_4)); }
	inline Transform_t3275118058 * get_content_4() const { return ___content_4; }
	inline Transform_t3275118058 ** get_address_of_content_4() { return &___content_4; }
	inline void set_content_4(Transform_t3275118058 * value)
	{
		___content_4 = value;
		Il2CppCodeGenWriteBarrier(&___content_4, value);
	}

	inline static int32_t get_offset_of_itemWidth_5() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___itemWidth_5)); }
	inline float get_itemWidth_5() const { return ___itemWidth_5; }
	inline float* get_address_of_itemWidth_5() { return &___itemWidth_5; }
	inline void set_itemWidth_5(float value)
	{
		___itemWidth_5 = value;
	}

	inline static int32_t get_offset_of_itemHeight_6() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___itemHeight_6)); }
	inline float get_itemHeight_6() const { return ___itemHeight_6; }
	inline float* get_address_of_itemHeight_6() { return &___itemHeight_6; }
	inline void set_itemHeight_6(float value)
	{
		___itemHeight_6 = value;
	}

	inline static int32_t get_offset_of_currentLevel_7() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___currentLevel_7)); }
	inline int32_t get_currentLevel_7() const { return ___currentLevel_7; }
	inline int32_t* get_address_of_currentLevel_7() { return &___currentLevel_7; }
	inline void set_currentLevel_7(int32_t value)
	{
		___currentLevel_7 = value;
	}

	inline static int32_t get_offset_of_levelCount_8() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___levelCount_8)); }
	inline int32_t get_levelCount_8() const { return ___levelCount_8; }
	inline int32_t* get_address_of_levelCount_8() { return &___levelCount_8; }
	inline void set_levelCount_8(int32_t value)
	{
		___levelCount_8 = value;
	}

	inline static int32_t get_offset_of_allLevelList_9() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___allLevelList_9)); }
	inline LevelList_t535298330 * get_allLevelList_9() const { return ___allLevelList_9; }
	inline LevelList_t535298330 ** get_address_of_allLevelList_9() { return &___allLevelList_9; }
	inline void set_allLevelList_9(LevelList_t535298330 * value)
	{
		___allLevelList_9 = value;
		Il2CppCodeGenWriteBarrier(&___allLevelList_9, value);
	}

	inline static int32_t get_offset_of_allCommonList_10() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___allCommonList_10)); }
	inline CommonList_t3854041961 * get_allCommonList_10() const { return ___allCommonList_10; }
	inline CommonList_t3854041961 ** get_address_of_allCommonList_10() { return &___allCommonList_10; }
	inline void set_allCommonList_10(CommonList_t3854041961 * value)
	{
		___allCommonList_10 = value;
		Il2CppCodeGenWriteBarrier(&___allCommonList_10, value);
	}

	inline static int32_t get_offset_of_challengeInfo_11() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___challengeInfo_11)); }
	inline ChallengeInfo_t2308287783 * get_challengeInfo_11() const { return ___challengeInfo_11; }
	inline ChallengeInfo_t2308287783 ** get_address_of_challengeInfo_11() { return &___challengeInfo_11; }
	inline void set_challengeInfo_11(ChallengeInfo_t2308287783 * value)
	{
		___challengeInfo_11 = value;
		Il2CppCodeGenWriteBarrier(&___challengeInfo_11, value);
	}
};

struct LevelManager_t3355282079_StaticFields
{
public:
	// LevelManager LevelManager::manager
	LevelManager_t3355282079 * ___manager_2;

public:
	inline static int32_t get_offset_of_manager_2() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079_StaticFields, ___manager_2)); }
	inline LevelManager_t3355282079 * get_manager_2() const { return ___manager_2; }
	inline LevelManager_t3355282079 ** get_address_of_manager_2() { return &___manager_2; }
	inline void set_manager_2(LevelManager_t3355282079 * value)
	{
		___manager_2 = value;
		Il2CppCodeGenWriteBarrier(&___manager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
