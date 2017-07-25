#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// SoundController2
struct SoundController2_t3056423831;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.AudioClip>
struct Dictionary_2_t3847337892;
// System.Collections.Generic.List`1<UnityEngine.AudioClip>
struct List_1_t1301679762;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SoundController2
struct  SoundController2_t3056423831  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.AudioSource SoundController2::bgMusic
	AudioSource_t1135106623 * ___bgMusic_3;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.AudioClip> SoundController2::_soundDictionary
	Dictionary_2_t3847337892 * ____soundDictionary_4;
	// System.Collections.Generic.List`1<UnityEngine.AudioClip> SoundController2::audioList
	List_1_t1301679762 * ___audioList_5;
	// System.Boolean SoundController2::shouldPlayMusic
	bool ___shouldPlayMusic_6;
	// System.Boolean SoundController2::lastShouldPlayMusic
	bool ___lastShouldPlayMusic_7;
	// System.String SoundController2::curMusicKey
	String_t* ___curMusicKey_8;
	// System.String SoundController2::preMusicKey
	String_t* ___preMusicKey_9;

public:
	inline static int32_t get_offset_of_bgMusic_3() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ___bgMusic_3)); }
	inline AudioSource_t1135106623 * get_bgMusic_3() const { return ___bgMusic_3; }
	inline AudioSource_t1135106623 ** get_address_of_bgMusic_3() { return &___bgMusic_3; }
	inline void set_bgMusic_3(AudioSource_t1135106623 * value)
	{
		___bgMusic_3 = value;
		Il2CppCodeGenWriteBarrier(&___bgMusic_3, value);
	}

	inline static int32_t get_offset_of__soundDictionary_4() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ____soundDictionary_4)); }
	inline Dictionary_2_t3847337892 * get__soundDictionary_4() const { return ____soundDictionary_4; }
	inline Dictionary_2_t3847337892 ** get_address_of__soundDictionary_4() { return &____soundDictionary_4; }
	inline void set__soundDictionary_4(Dictionary_2_t3847337892 * value)
	{
		____soundDictionary_4 = value;
		Il2CppCodeGenWriteBarrier(&____soundDictionary_4, value);
	}

	inline static int32_t get_offset_of_audioList_5() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ___audioList_5)); }
	inline List_1_t1301679762 * get_audioList_5() const { return ___audioList_5; }
	inline List_1_t1301679762 ** get_address_of_audioList_5() { return &___audioList_5; }
	inline void set_audioList_5(List_1_t1301679762 * value)
	{
		___audioList_5 = value;
		Il2CppCodeGenWriteBarrier(&___audioList_5, value);
	}

	inline static int32_t get_offset_of_shouldPlayMusic_6() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ___shouldPlayMusic_6)); }
	inline bool get_shouldPlayMusic_6() const { return ___shouldPlayMusic_6; }
	inline bool* get_address_of_shouldPlayMusic_6() { return &___shouldPlayMusic_6; }
	inline void set_shouldPlayMusic_6(bool value)
	{
		___shouldPlayMusic_6 = value;
	}

	inline static int32_t get_offset_of_lastShouldPlayMusic_7() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ___lastShouldPlayMusic_7)); }
	inline bool get_lastShouldPlayMusic_7() const { return ___lastShouldPlayMusic_7; }
	inline bool* get_address_of_lastShouldPlayMusic_7() { return &___lastShouldPlayMusic_7; }
	inline void set_lastShouldPlayMusic_7(bool value)
	{
		___lastShouldPlayMusic_7 = value;
	}

	inline static int32_t get_offset_of_curMusicKey_8() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ___curMusicKey_8)); }
	inline String_t* get_curMusicKey_8() const { return ___curMusicKey_8; }
	inline String_t** get_address_of_curMusicKey_8() { return &___curMusicKey_8; }
	inline void set_curMusicKey_8(String_t* value)
	{
		___curMusicKey_8 = value;
		Il2CppCodeGenWriteBarrier(&___curMusicKey_8, value);
	}

	inline static int32_t get_offset_of_preMusicKey_9() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831, ___preMusicKey_9)); }
	inline String_t* get_preMusicKey_9() const { return ___preMusicKey_9; }
	inline String_t** get_address_of_preMusicKey_9() { return &___preMusicKey_9; }
	inline void set_preMusicKey_9(String_t* value)
	{
		___preMusicKey_9 = value;
		Il2CppCodeGenWriteBarrier(&___preMusicKey_9, value);
	}
};

struct SoundController2_t3056423831_StaticFields
{
public:
	// SoundController2 SoundController2::manager
	SoundController2_t3056423831 * ___manager_2;

public:
	inline static int32_t get_offset_of_manager_2() { return static_cast<int32_t>(offsetof(SoundController2_t3056423831_StaticFields, ___manager_2)); }
	inline SoundController2_t3056423831 * get_manager_2() const { return ___manager_2; }
	inline SoundController2_t3056423831 ** get_address_of_manager_2() { return &___manager_2; }
	inline void set_manager_2(SoundController2_t3056423831 * value)
	{
		___manager_2 = value;
		Il2CppCodeGenWriteBarrier(&___manager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
