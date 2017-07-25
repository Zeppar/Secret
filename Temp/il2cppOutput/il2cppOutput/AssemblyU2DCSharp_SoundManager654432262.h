#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// SoundManager
struct SoundManager_t654432262;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.AudioClip>
struct Dictionary_2_t3847337892;
// UnityEngine.AudioClip[]
struct AudioClipU5BU5D_t2203355011;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SoundManager
struct  SoundManager_t654432262  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.AudioSource SoundManager::bgAudio
	AudioSource_t1135106623 * ___bgAudio_3;
	// UnityEngine.AudioSource SoundManager::effectAduio
	AudioSource_t1135106623 * ___effectAduio_4;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.AudioClip> SoundManager::musicDictionary
	Dictionary_2_t3847337892 * ___musicDictionary_5;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.AudioClip> SoundManager::effectDictionary
	Dictionary_2_t3847337892 * ___effectDictionary_6;
	// UnityEngine.AudioClip[] SoundManager::musicClipArr
	AudioClipU5BU5D_t2203355011* ___musicClipArr_7;
	// UnityEngine.AudioClip[] SoundManager::effectClipArr
	AudioClipU5BU5D_t2203355011* ___effectClipArr_8;
	// System.String SoundManager::currentMusicName
	String_t* ___currentMusicName_9;

public:
	inline static int32_t get_offset_of_bgAudio_3() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___bgAudio_3)); }
	inline AudioSource_t1135106623 * get_bgAudio_3() const { return ___bgAudio_3; }
	inline AudioSource_t1135106623 ** get_address_of_bgAudio_3() { return &___bgAudio_3; }
	inline void set_bgAudio_3(AudioSource_t1135106623 * value)
	{
		___bgAudio_3 = value;
		Il2CppCodeGenWriteBarrier(&___bgAudio_3, value);
	}

	inline static int32_t get_offset_of_effectAduio_4() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___effectAduio_4)); }
	inline AudioSource_t1135106623 * get_effectAduio_4() const { return ___effectAduio_4; }
	inline AudioSource_t1135106623 ** get_address_of_effectAduio_4() { return &___effectAduio_4; }
	inline void set_effectAduio_4(AudioSource_t1135106623 * value)
	{
		___effectAduio_4 = value;
		Il2CppCodeGenWriteBarrier(&___effectAduio_4, value);
	}

	inline static int32_t get_offset_of_musicDictionary_5() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___musicDictionary_5)); }
	inline Dictionary_2_t3847337892 * get_musicDictionary_5() const { return ___musicDictionary_5; }
	inline Dictionary_2_t3847337892 ** get_address_of_musicDictionary_5() { return &___musicDictionary_5; }
	inline void set_musicDictionary_5(Dictionary_2_t3847337892 * value)
	{
		___musicDictionary_5 = value;
		Il2CppCodeGenWriteBarrier(&___musicDictionary_5, value);
	}

	inline static int32_t get_offset_of_effectDictionary_6() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___effectDictionary_6)); }
	inline Dictionary_2_t3847337892 * get_effectDictionary_6() const { return ___effectDictionary_6; }
	inline Dictionary_2_t3847337892 ** get_address_of_effectDictionary_6() { return &___effectDictionary_6; }
	inline void set_effectDictionary_6(Dictionary_2_t3847337892 * value)
	{
		___effectDictionary_6 = value;
		Il2CppCodeGenWriteBarrier(&___effectDictionary_6, value);
	}

	inline static int32_t get_offset_of_musicClipArr_7() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___musicClipArr_7)); }
	inline AudioClipU5BU5D_t2203355011* get_musicClipArr_7() const { return ___musicClipArr_7; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_musicClipArr_7() { return &___musicClipArr_7; }
	inline void set_musicClipArr_7(AudioClipU5BU5D_t2203355011* value)
	{
		___musicClipArr_7 = value;
		Il2CppCodeGenWriteBarrier(&___musicClipArr_7, value);
	}

	inline static int32_t get_offset_of_effectClipArr_8() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___effectClipArr_8)); }
	inline AudioClipU5BU5D_t2203355011* get_effectClipArr_8() const { return ___effectClipArr_8; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_effectClipArr_8() { return &___effectClipArr_8; }
	inline void set_effectClipArr_8(AudioClipU5BU5D_t2203355011* value)
	{
		___effectClipArr_8 = value;
		Il2CppCodeGenWriteBarrier(&___effectClipArr_8, value);
	}

	inline static int32_t get_offset_of_currentMusicName_9() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___currentMusicName_9)); }
	inline String_t* get_currentMusicName_9() const { return ___currentMusicName_9; }
	inline String_t** get_address_of_currentMusicName_9() { return &___currentMusicName_9; }
	inline void set_currentMusicName_9(String_t* value)
	{
		___currentMusicName_9 = value;
		Il2CppCodeGenWriteBarrier(&___currentMusicName_9, value);
	}
};

struct SoundManager_t654432262_StaticFields
{
public:
	// SoundManager SoundManager::manager
	SoundManager_t654432262 * ___manager_2;

public:
	inline static int32_t get_offset_of_manager_2() { return static_cast<int32_t>(offsetof(SoundManager_t654432262_StaticFields, ___manager_2)); }
	inline SoundManager_t654432262 * get_manager_2() const { return ___manager_2; }
	inline SoundManager_t654432262 ** get_address_of_manager_2() { return &___manager_2; }
	inline void set_manager_2(SoundManager_t654432262 * value)
	{
		___manager_2 = value;
		Il2CppCodeGenWriteBarrier(&___manager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
