#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Transform
struct Transform_t3275118058;
// MusicItem
struct MusicItem_t2871622900;
// UnityEngine.UI.Button
struct Button_t2872111280;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SelectMusicController
struct  SelectMusicController_t3264700511  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Transform SelectMusicController::musicContent
	Transform_t3275118058 * ___musicContent_2;
	// MusicItem SelectMusicController::musicItemPrefab
	MusicItem_t2871622900 * ___musicItemPrefab_3;
	// UnityEngine.UI.Button SelectMusicController::confirmButton
	Button_t2872111280 * ___confirmButton_5;

public:
	inline static int32_t get_offset_of_musicContent_2() { return static_cast<int32_t>(offsetof(SelectMusicController_t3264700511, ___musicContent_2)); }
	inline Transform_t3275118058 * get_musicContent_2() const { return ___musicContent_2; }
	inline Transform_t3275118058 ** get_address_of_musicContent_2() { return &___musicContent_2; }
	inline void set_musicContent_2(Transform_t3275118058 * value)
	{
		___musicContent_2 = value;
		Il2CppCodeGenWriteBarrier(&___musicContent_2, value);
	}

	inline static int32_t get_offset_of_musicItemPrefab_3() { return static_cast<int32_t>(offsetof(SelectMusicController_t3264700511, ___musicItemPrefab_3)); }
	inline MusicItem_t2871622900 * get_musicItemPrefab_3() const { return ___musicItemPrefab_3; }
	inline MusicItem_t2871622900 ** get_address_of_musicItemPrefab_3() { return &___musicItemPrefab_3; }
	inline void set_musicItemPrefab_3(MusicItem_t2871622900 * value)
	{
		___musicItemPrefab_3 = value;
		Il2CppCodeGenWriteBarrier(&___musicItemPrefab_3, value);
	}

	inline static int32_t get_offset_of_confirmButton_5() { return static_cast<int32_t>(offsetof(SelectMusicController_t3264700511, ___confirmButton_5)); }
	inline Button_t2872111280 * get_confirmButton_5() const { return ___confirmButton_5; }
	inline Button_t2872111280 ** get_address_of_confirmButton_5() { return &___confirmButton_5; }
	inline void set_confirmButton_5(Button_t2872111280 * value)
	{
		___confirmButton_5 = value;
		Il2CppCodeGenWriteBarrier(&___confirmButton_5, value);
	}
};

struct SelectMusicController_t3264700511_StaticFields
{
public:
	// MusicItem SelectMusicController::selectedMusicItem
	MusicItem_t2871622900 * ___selectedMusicItem_4;

public:
	inline static int32_t get_offset_of_selectedMusicItem_4() { return static_cast<int32_t>(offsetof(SelectMusicController_t3264700511_StaticFields, ___selectedMusicItem_4)); }
	inline MusicItem_t2871622900 * get_selectedMusicItem_4() const { return ___selectedMusicItem_4; }
	inline MusicItem_t2871622900 ** get_address_of_selectedMusicItem_4() { return &___selectedMusicItem_4; }
	inline void set_selectedMusicItem_4(MusicItem_t2871622900 * value)
	{
		___selectedMusicItem_4 = value;
		Il2CppCodeGenWriteBarrier(&___selectedMusicItem_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
