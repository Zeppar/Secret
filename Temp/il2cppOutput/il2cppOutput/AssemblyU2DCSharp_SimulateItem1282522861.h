#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_ChessType2280511448.h"
#include "AssemblyU2DCSharp_LineType701338582.h"

// UnityEngine.UI.Image
struct Image_t2042527209;
// UnityEngine.Sprite
struct Sprite_t309593783;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SimulateItem
struct  SimulateItem_t1282522861  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 SimulateItem::index
	int32_t ___index_2;
	// System.Int32 SimulateItem::row
	int32_t ___row_3;
	// System.Int32 SimulateItem::col
	int32_t ___col_4;
	// ChessType SimulateItem::curType
	int32_t ___curType_5;
	// UnityEngine.UI.Image SimulateItem::background
	Image_t2042527209 * ___background_6;
	// System.Boolean SimulateItem::isSelected
	bool ___isSelected_7;
	// UnityEngine.UI.Image SimulateItem::selectFlag
	Image_t2042527209 * ___selectFlag_8;
	// UnityEngine.UI.Image SimulateItem::unSelectFlag
	Image_t2042527209 * ___unSelectFlag_9;
	// UnityEngine.UI.Image SimulateItem::leftLine
	Image_t2042527209 * ___leftLine_10;
	// UnityEngine.UI.Image SimulateItem::rightLine
	Image_t2042527209 * ___rightLine_11;
	// UnityEngine.UI.Image SimulateItem::upLine
	Image_t2042527209 * ___upLine_12;
	// UnityEngine.UI.Image SimulateItem::downLine
	Image_t2042527209 * ___downLine_13;
	// LineType SimulateItem::curLineType
	int32_t ___curLineType_14;
	// UnityEngine.Sprite SimulateItem::normalSprite
	Sprite_t309593783 * ___normalSprite_15;
	// UnityEngine.Sprite SimulateItem::highLightSprite
	Sprite_t309593783 * ___highLightSprite_16;

public:
	inline static int32_t get_offset_of_index_2() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___index_2)); }
	inline int32_t get_index_2() const { return ___index_2; }
	inline int32_t* get_address_of_index_2() { return &___index_2; }
	inline void set_index_2(int32_t value)
	{
		___index_2 = value;
	}

	inline static int32_t get_offset_of_row_3() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___row_3)); }
	inline int32_t get_row_3() const { return ___row_3; }
	inline int32_t* get_address_of_row_3() { return &___row_3; }
	inline void set_row_3(int32_t value)
	{
		___row_3 = value;
	}

	inline static int32_t get_offset_of_col_4() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___col_4)); }
	inline int32_t get_col_4() const { return ___col_4; }
	inline int32_t* get_address_of_col_4() { return &___col_4; }
	inline void set_col_4(int32_t value)
	{
		___col_4 = value;
	}

	inline static int32_t get_offset_of_curType_5() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___curType_5)); }
	inline int32_t get_curType_5() const { return ___curType_5; }
	inline int32_t* get_address_of_curType_5() { return &___curType_5; }
	inline void set_curType_5(int32_t value)
	{
		___curType_5 = value;
	}

	inline static int32_t get_offset_of_background_6() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___background_6)); }
	inline Image_t2042527209 * get_background_6() const { return ___background_6; }
	inline Image_t2042527209 ** get_address_of_background_6() { return &___background_6; }
	inline void set_background_6(Image_t2042527209 * value)
	{
		___background_6 = value;
		Il2CppCodeGenWriteBarrier(&___background_6, value);
	}

	inline static int32_t get_offset_of_isSelected_7() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___isSelected_7)); }
	inline bool get_isSelected_7() const { return ___isSelected_7; }
	inline bool* get_address_of_isSelected_7() { return &___isSelected_7; }
	inline void set_isSelected_7(bool value)
	{
		___isSelected_7 = value;
	}

	inline static int32_t get_offset_of_selectFlag_8() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___selectFlag_8)); }
	inline Image_t2042527209 * get_selectFlag_8() const { return ___selectFlag_8; }
	inline Image_t2042527209 ** get_address_of_selectFlag_8() { return &___selectFlag_8; }
	inline void set_selectFlag_8(Image_t2042527209 * value)
	{
		___selectFlag_8 = value;
		Il2CppCodeGenWriteBarrier(&___selectFlag_8, value);
	}

	inline static int32_t get_offset_of_unSelectFlag_9() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___unSelectFlag_9)); }
	inline Image_t2042527209 * get_unSelectFlag_9() const { return ___unSelectFlag_9; }
	inline Image_t2042527209 ** get_address_of_unSelectFlag_9() { return &___unSelectFlag_9; }
	inline void set_unSelectFlag_9(Image_t2042527209 * value)
	{
		___unSelectFlag_9 = value;
		Il2CppCodeGenWriteBarrier(&___unSelectFlag_9, value);
	}

	inline static int32_t get_offset_of_leftLine_10() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___leftLine_10)); }
	inline Image_t2042527209 * get_leftLine_10() const { return ___leftLine_10; }
	inline Image_t2042527209 ** get_address_of_leftLine_10() { return &___leftLine_10; }
	inline void set_leftLine_10(Image_t2042527209 * value)
	{
		___leftLine_10 = value;
		Il2CppCodeGenWriteBarrier(&___leftLine_10, value);
	}

	inline static int32_t get_offset_of_rightLine_11() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___rightLine_11)); }
	inline Image_t2042527209 * get_rightLine_11() const { return ___rightLine_11; }
	inline Image_t2042527209 ** get_address_of_rightLine_11() { return &___rightLine_11; }
	inline void set_rightLine_11(Image_t2042527209 * value)
	{
		___rightLine_11 = value;
		Il2CppCodeGenWriteBarrier(&___rightLine_11, value);
	}

	inline static int32_t get_offset_of_upLine_12() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___upLine_12)); }
	inline Image_t2042527209 * get_upLine_12() const { return ___upLine_12; }
	inline Image_t2042527209 ** get_address_of_upLine_12() { return &___upLine_12; }
	inline void set_upLine_12(Image_t2042527209 * value)
	{
		___upLine_12 = value;
		Il2CppCodeGenWriteBarrier(&___upLine_12, value);
	}

	inline static int32_t get_offset_of_downLine_13() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___downLine_13)); }
	inline Image_t2042527209 * get_downLine_13() const { return ___downLine_13; }
	inline Image_t2042527209 ** get_address_of_downLine_13() { return &___downLine_13; }
	inline void set_downLine_13(Image_t2042527209 * value)
	{
		___downLine_13 = value;
		Il2CppCodeGenWriteBarrier(&___downLine_13, value);
	}

	inline static int32_t get_offset_of_curLineType_14() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___curLineType_14)); }
	inline int32_t get_curLineType_14() const { return ___curLineType_14; }
	inline int32_t* get_address_of_curLineType_14() { return &___curLineType_14; }
	inline void set_curLineType_14(int32_t value)
	{
		___curLineType_14 = value;
	}

	inline static int32_t get_offset_of_normalSprite_15() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___normalSprite_15)); }
	inline Sprite_t309593783 * get_normalSprite_15() const { return ___normalSprite_15; }
	inline Sprite_t309593783 ** get_address_of_normalSprite_15() { return &___normalSprite_15; }
	inline void set_normalSprite_15(Sprite_t309593783 * value)
	{
		___normalSprite_15 = value;
		Il2CppCodeGenWriteBarrier(&___normalSprite_15, value);
	}

	inline static int32_t get_offset_of_highLightSprite_16() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861, ___highLightSprite_16)); }
	inline Sprite_t309593783 * get_highLightSprite_16() const { return ___highLightSprite_16; }
	inline Sprite_t309593783 ** get_address_of_highLightSprite_16() { return &___highLightSprite_16; }
	inline void set_highLightSprite_16(Sprite_t309593783 * value)
	{
		___highLightSprite_16 = value;
		Il2CppCodeGenWriteBarrier(&___highLightSprite_16, value);
	}
};

struct SimulateItem_t1282522861_StaticFields
{
public:
	// System.Int32 SimulateItem::simulateWidth
	int32_t ___simulateWidth_17;

public:
	inline static int32_t get_offset_of_simulateWidth_17() { return static_cast<int32_t>(offsetof(SimulateItem_t1282522861_StaticFields, ___simulateWidth_17)); }
	inline int32_t get_simulateWidth_17() const { return ___simulateWidth_17; }
	inline int32_t* get_address_of_simulateWidth_17() { return &___simulateWidth_17; }
	inline void set_simulateWidth_17(int32_t value)
	{
		___simulateWidth_17 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
