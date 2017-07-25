#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_PoolObject202793199.h"

// UnityEngine.Sprite
struct Sprite_t309593783;
// UnityEngine.UI.Image
struct Image_t2042527209;
// UnityEngine.UI.Text
struct Text_t356221433;
// LevelInfo
struct LevelInfo_t2713086606;
// UnityEngine.UI.Image[]
struct ImageU5BU5D_t590162004;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MissionItem
struct  MissionItem_t767264539  : public PoolObject_t202793199
{
public:
	// UnityEngine.Sprite MissionItem::normalSprite
	Sprite_t309593783 * ___normalSprite_3;
	// UnityEngine.Sprite MissionItem::lockSprite
	Sprite_t309593783 * ___lockSprite_4;
	// UnityEngine.UI.Image MissionItem::backgroundImage
	Image_t2042527209 * ___backgroundImage_5;
	// UnityEngine.UI.Text MissionItem::levelText
	Text_t356221433 * ___levelText_6;
	// System.Int32 MissionItem::level
	int32_t ___level_7;
	// System.Boolean MissionItem::locked
	bool ___locked_8;
	// LevelInfo MissionItem::missionInfo
	LevelInfo_t2713086606 * ___missionInfo_9;
	// UnityEngine.UI.Image[] MissionItem::starArr
	ImageU5BU5D_t590162004* ___starArr_10;
	// UnityEngine.Sprite MissionItem::normalStar
	Sprite_t309593783 * ___normalStar_11;
	// UnityEngine.Sprite MissionItem::highlightStar
	Sprite_t309593783 * ___highlightStar_12;

public:
	inline static int32_t get_offset_of_normalSprite_3() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___normalSprite_3)); }
	inline Sprite_t309593783 * get_normalSprite_3() const { return ___normalSprite_3; }
	inline Sprite_t309593783 ** get_address_of_normalSprite_3() { return &___normalSprite_3; }
	inline void set_normalSprite_3(Sprite_t309593783 * value)
	{
		___normalSprite_3 = value;
		Il2CppCodeGenWriteBarrier(&___normalSprite_3, value);
	}

	inline static int32_t get_offset_of_lockSprite_4() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___lockSprite_4)); }
	inline Sprite_t309593783 * get_lockSprite_4() const { return ___lockSprite_4; }
	inline Sprite_t309593783 ** get_address_of_lockSprite_4() { return &___lockSprite_4; }
	inline void set_lockSprite_4(Sprite_t309593783 * value)
	{
		___lockSprite_4 = value;
		Il2CppCodeGenWriteBarrier(&___lockSprite_4, value);
	}

	inline static int32_t get_offset_of_backgroundImage_5() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___backgroundImage_5)); }
	inline Image_t2042527209 * get_backgroundImage_5() const { return ___backgroundImage_5; }
	inline Image_t2042527209 ** get_address_of_backgroundImage_5() { return &___backgroundImage_5; }
	inline void set_backgroundImage_5(Image_t2042527209 * value)
	{
		___backgroundImage_5 = value;
		Il2CppCodeGenWriteBarrier(&___backgroundImage_5, value);
	}

	inline static int32_t get_offset_of_levelText_6() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___levelText_6)); }
	inline Text_t356221433 * get_levelText_6() const { return ___levelText_6; }
	inline Text_t356221433 ** get_address_of_levelText_6() { return &___levelText_6; }
	inline void set_levelText_6(Text_t356221433 * value)
	{
		___levelText_6 = value;
		Il2CppCodeGenWriteBarrier(&___levelText_6, value);
	}

	inline static int32_t get_offset_of_level_7() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___level_7)); }
	inline int32_t get_level_7() const { return ___level_7; }
	inline int32_t* get_address_of_level_7() { return &___level_7; }
	inline void set_level_7(int32_t value)
	{
		___level_7 = value;
	}

	inline static int32_t get_offset_of_locked_8() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___locked_8)); }
	inline bool get_locked_8() const { return ___locked_8; }
	inline bool* get_address_of_locked_8() { return &___locked_8; }
	inline void set_locked_8(bool value)
	{
		___locked_8 = value;
	}

	inline static int32_t get_offset_of_missionInfo_9() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___missionInfo_9)); }
	inline LevelInfo_t2713086606 * get_missionInfo_9() const { return ___missionInfo_9; }
	inline LevelInfo_t2713086606 ** get_address_of_missionInfo_9() { return &___missionInfo_9; }
	inline void set_missionInfo_9(LevelInfo_t2713086606 * value)
	{
		___missionInfo_9 = value;
		Il2CppCodeGenWriteBarrier(&___missionInfo_9, value);
	}

	inline static int32_t get_offset_of_starArr_10() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___starArr_10)); }
	inline ImageU5BU5D_t590162004* get_starArr_10() const { return ___starArr_10; }
	inline ImageU5BU5D_t590162004** get_address_of_starArr_10() { return &___starArr_10; }
	inline void set_starArr_10(ImageU5BU5D_t590162004* value)
	{
		___starArr_10 = value;
		Il2CppCodeGenWriteBarrier(&___starArr_10, value);
	}

	inline static int32_t get_offset_of_normalStar_11() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___normalStar_11)); }
	inline Sprite_t309593783 * get_normalStar_11() const { return ___normalStar_11; }
	inline Sprite_t309593783 ** get_address_of_normalStar_11() { return &___normalStar_11; }
	inline void set_normalStar_11(Sprite_t309593783 * value)
	{
		___normalStar_11 = value;
		Il2CppCodeGenWriteBarrier(&___normalStar_11, value);
	}

	inline static int32_t get_offset_of_highlightStar_12() { return static_cast<int32_t>(offsetof(MissionItem_t767264539, ___highlightStar_12)); }
	inline Sprite_t309593783 * get_highlightStar_12() const { return ___highlightStar_12; }
	inline Sprite_t309593783 ** get_address_of_highlightStar_12() { return &___highlightStar_12; }
	inline void set_highlightStar_12(Sprite_t309593783 * value)
	{
		___highlightStar_12 = value;
		Il2CppCodeGenWriteBarrier(&___highlightStar_12, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
