#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_PoolObject202793199.h"
#include "AssemblyU2DCSharp_LineType701338582.h"
#include "AssemblyU2DCSharp_ChessType2280511448.h"

// UnityEngine.SpriteRenderer
struct SpriteRenderer_t1209076198;
// UnityEngine.Sprite[]
struct SpriteU5BU5D_t3359083662;
// UnityEngine.SpriteRenderer[]
struct SpriteRendererU5BU5D_t1098056643;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ChessItem
struct  ChessItem_t4142475053  : public PoolObject_t202793199
{
public:
	// UnityEngine.SpriteRenderer ChessItem::SR
	SpriteRenderer_t1209076198 * ___SR_3;
	// UnityEngine.Sprite[] ChessItem::spriteArr
	SpriteU5BU5D_t3359083662* ___spriteArr_4;
	// System.Int32 ChessItem::index
	int32_t ___index_5;
	// UnityEngine.SpriteRenderer ChessItem::selectFlag
	SpriteRenderer_t1209076198 * ___selectFlag_6;
	// UnityEngine.SpriteRenderer ChessItem::unSelectFlag
	SpriteRenderer_t1209076198 * ___unSelectFlag_7;
	// UnityEngine.SpriteRenderer[] ChessItem::lineArr
	SpriteRendererU5BU5D_t1098056643* ___lineArr_8;
	// LineType ChessItem::curLineType
	int32_t ___curLineType_9;
	// ChessType ChessItem::curType
	int32_t ___curType_10;
	// UnityEngine.SpriteRenderer ChessItem::leftLine
	SpriteRenderer_t1209076198 * ___leftLine_11;
	// UnityEngine.SpriteRenderer ChessItem::rightLine
	SpriteRenderer_t1209076198 * ___rightLine_12;
	// UnityEngine.SpriteRenderer ChessItem::upLine
	SpriteRenderer_t1209076198 * ___upLine_13;
	// UnityEngine.SpriteRenderer ChessItem::downLine
	SpriteRenderer_t1209076198 * ___downLine_14;
	// System.Int32 ChessItem::row
	int32_t ___row_15;
	// System.Int32 ChessItem::col
	int32_t ___col_16;
	// System.Boolean ChessItem::isSelected
	bool ___isSelected_17;

public:
	inline static int32_t get_offset_of_SR_3() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___SR_3)); }
	inline SpriteRenderer_t1209076198 * get_SR_3() const { return ___SR_3; }
	inline SpriteRenderer_t1209076198 ** get_address_of_SR_3() { return &___SR_3; }
	inline void set_SR_3(SpriteRenderer_t1209076198 * value)
	{
		___SR_3 = value;
		Il2CppCodeGenWriteBarrier(&___SR_3, value);
	}

	inline static int32_t get_offset_of_spriteArr_4() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___spriteArr_4)); }
	inline SpriteU5BU5D_t3359083662* get_spriteArr_4() const { return ___spriteArr_4; }
	inline SpriteU5BU5D_t3359083662** get_address_of_spriteArr_4() { return &___spriteArr_4; }
	inline void set_spriteArr_4(SpriteU5BU5D_t3359083662* value)
	{
		___spriteArr_4 = value;
		Il2CppCodeGenWriteBarrier(&___spriteArr_4, value);
	}

	inline static int32_t get_offset_of_index_5() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___index_5)); }
	inline int32_t get_index_5() const { return ___index_5; }
	inline int32_t* get_address_of_index_5() { return &___index_5; }
	inline void set_index_5(int32_t value)
	{
		___index_5 = value;
	}

	inline static int32_t get_offset_of_selectFlag_6() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___selectFlag_6)); }
	inline SpriteRenderer_t1209076198 * get_selectFlag_6() const { return ___selectFlag_6; }
	inline SpriteRenderer_t1209076198 ** get_address_of_selectFlag_6() { return &___selectFlag_6; }
	inline void set_selectFlag_6(SpriteRenderer_t1209076198 * value)
	{
		___selectFlag_6 = value;
		Il2CppCodeGenWriteBarrier(&___selectFlag_6, value);
	}

	inline static int32_t get_offset_of_unSelectFlag_7() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___unSelectFlag_7)); }
	inline SpriteRenderer_t1209076198 * get_unSelectFlag_7() const { return ___unSelectFlag_7; }
	inline SpriteRenderer_t1209076198 ** get_address_of_unSelectFlag_7() { return &___unSelectFlag_7; }
	inline void set_unSelectFlag_7(SpriteRenderer_t1209076198 * value)
	{
		___unSelectFlag_7 = value;
		Il2CppCodeGenWriteBarrier(&___unSelectFlag_7, value);
	}

	inline static int32_t get_offset_of_lineArr_8() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___lineArr_8)); }
	inline SpriteRendererU5BU5D_t1098056643* get_lineArr_8() const { return ___lineArr_8; }
	inline SpriteRendererU5BU5D_t1098056643** get_address_of_lineArr_8() { return &___lineArr_8; }
	inline void set_lineArr_8(SpriteRendererU5BU5D_t1098056643* value)
	{
		___lineArr_8 = value;
		Il2CppCodeGenWriteBarrier(&___lineArr_8, value);
	}

	inline static int32_t get_offset_of_curLineType_9() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___curLineType_9)); }
	inline int32_t get_curLineType_9() const { return ___curLineType_9; }
	inline int32_t* get_address_of_curLineType_9() { return &___curLineType_9; }
	inline void set_curLineType_9(int32_t value)
	{
		___curLineType_9 = value;
	}

	inline static int32_t get_offset_of_curType_10() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___curType_10)); }
	inline int32_t get_curType_10() const { return ___curType_10; }
	inline int32_t* get_address_of_curType_10() { return &___curType_10; }
	inline void set_curType_10(int32_t value)
	{
		___curType_10 = value;
	}

	inline static int32_t get_offset_of_leftLine_11() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___leftLine_11)); }
	inline SpriteRenderer_t1209076198 * get_leftLine_11() const { return ___leftLine_11; }
	inline SpriteRenderer_t1209076198 ** get_address_of_leftLine_11() { return &___leftLine_11; }
	inline void set_leftLine_11(SpriteRenderer_t1209076198 * value)
	{
		___leftLine_11 = value;
		Il2CppCodeGenWriteBarrier(&___leftLine_11, value);
	}

	inline static int32_t get_offset_of_rightLine_12() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___rightLine_12)); }
	inline SpriteRenderer_t1209076198 * get_rightLine_12() const { return ___rightLine_12; }
	inline SpriteRenderer_t1209076198 ** get_address_of_rightLine_12() { return &___rightLine_12; }
	inline void set_rightLine_12(SpriteRenderer_t1209076198 * value)
	{
		___rightLine_12 = value;
		Il2CppCodeGenWriteBarrier(&___rightLine_12, value);
	}

	inline static int32_t get_offset_of_upLine_13() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___upLine_13)); }
	inline SpriteRenderer_t1209076198 * get_upLine_13() const { return ___upLine_13; }
	inline SpriteRenderer_t1209076198 ** get_address_of_upLine_13() { return &___upLine_13; }
	inline void set_upLine_13(SpriteRenderer_t1209076198 * value)
	{
		___upLine_13 = value;
		Il2CppCodeGenWriteBarrier(&___upLine_13, value);
	}

	inline static int32_t get_offset_of_downLine_14() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___downLine_14)); }
	inline SpriteRenderer_t1209076198 * get_downLine_14() const { return ___downLine_14; }
	inline SpriteRenderer_t1209076198 ** get_address_of_downLine_14() { return &___downLine_14; }
	inline void set_downLine_14(SpriteRenderer_t1209076198 * value)
	{
		___downLine_14 = value;
		Il2CppCodeGenWriteBarrier(&___downLine_14, value);
	}

	inline static int32_t get_offset_of_row_15() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___row_15)); }
	inline int32_t get_row_15() const { return ___row_15; }
	inline int32_t* get_address_of_row_15() { return &___row_15; }
	inline void set_row_15(int32_t value)
	{
		___row_15 = value;
	}

	inline static int32_t get_offset_of_col_16() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___col_16)); }
	inline int32_t get_col_16() const { return ___col_16; }
	inline int32_t* get_address_of_col_16() { return &___col_16; }
	inline void set_col_16(int32_t value)
	{
		___col_16 = value;
	}

	inline static int32_t get_offset_of_isSelected_17() { return static_cast<int32_t>(offsetof(ChessItem_t4142475053, ___isSelected_17)); }
	inline bool get_isSelected_17() const { return ___isSelected_17; }
	inline bool* get_address_of_isSelected_17() { return &___isSelected_17; }
	inline void set_isSelected_17(bool value)
	{
		___isSelected_17 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
