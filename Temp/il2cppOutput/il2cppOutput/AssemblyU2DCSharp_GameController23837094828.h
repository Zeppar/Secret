#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_GameDiff820059325.h"
#include "AssemblyU2DCSharp_LineMode1050662183.h"
#include "AssemblyU2DCSharp_ShowMode2220702474.h"
#include "AssemblyU2DCSharp_LinkMode1421222297.h"

// GameController2
struct GameController2_t3837094828;
// System.Collections.Generic.List`1<ChessItem>
struct List_1_t3511596185;
// System.Collections.Generic.List`1<SimulateItem>
struct List_1_t651643993;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t1440998580;
// System.Collections.Generic.List`1<AnswerPanel>
struct List_1_t2804800104;
// background
struct background_t3863973384;
// System.Collections.Generic.List`1<System.Collections.Generic.List`1<System.Int32>>
struct List_1_t810119712;
// UnityEngine.Transform
struct Transform_t3275118058;
// ChessItem
struct ChessItem_t4142475053;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameController2
struct  GameController2_t3837094828  : public MonoBehaviour_t1158329972
{
public:
	// GameDiff GameController2::curDiff
	int32_t ___curDiff_3;
	// LineMode GameController2::curLineMode
	int32_t ___curLineMode_4;
	// ShowMode GameController2::curShowMode
	int32_t ___curShowMode_5;
	// LinkMode GameController2::curLinkMode
	int32_t ___curLinkMode_6;
	// System.Collections.Generic.List`1<ChessItem> GameController2::chessList
	List_1_t3511596185 * ___chessList_7;
	// System.Collections.Generic.List`1<ChessItem> GameController2::selectedList
	List_1_t3511596185 * ___selectedList_8;
	// System.Collections.Generic.List`1<SimulateItem> GameController2::simulateList
	List_1_t651643993 * ___simulateList_9;
	// System.Collections.Generic.List`1<SimulateItem> GameController2::tempSimulateSelectedList
	List_1_t651643993 * ___tempSimulateSelectedList_10;
	// System.Collections.Generic.List`1<SimulateItem> GameController2::simulateSelectedList
	List_1_t651643993 * ___simulateSelectedList_11;
	// System.Collections.Generic.List`1<System.Int32> GameController2::ctmAnswerList
	List_1_t1440998580 * ___ctmAnswerList_12;
	// System.Collections.Generic.List`1<AnswerPanel> GameController2::answerPanelList
	List_1_t2804800104 * ___answerPanelList_13;
	// System.Int32 GameController2::LinkCount
	int32_t ___LinkCount_14;
	// System.Int32 GameController2::SimulateLinkCount
	int32_t ___SimulateLinkCount_15;
	// System.Int32 GameController2::maxLinkCount
	int32_t ___maxLinkCount_16;
	// System.Int32 GameController2::SimCount
	int32_t ___SimCount_17;
	// System.Boolean GameController2::hasStartLink
	bool ___hasStartLink_18;
	// System.Boolean GameController2::hasStartGame
	bool ___hasStartGame_19;
	// System.Boolean GameController2::hasStartSimulate
	bool ___hasStartSimulate_20;
	// System.Boolean GameController2::hasConfirmSimulate
	bool ___hasConfirmSimulate_21;
	// background GameController2::bg
	background_t3863973384 * ___bg_22;
	// System.Boolean GameController2::JLinkMode
	bool ___JLinkMode_23;
	// System.Boolean GameController2::LLinkMode
	bool ___LLinkMode_24;
	// System.Boolean GameController2::CtmLinkMode
	bool ___CtmLinkMode_25;
	// System.Collections.Generic.List`1<System.Collections.Generic.List`1<System.Int32>> GameController2::answerList
	List_1_t810119712 * ___answerList_26;
	// System.Collections.Generic.List`1<System.Int32> GameController2::LList
	List_1_t1440998580 * ___LList_27;
	// System.Collections.Generic.List`1<System.Int32> GameController2::JList
	List_1_t1440998580 * ___JList_28;
	// System.Boolean GameController2::LListConfigured
	bool ___LListConfigured_29;
	// System.Boolean GameController2::JListConfigured
	bool ___JListConfigured_30;
	// System.Int32 GameController2::maxX
	int32_t ___maxX_31;
	// System.Int32 GameController2::maxY
	int32_t ___maxY_32;
	// System.Int32 GameController2::simulateMaxX
	int32_t ___simulateMaxX_33;
	// System.Int32 GameController2::simulateMaxY
	int32_t ___simulateMaxY_34;
	// System.Int32 GameController2::maxRow
	int32_t ___maxRow_35;
	// System.Int32 GameController2::maxCol
	int32_t ___maxCol_36;
	// System.Single GameController2::itemWidth
	float ___itemWidth_37;
	// System.Single GameController2::itemHeight
	float ___itemHeight_38;
	// System.Single GameController2::offset
	float ___offset_39;
	// UnityEngine.Transform GameController2::content
	Transform_t3275118058 * ___content_40;
	// ChessItem GameController2::chessItemPrefab
	ChessItem_t4142475053 * ___chessItemPrefab_41;

public:
	inline static int32_t get_offset_of_curDiff_3() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___curDiff_3)); }
	inline int32_t get_curDiff_3() const { return ___curDiff_3; }
	inline int32_t* get_address_of_curDiff_3() { return &___curDiff_3; }
	inline void set_curDiff_3(int32_t value)
	{
		___curDiff_3 = value;
	}

	inline static int32_t get_offset_of_curLineMode_4() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___curLineMode_4)); }
	inline int32_t get_curLineMode_4() const { return ___curLineMode_4; }
	inline int32_t* get_address_of_curLineMode_4() { return &___curLineMode_4; }
	inline void set_curLineMode_4(int32_t value)
	{
		___curLineMode_4 = value;
	}

	inline static int32_t get_offset_of_curShowMode_5() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___curShowMode_5)); }
	inline int32_t get_curShowMode_5() const { return ___curShowMode_5; }
	inline int32_t* get_address_of_curShowMode_5() { return &___curShowMode_5; }
	inline void set_curShowMode_5(int32_t value)
	{
		___curShowMode_5 = value;
	}

	inline static int32_t get_offset_of_curLinkMode_6() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___curLinkMode_6)); }
	inline int32_t get_curLinkMode_6() const { return ___curLinkMode_6; }
	inline int32_t* get_address_of_curLinkMode_6() { return &___curLinkMode_6; }
	inline void set_curLinkMode_6(int32_t value)
	{
		___curLinkMode_6 = value;
	}

	inline static int32_t get_offset_of_chessList_7() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___chessList_7)); }
	inline List_1_t3511596185 * get_chessList_7() const { return ___chessList_7; }
	inline List_1_t3511596185 ** get_address_of_chessList_7() { return &___chessList_7; }
	inline void set_chessList_7(List_1_t3511596185 * value)
	{
		___chessList_7 = value;
		Il2CppCodeGenWriteBarrier(&___chessList_7, value);
	}

	inline static int32_t get_offset_of_selectedList_8() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___selectedList_8)); }
	inline List_1_t3511596185 * get_selectedList_8() const { return ___selectedList_8; }
	inline List_1_t3511596185 ** get_address_of_selectedList_8() { return &___selectedList_8; }
	inline void set_selectedList_8(List_1_t3511596185 * value)
	{
		___selectedList_8 = value;
		Il2CppCodeGenWriteBarrier(&___selectedList_8, value);
	}

	inline static int32_t get_offset_of_simulateList_9() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___simulateList_9)); }
	inline List_1_t651643993 * get_simulateList_9() const { return ___simulateList_9; }
	inline List_1_t651643993 ** get_address_of_simulateList_9() { return &___simulateList_9; }
	inline void set_simulateList_9(List_1_t651643993 * value)
	{
		___simulateList_9 = value;
		Il2CppCodeGenWriteBarrier(&___simulateList_9, value);
	}

	inline static int32_t get_offset_of_tempSimulateSelectedList_10() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___tempSimulateSelectedList_10)); }
	inline List_1_t651643993 * get_tempSimulateSelectedList_10() const { return ___tempSimulateSelectedList_10; }
	inline List_1_t651643993 ** get_address_of_tempSimulateSelectedList_10() { return &___tempSimulateSelectedList_10; }
	inline void set_tempSimulateSelectedList_10(List_1_t651643993 * value)
	{
		___tempSimulateSelectedList_10 = value;
		Il2CppCodeGenWriteBarrier(&___tempSimulateSelectedList_10, value);
	}

	inline static int32_t get_offset_of_simulateSelectedList_11() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___simulateSelectedList_11)); }
	inline List_1_t651643993 * get_simulateSelectedList_11() const { return ___simulateSelectedList_11; }
	inline List_1_t651643993 ** get_address_of_simulateSelectedList_11() { return &___simulateSelectedList_11; }
	inline void set_simulateSelectedList_11(List_1_t651643993 * value)
	{
		___simulateSelectedList_11 = value;
		Il2CppCodeGenWriteBarrier(&___simulateSelectedList_11, value);
	}

	inline static int32_t get_offset_of_ctmAnswerList_12() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___ctmAnswerList_12)); }
	inline List_1_t1440998580 * get_ctmAnswerList_12() const { return ___ctmAnswerList_12; }
	inline List_1_t1440998580 ** get_address_of_ctmAnswerList_12() { return &___ctmAnswerList_12; }
	inline void set_ctmAnswerList_12(List_1_t1440998580 * value)
	{
		___ctmAnswerList_12 = value;
		Il2CppCodeGenWriteBarrier(&___ctmAnswerList_12, value);
	}

	inline static int32_t get_offset_of_answerPanelList_13() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___answerPanelList_13)); }
	inline List_1_t2804800104 * get_answerPanelList_13() const { return ___answerPanelList_13; }
	inline List_1_t2804800104 ** get_address_of_answerPanelList_13() { return &___answerPanelList_13; }
	inline void set_answerPanelList_13(List_1_t2804800104 * value)
	{
		___answerPanelList_13 = value;
		Il2CppCodeGenWriteBarrier(&___answerPanelList_13, value);
	}

	inline static int32_t get_offset_of_LinkCount_14() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___LinkCount_14)); }
	inline int32_t get_LinkCount_14() const { return ___LinkCount_14; }
	inline int32_t* get_address_of_LinkCount_14() { return &___LinkCount_14; }
	inline void set_LinkCount_14(int32_t value)
	{
		___LinkCount_14 = value;
	}

	inline static int32_t get_offset_of_SimulateLinkCount_15() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___SimulateLinkCount_15)); }
	inline int32_t get_SimulateLinkCount_15() const { return ___SimulateLinkCount_15; }
	inline int32_t* get_address_of_SimulateLinkCount_15() { return &___SimulateLinkCount_15; }
	inline void set_SimulateLinkCount_15(int32_t value)
	{
		___SimulateLinkCount_15 = value;
	}

	inline static int32_t get_offset_of_maxLinkCount_16() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___maxLinkCount_16)); }
	inline int32_t get_maxLinkCount_16() const { return ___maxLinkCount_16; }
	inline int32_t* get_address_of_maxLinkCount_16() { return &___maxLinkCount_16; }
	inline void set_maxLinkCount_16(int32_t value)
	{
		___maxLinkCount_16 = value;
	}

	inline static int32_t get_offset_of_SimCount_17() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___SimCount_17)); }
	inline int32_t get_SimCount_17() const { return ___SimCount_17; }
	inline int32_t* get_address_of_SimCount_17() { return &___SimCount_17; }
	inline void set_SimCount_17(int32_t value)
	{
		___SimCount_17 = value;
	}

	inline static int32_t get_offset_of_hasStartLink_18() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___hasStartLink_18)); }
	inline bool get_hasStartLink_18() const { return ___hasStartLink_18; }
	inline bool* get_address_of_hasStartLink_18() { return &___hasStartLink_18; }
	inline void set_hasStartLink_18(bool value)
	{
		___hasStartLink_18 = value;
	}

	inline static int32_t get_offset_of_hasStartGame_19() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___hasStartGame_19)); }
	inline bool get_hasStartGame_19() const { return ___hasStartGame_19; }
	inline bool* get_address_of_hasStartGame_19() { return &___hasStartGame_19; }
	inline void set_hasStartGame_19(bool value)
	{
		___hasStartGame_19 = value;
	}

	inline static int32_t get_offset_of_hasStartSimulate_20() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___hasStartSimulate_20)); }
	inline bool get_hasStartSimulate_20() const { return ___hasStartSimulate_20; }
	inline bool* get_address_of_hasStartSimulate_20() { return &___hasStartSimulate_20; }
	inline void set_hasStartSimulate_20(bool value)
	{
		___hasStartSimulate_20 = value;
	}

	inline static int32_t get_offset_of_hasConfirmSimulate_21() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___hasConfirmSimulate_21)); }
	inline bool get_hasConfirmSimulate_21() const { return ___hasConfirmSimulate_21; }
	inline bool* get_address_of_hasConfirmSimulate_21() { return &___hasConfirmSimulate_21; }
	inline void set_hasConfirmSimulate_21(bool value)
	{
		___hasConfirmSimulate_21 = value;
	}

	inline static int32_t get_offset_of_bg_22() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___bg_22)); }
	inline background_t3863973384 * get_bg_22() const { return ___bg_22; }
	inline background_t3863973384 ** get_address_of_bg_22() { return &___bg_22; }
	inline void set_bg_22(background_t3863973384 * value)
	{
		___bg_22 = value;
		Il2CppCodeGenWriteBarrier(&___bg_22, value);
	}

	inline static int32_t get_offset_of_JLinkMode_23() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___JLinkMode_23)); }
	inline bool get_JLinkMode_23() const { return ___JLinkMode_23; }
	inline bool* get_address_of_JLinkMode_23() { return &___JLinkMode_23; }
	inline void set_JLinkMode_23(bool value)
	{
		___JLinkMode_23 = value;
	}

	inline static int32_t get_offset_of_LLinkMode_24() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___LLinkMode_24)); }
	inline bool get_LLinkMode_24() const { return ___LLinkMode_24; }
	inline bool* get_address_of_LLinkMode_24() { return &___LLinkMode_24; }
	inline void set_LLinkMode_24(bool value)
	{
		___LLinkMode_24 = value;
	}

	inline static int32_t get_offset_of_CtmLinkMode_25() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___CtmLinkMode_25)); }
	inline bool get_CtmLinkMode_25() const { return ___CtmLinkMode_25; }
	inline bool* get_address_of_CtmLinkMode_25() { return &___CtmLinkMode_25; }
	inline void set_CtmLinkMode_25(bool value)
	{
		___CtmLinkMode_25 = value;
	}

	inline static int32_t get_offset_of_answerList_26() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___answerList_26)); }
	inline List_1_t810119712 * get_answerList_26() const { return ___answerList_26; }
	inline List_1_t810119712 ** get_address_of_answerList_26() { return &___answerList_26; }
	inline void set_answerList_26(List_1_t810119712 * value)
	{
		___answerList_26 = value;
		Il2CppCodeGenWriteBarrier(&___answerList_26, value);
	}

	inline static int32_t get_offset_of_LList_27() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___LList_27)); }
	inline List_1_t1440998580 * get_LList_27() const { return ___LList_27; }
	inline List_1_t1440998580 ** get_address_of_LList_27() { return &___LList_27; }
	inline void set_LList_27(List_1_t1440998580 * value)
	{
		___LList_27 = value;
		Il2CppCodeGenWriteBarrier(&___LList_27, value);
	}

	inline static int32_t get_offset_of_JList_28() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___JList_28)); }
	inline List_1_t1440998580 * get_JList_28() const { return ___JList_28; }
	inline List_1_t1440998580 ** get_address_of_JList_28() { return &___JList_28; }
	inline void set_JList_28(List_1_t1440998580 * value)
	{
		___JList_28 = value;
		Il2CppCodeGenWriteBarrier(&___JList_28, value);
	}

	inline static int32_t get_offset_of_LListConfigured_29() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___LListConfigured_29)); }
	inline bool get_LListConfigured_29() const { return ___LListConfigured_29; }
	inline bool* get_address_of_LListConfigured_29() { return &___LListConfigured_29; }
	inline void set_LListConfigured_29(bool value)
	{
		___LListConfigured_29 = value;
	}

	inline static int32_t get_offset_of_JListConfigured_30() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___JListConfigured_30)); }
	inline bool get_JListConfigured_30() const { return ___JListConfigured_30; }
	inline bool* get_address_of_JListConfigured_30() { return &___JListConfigured_30; }
	inline void set_JListConfigured_30(bool value)
	{
		___JListConfigured_30 = value;
	}

	inline static int32_t get_offset_of_maxX_31() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___maxX_31)); }
	inline int32_t get_maxX_31() const { return ___maxX_31; }
	inline int32_t* get_address_of_maxX_31() { return &___maxX_31; }
	inline void set_maxX_31(int32_t value)
	{
		___maxX_31 = value;
	}

	inline static int32_t get_offset_of_maxY_32() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___maxY_32)); }
	inline int32_t get_maxY_32() const { return ___maxY_32; }
	inline int32_t* get_address_of_maxY_32() { return &___maxY_32; }
	inline void set_maxY_32(int32_t value)
	{
		___maxY_32 = value;
	}

	inline static int32_t get_offset_of_simulateMaxX_33() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___simulateMaxX_33)); }
	inline int32_t get_simulateMaxX_33() const { return ___simulateMaxX_33; }
	inline int32_t* get_address_of_simulateMaxX_33() { return &___simulateMaxX_33; }
	inline void set_simulateMaxX_33(int32_t value)
	{
		___simulateMaxX_33 = value;
	}

	inline static int32_t get_offset_of_simulateMaxY_34() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___simulateMaxY_34)); }
	inline int32_t get_simulateMaxY_34() const { return ___simulateMaxY_34; }
	inline int32_t* get_address_of_simulateMaxY_34() { return &___simulateMaxY_34; }
	inline void set_simulateMaxY_34(int32_t value)
	{
		___simulateMaxY_34 = value;
	}

	inline static int32_t get_offset_of_maxRow_35() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___maxRow_35)); }
	inline int32_t get_maxRow_35() const { return ___maxRow_35; }
	inline int32_t* get_address_of_maxRow_35() { return &___maxRow_35; }
	inline void set_maxRow_35(int32_t value)
	{
		___maxRow_35 = value;
	}

	inline static int32_t get_offset_of_maxCol_36() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___maxCol_36)); }
	inline int32_t get_maxCol_36() const { return ___maxCol_36; }
	inline int32_t* get_address_of_maxCol_36() { return &___maxCol_36; }
	inline void set_maxCol_36(int32_t value)
	{
		___maxCol_36 = value;
	}

	inline static int32_t get_offset_of_itemWidth_37() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___itemWidth_37)); }
	inline float get_itemWidth_37() const { return ___itemWidth_37; }
	inline float* get_address_of_itemWidth_37() { return &___itemWidth_37; }
	inline void set_itemWidth_37(float value)
	{
		___itemWidth_37 = value;
	}

	inline static int32_t get_offset_of_itemHeight_38() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___itemHeight_38)); }
	inline float get_itemHeight_38() const { return ___itemHeight_38; }
	inline float* get_address_of_itemHeight_38() { return &___itemHeight_38; }
	inline void set_itemHeight_38(float value)
	{
		___itemHeight_38 = value;
	}

	inline static int32_t get_offset_of_offset_39() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___offset_39)); }
	inline float get_offset_39() const { return ___offset_39; }
	inline float* get_address_of_offset_39() { return &___offset_39; }
	inline void set_offset_39(float value)
	{
		___offset_39 = value;
	}

	inline static int32_t get_offset_of_content_40() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___content_40)); }
	inline Transform_t3275118058 * get_content_40() const { return ___content_40; }
	inline Transform_t3275118058 ** get_address_of_content_40() { return &___content_40; }
	inline void set_content_40(Transform_t3275118058 * value)
	{
		___content_40 = value;
		Il2CppCodeGenWriteBarrier(&___content_40, value);
	}

	inline static int32_t get_offset_of_chessItemPrefab_41() { return static_cast<int32_t>(offsetof(GameController2_t3837094828, ___chessItemPrefab_41)); }
	inline ChessItem_t4142475053 * get_chessItemPrefab_41() const { return ___chessItemPrefab_41; }
	inline ChessItem_t4142475053 ** get_address_of_chessItemPrefab_41() { return &___chessItemPrefab_41; }
	inline void set_chessItemPrefab_41(ChessItem_t4142475053 * value)
	{
		___chessItemPrefab_41 = value;
		Il2CppCodeGenWriteBarrier(&___chessItemPrefab_41, value);
	}
};

struct GameController2_t3837094828_StaticFields
{
public:
	// GameController2 GameController2::manager
	GameController2_t3837094828 * ___manager_2;

public:
	inline static int32_t get_offset_of_manager_2() { return static_cast<int32_t>(offsetof(GameController2_t3837094828_StaticFields, ___manager_2)); }
	inline GameController2_t3837094828 * get_manager_2() const { return ___manager_2; }
	inline GameController2_t3837094828 ** get_address_of_manager_2() { return &___manager_2; }
	inline void set_manager_2(GameController2_t3837094828 * value)
	{
		___manager_2 = value;
		Il2CppCodeGenWriteBarrier(&___manager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
