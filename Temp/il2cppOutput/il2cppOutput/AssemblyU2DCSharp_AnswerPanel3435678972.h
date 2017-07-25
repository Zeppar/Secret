#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.Collections.Generic.List`1<System.Int32>
struct List_1_t1440998580;
// System.Collections.Generic.List`1<AnswerItem>
struct List_1_t2343346183;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AnswerPanel
struct  AnswerPanel_t3435678972  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 AnswerPanel::panelIndex
	int32_t ___panelIndex_2;
	// System.Collections.Generic.List`1<System.Int32> AnswerPanel::answerList
	List_1_t1440998580 * ___answerList_3;
	// System.Collections.Generic.List`1<AnswerItem> AnswerPanel::answerItemList
	List_1_t2343346183 * ___answerItemList_4;
	// System.Collections.Generic.List`1<AnswerItem> AnswerPanel::selectItemList
	List_1_t2343346183 * ___selectItemList_5;
	// System.Boolean AnswerPanel::hasConvert
	bool ___hasConvert_7;
	// System.Int32 AnswerPanel::idx
	int32_t ___idx_8;

public:
	inline static int32_t get_offset_of_panelIndex_2() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972, ___panelIndex_2)); }
	inline int32_t get_panelIndex_2() const { return ___panelIndex_2; }
	inline int32_t* get_address_of_panelIndex_2() { return &___panelIndex_2; }
	inline void set_panelIndex_2(int32_t value)
	{
		___panelIndex_2 = value;
	}

	inline static int32_t get_offset_of_answerList_3() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972, ___answerList_3)); }
	inline List_1_t1440998580 * get_answerList_3() const { return ___answerList_3; }
	inline List_1_t1440998580 ** get_address_of_answerList_3() { return &___answerList_3; }
	inline void set_answerList_3(List_1_t1440998580 * value)
	{
		___answerList_3 = value;
		Il2CppCodeGenWriteBarrier(&___answerList_3, value);
	}

	inline static int32_t get_offset_of_answerItemList_4() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972, ___answerItemList_4)); }
	inline List_1_t2343346183 * get_answerItemList_4() const { return ___answerItemList_4; }
	inline List_1_t2343346183 ** get_address_of_answerItemList_4() { return &___answerItemList_4; }
	inline void set_answerItemList_4(List_1_t2343346183 * value)
	{
		___answerItemList_4 = value;
		Il2CppCodeGenWriteBarrier(&___answerItemList_4, value);
	}

	inline static int32_t get_offset_of_selectItemList_5() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972, ___selectItemList_5)); }
	inline List_1_t2343346183 * get_selectItemList_5() const { return ___selectItemList_5; }
	inline List_1_t2343346183 ** get_address_of_selectItemList_5() { return &___selectItemList_5; }
	inline void set_selectItemList_5(List_1_t2343346183 * value)
	{
		___selectItemList_5 = value;
		Il2CppCodeGenWriteBarrier(&___selectItemList_5, value);
	}

	inline static int32_t get_offset_of_hasConvert_7() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972, ___hasConvert_7)); }
	inline bool get_hasConvert_7() const { return ___hasConvert_7; }
	inline bool* get_address_of_hasConvert_7() { return &___hasConvert_7; }
	inline void set_hasConvert_7(bool value)
	{
		___hasConvert_7 = value;
	}

	inline static int32_t get_offset_of_idx_8() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972, ___idx_8)); }
	inline int32_t get_idx_8() const { return ___idx_8; }
	inline int32_t* get_address_of_idx_8() { return &___idx_8; }
	inline void set_idx_8(int32_t value)
	{
		___idx_8 = value;
	}
};

struct AnswerPanel_t3435678972_StaticFields
{
public:
	// System.Int32 AnswerPanel::answerWidth
	int32_t ___answerWidth_6;

public:
	inline static int32_t get_offset_of_answerWidth_6() { return static_cast<int32_t>(offsetof(AnswerPanel_t3435678972_StaticFields, ___answerWidth_6)); }
	inline int32_t get_answerWidth_6() const { return ___answerWidth_6; }
	inline int32_t* get_address_of_answerWidth_6() { return &___answerWidth_6; }
	inline void set_answerWidth_6(int32_t value)
	{
		___answerWidth_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
