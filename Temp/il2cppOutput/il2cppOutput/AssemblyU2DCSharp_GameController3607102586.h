#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_ShowMode2220702474.h"
#include "AssemblyU2DCSharp_LinkMode1421222297.h"
#include "AssemblyU2DCSharp_GameDiff820059325.h"
#include "AssemblyU2DCSharp_LineMode1050662183.h"
#include "AssemblyU2DCSharp_GameMode1861898983.h"
#include "AssemblyU2DCSharp_ChallengeMode2066368710.h"

// GameController
struct GameController_t3607102586;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t1440998580;
// System.Collections.Generic.List`1<ChessItem>
struct List_1_t3511596185;
// System.Collections.Generic.List`1<AnswerPanel>
struct List_1_t2804800104;
// System.Collections.Generic.List`1<System.Collections.Generic.List`1<System.Int32>>
struct List_1_t810119712;
// System.Collections.Generic.List`1<SimulateItem>
struct List_1_t651643993;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameController
struct  GameController_t3607102586  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 GameController::maxCol
	int32_t ___maxCol_3;
	// System.Int32 GameController::maxRow
	int32_t ___maxRow_4;
	// System.Int32 GameController::star1Time
	int32_t ___star1Time_5;
	// System.Int32 GameController::star2Time
	int32_t ___star2Time_6;
	// System.Int32 GameController::star3Time
	int32_t ___star3Time_7;
	// System.Collections.Generic.List`1<System.Int32> GameController::chessValueList
	List_1_t1440998580 * ___chessValueList_8;
	// System.Collections.Generic.List`1<ChessItem> GameController::chessList
	List_1_t3511596185 * ___chessList_9;
	// System.Boolean GameController::hasStartGame
	bool ___hasStartGame_10;
	// System.Boolean GameController::hasStartLink
	bool ___hasStartLink_11;
	// System.Collections.Generic.List`1<ChessItem> GameController::selectedList
	List_1_t3511596185 * ___selectedList_12;
	// System.Int32 GameController::LinkCount
	int32_t ___LinkCount_13;
	// System.Int32 GameController::maxLinkCount
	int32_t ___maxLinkCount_14;
	// ShowMode GameController::curShowMode
	int32_t ___curShowMode_15;
	// LinkMode GameController::curLinkMode
	int32_t ___curLinkMode_16;
	// GameDiff GameController::curDiff
	int32_t ___curDiff_17;
	// System.Collections.Generic.List`1<AnswerPanel> GameController::answerPanelList
	List_1_t2804800104 * ___answerPanelList_18;
	// System.Collections.Generic.List`1<System.Collections.Generic.List`1<System.Int32>> GameController::answerList
	List_1_t810119712 * ___answerList_19;
	// System.Collections.Generic.List`1<SimulateItem> GameController::simulateList
	List_1_t651643993 * ___simulateList_20;
	// System.Collections.Generic.List`1<System.Int32> GameController::ctmAnswerList
	List_1_t1440998580 * ___ctmAnswerList_21;
	// System.Collections.Generic.List`1<SimulateItem> GameController::tempSimulateSelectedList
	List_1_t651643993 * ___tempSimulateSelectedList_22;
	// System.Collections.Generic.List`1<SimulateItem> GameController::simulateSelectedList
	List_1_t651643993 * ___simulateSelectedList_23;
	// System.Boolean GameController::hasStartSimulate
	bool ___hasStartSimulate_24;
	// System.Boolean GameController::hasConfirmSimulate
	bool ___hasConfirmSimulate_25;
	// System.Int32 GameController::SimulateLinkCount
	int32_t ___SimulateLinkCount_26;
	// LineMode GameController::curLineMode
	int32_t ___curLineMode_27;
	// System.Single GameController::timer
	float ___timer_28;
	// System.Int32 GameController::step
	int32_t ___step_29;
	// System.Boolean GameController::pauseGame
	bool ___pauseGame_30;
	// System.Boolean GameController::JLinkMode
	bool ___JLinkMode_31;
	// System.Boolean GameController::LLinkMode
	bool ___LLinkMode_32;
	// System.Boolean GameController::CtmLinkMode
	bool ___CtmLinkMode_33;
	// System.Collections.Generic.List`1<System.Int32> GameController::LList
	List_1_t1440998580 * ___LList_34;
	// System.Collections.Generic.List`1<System.Int32> GameController::JList
	List_1_t1440998580 * ___JList_35;
	// System.Int32 GameController::maxX
	int32_t ___maxX_36;
	// System.Int32 GameController::maxY
	int32_t ___maxY_37;
	// System.Int32 GameController::simulateMaxX
	int32_t ___simulateMaxX_38;
	// System.Int32 GameController::simulateMaxY
	int32_t ___simulateMaxY_39;
	// GameMode GameController::curGameMode
	int32_t ___curGameMode_40;
	// ChallengeMode GameController::challengeMode
	int32_t ___challengeMode_41;
	// System.Int32 GameController::score
	int32_t ___score_42;
	// System.Int32 GameController::challengeLevel
	int32_t ___challengeLevel_43;
	// System.Collections.Generic.List`1<System.Int32> GameController::LAnswerList
	List_1_t1440998580 * ___LAnswerList_44;
	// System.Collections.Generic.List`1<System.Int32> GameController::JAnswerList
	List_1_t1440998580 * ___JAnswerList_45;

public:
	inline static int32_t get_offset_of_maxCol_3() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___maxCol_3)); }
	inline int32_t get_maxCol_3() const { return ___maxCol_3; }
	inline int32_t* get_address_of_maxCol_3() { return &___maxCol_3; }
	inline void set_maxCol_3(int32_t value)
	{
		___maxCol_3 = value;
	}

	inline static int32_t get_offset_of_maxRow_4() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___maxRow_4)); }
	inline int32_t get_maxRow_4() const { return ___maxRow_4; }
	inline int32_t* get_address_of_maxRow_4() { return &___maxRow_4; }
	inline void set_maxRow_4(int32_t value)
	{
		___maxRow_4 = value;
	}

	inline static int32_t get_offset_of_star1Time_5() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___star1Time_5)); }
	inline int32_t get_star1Time_5() const { return ___star1Time_5; }
	inline int32_t* get_address_of_star1Time_5() { return &___star1Time_5; }
	inline void set_star1Time_5(int32_t value)
	{
		___star1Time_5 = value;
	}

	inline static int32_t get_offset_of_star2Time_6() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___star2Time_6)); }
	inline int32_t get_star2Time_6() const { return ___star2Time_6; }
	inline int32_t* get_address_of_star2Time_6() { return &___star2Time_6; }
	inline void set_star2Time_6(int32_t value)
	{
		___star2Time_6 = value;
	}

	inline static int32_t get_offset_of_star3Time_7() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___star3Time_7)); }
	inline int32_t get_star3Time_7() const { return ___star3Time_7; }
	inline int32_t* get_address_of_star3Time_7() { return &___star3Time_7; }
	inline void set_star3Time_7(int32_t value)
	{
		___star3Time_7 = value;
	}

	inline static int32_t get_offset_of_chessValueList_8() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___chessValueList_8)); }
	inline List_1_t1440998580 * get_chessValueList_8() const { return ___chessValueList_8; }
	inline List_1_t1440998580 ** get_address_of_chessValueList_8() { return &___chessValueList_8; }
	inline void set_chessValueList_8(List_1_t1440998580 * value)
	{
		___chessValueList_8 = value;
		Il2CppCodeGenWriteBarrier(&___chessValueList_8, value);
	}

	inline static int32_t get_offset_of_chessList_9() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___chessList_9)); }
	inline List_1_t3511596185 * get_chessList_9() const { return ___chessList_9; }
	inline List_1_t3511596185 ** get_address_of_chessList_9() { return &___chessList_9; }
	inline void set_chessList_9(List_1_t3511596185 * value)
	{
		___chessList_9 = value;
		Il2CppCodeGenWriteBarrier(&___chessList_9, value);
	}

	inline static int32_t get_offset_of_hasStartGame_10() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___hasStartGame_10)); }
	inline bool get_hasStartGame_10() const { return ___hasStartGame_10; }
	inline bool* get_address_of_hasStartGame_10() { return &___hasStartGame_10; }
	inline void set_hasStartGame_10(bool value)
	{
		___hasStartGame_10 = value;
	}

	inline static int32_t get_offset_of_hasStartLink_11() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___hasStartLink_11)); }
	inline bool get_hasStartLink_11() const { return ___hasStartLink_11; }
	inline bool* get_address_of_hasStartLink_11() { return &___hasStartLink_11; }
	inline void set_hasStartLink_11(bool value)
	{
		___hasStartLink_11 = value;
	}

	inline static int32_t get_offset_of_selectedList_12() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___selectedList_12)); }
	inline List_1_t3511596185 * get_selectedList_12() const { return ___selectedList_12; }
	inline List_1_t3511596185 ** get_address_of_selectedList_12() { return &___selectedList_12; }
	inline void set_selectedList_12(List_1_t3511596185 * value)
	{
		___selectedList_12 = value;
		Il2CppCodeGenWriteBarrier(&___selectedList_12, value);
	}

	inline static int32_t get_offset_of_LinkCount_13() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___LinkCount_13)); }
	inline int32_t get_LinkCount_13() const { return ___LinkCount_13; }
	inline int32_t* get_address_of_LinkCount_13() { return &___LinkCount_13; }
	inline void set_LinkCount_13(int32_t value)
	{
		___LinkCount_13 = value;
	}

	inline static int32_t get_offset_of_maxLinkCount_14() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___maxLinkCount_14)); }
	inline int32_t get_maxLinkCount_14() const { return ___maxLinkCount_14; }
	inline int32_t* get_address_of_maxLinkCount_14() { return &___maxLinkCount_14; }
	inline void set_maxLinkCount_14(int32_t value)
	{
		___maxLinkCount_14 = value;
	}

	inline static int32_t get_offset_of_curShowMode_15() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___curShowMode_15)); }
	inline int32_t get_curShowMode_15() const { return ___curShowMode_15; }
	inline int32_t* get_address_of_curShowMode_15() { return &___curShowMode_15; }
	inline void set_curShowMode_15(int32_t value)
	{
		___curShowMode_15 = value;
	}

	inline static int32_t get_offset_of_curLinkMode_16() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___curLinkMode_16)); }
	inline int32_t get_curLinkMode_16() const { return ___curLinkMode_16; }
	inline int32_t* get_address_of_curLinkMode_16() { return &___curLinkMode_16; }
	inline void set_curLinkMode_16(int32_t value)
	{
		___curLinkMode_16 = value;
	}

	inline static int32_t get_offset_of_curDiff_17() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___curDiff_17)); }
	inline int32_t get_curDiff_17() const { return ___curDiff_17; }
	inline int32_t* get_address_of_curDiff_17() { return &___curDiff_17; }
	inline void set_curDiff_17(int32_t value)
	{
		___curDiff_17 = value;
	}

	inline static int32_t get_offset_of_answerPanelList_18() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___answerPanelList_18)); }
	inline List_1_t2804800104 * get_answerPanelList_18() const { return ___answerPanelList_18; }
	inline List_1_t2804800104 ** get_address_of_answerPanelList_18() { return &___answerPanelList_18; }
	inline void set_answerPanelList_18(List_1_t2804800104 * value)
	{
		___answerPanelList_18 = value;
		Il2CppCodeGenWriteBarrier(&___answerPanelList_18, value);
	}

	inline static int32_t get_offset_of_answerList_19() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___answerList_19)); }
	inline List_1_t810119712 * get_answerList_19() const { return ___answerList_19; }
	inline List_1_t810119712 ** get_address_of_answerList_19() { return &___answerList_19; }
	inline void set_answerList_19(List_1_t810119712 * value)
	{
		___answerList_19 = value;
		Il2CppCodeGenWriteBarrier(&___answerList_19, value);
	}

	inline static int32_t get_offset_of_simulateList_20() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___simulateList_20)); }
	inline List_1_t651643993 * get_simulateList_20() const { return ___simulateList_20; }
	inline List_1_t651643993 ** get_address_of_simulateList_20() { return &___simulateList_20; }
	inline void set_simulateList_20(List_1_t651643993 * value)
	{
		___simulateList_20 = value;
		Il2CppCodeGenWriteBarrier(&___simulateList_20, value);
	}

	inline static int32_t get_offset_of_ctmAnswerList_21() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___ctmAnswerList_21)); }
	inline List_1_t1440998580 * get_ctmAnswerList_21() const { return ___ctmAnswerList_21; }
	inline List_1_t1440998580 ** get_address_of_ctmAnswerList_21() { return &___ctmAnswerList_21; }
	inline void set_ctmAnswerList_21(List_1_t1440998580 * value)
	{
		___ctmAnswerList_21 = value;
		Il2CppCodeGenWriteBarrier(&___ctmAnswerList_21, value);
	}

	inline static int32_t get_offset_of_tempSimulateSelectedList_22() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___tempSimulateSelectedList_22)); }
	inline List_1_t651643993 * get_tempSimulateSelectedList_22() const { return ___tempSimulateSelectedList_22; }
	inline List_1_t651643993 ** get_address_of_tempSimulateSelectedList_22() { return &___tempSimulateSelectedList_22; }
	inline void set_tempSimulateSelectedList_22(List_1_t651643993 * value)
	{
		___tempSimulateSelectedList_22 = value;
		Il2CppCodeGenWriteBarrier(&___tempSimulateSelectedList_22, value);
	}

	inline static int32_t get_offset_of_simulateSelectedList_23() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___simulateSelectedList_23)); }
	inline List_1_t651643993 * get_simulateSelectedList_23() const { return ___simulateSelectedList_23; }
	inline List_1_t651643993 ** get_address_of_simulateSelectedList_23() { return &___simulateSelectedList_23; }
	inline void set_simulateSelectedList_23(List_1_t651643993 * value)
	{
		___simulateSelectedList_23 = value;
		Il2CppCodeGenWriteBarrier(&___simulateSelectedList_23, value);
	}

	inline static int32_t get_offset_of_hasStartSimulate_24() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___hasStartSimulate_24)); }
	inline bool get_hasStartSimulate_24() const { return ___hasStartSimulate_24; }
	inline bool* get_address_of_hasStartSimulate_24() { return &___hasStartSimulate_24; }
	inline void set_hasStartSimulate_24(bool value)
	{
		___hasStartSimulate_24 = value;
	}

	inline static int32_t get_offset_of_hasConfirmSimulate_25() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___hasConfirmSimulate_25)); }
	inline bool get_hasConfirmSimulate_25() const { return ___hasConfirmSimulate_25; }
	inline bool* get_address_of_hasConfirmSimulate_25() { return &___hasConfirmSimulate_25; }
	inline void set_hasConfirmSimulate_25(bool value)
	{
		___hasConfirmSimulate_25 = value;
	}

	inline static int32_t get_offset_of_SimulateLinkCount_26() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___SimulateLinkCount_26)); }
	inline int32_t get_SimulateLinkCount_26() const { return ___SimulateLinkCount_26; }
	inline int32_t* get_address_of_SimulateLinkCount_26() { return &___SimulateLinkCount_26; }
	inline void set_SimulateLinkCount_26(int32_t value)
	{
		___SimulateLinkCount_26 = value;
	}

	inline static int32_t get_offset_of_curLineMode_27() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___curLineMode_27)); }
	inline int32_t get_curLineMode_27() const { return ___curLineMode_27; }
	inline int32_t* get_address_of_curLineMode_27() { return &___curLineMode_27; }
	inline void set_curLineMode_27(int32_t value)
	{
		___curLineMode_27 = value;
	}

	inline static int32_t get_offset_of_timer_28() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___timer_28)); }
	inline float get_timer_28() const { return ___timer_28; }
	inline float* get_address_of_timer_28() { return &___timer_28; }
	inline void set_timer_28(float value)
	{
		___timer_28 = value;
	}

	inline static int32_t get_offset_of_step_29() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___step_29)); }
	inline int32_t get_step_29() const { return ___step_29; }
	inline int32_t* get_address_of_step_29() { return &___step_29; }
	inline void set_step_29(int32_t value)
	{
		___step_29 = value;
	}

	inline static int32_t get_offset_of_pauseGame_30() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___pauseGame_30)); }
	inline bool get_pauseGame_30() const { return ___pauseGame_30; }
	inline bool* get_address_of_pauseGame_30() { return &___pauseGame_30; }
	inline void set_pauseGame_30(bool value)
	{
		___pauseGame_30 = value;
	}

	inline static int32_t get_offset_of_JLinkMode_31() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___JLinkMode_31)); }
	inline bool get_JLinkMode_31() const { return ___JLinkMode_31; }
	inline bool* get_address_of_JLinkMode_31() { return &___JLinkMode_31; }
	inline void set_JLinkMode_31(bool value)
	{
		___JLinkMode_31 = value;
	}

	inline static int32_t get_offset_of_LLinkMode_32() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___LLinkMode_32)); }
	inline bool get_LLinkMode_32() const { return ___LLinkMode_32; }
	inline bool* get_address_of_LLinkMode_32() { return &___LLinkMode_32; }
	inline void set_LLinkMode_32(bool value)
	{
		___LLinkMode_32 = value;
	}

	inline static int32_t get_offset_of_CtmLinkMode_33() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___CtmLinkMode_33)); }
	inline bool get_CtmLinkMode_33() const { return ___CtmLinkMode_33; }
	inline bool* get_address_of_CtmLinkMode_33() { return &___CtmLinkMode_33; }
	inline void set_CtmLinkMode_33(bool value)
	{
		___CtmLinkMode_33 = value;
	}

	inline static int32_t get_offset_of_LList_34() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___LList_34)); }
	inline List_1_t1440998580 * get_LList_34() const { return ___LList_34; }
	inline List_1_t1440998580 ** get_address_of_LList_34() { return &___LList_34; }
	inline void set_LList_34(List_1_t1440998580 * value)
	{
		___LList_34 = value;
		Il2CppCodeGenWriteBarrier(&___LList_34, value);
	}

	inline static int32_t get_offset_of_JList_35() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___JList_35)); }
	inline List_1_t1440998580 * get_JList_35() const { return ___JList_35; }
	inline List_1_t1440998580 ** get_address_of_JList_35() { return &___JList_35; }
	inline void set_JList_35(List_1_t1440998580 * value)
	{
		___JList_35 = value;
		Il2CppCodeGenWriteBarrier(&___JList_35, value);
	}

	inline static int32_t get_offset_of_maxX_36() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___maxX_36)); }
	inline int32_t get_maxX_36() const { return ___maxX_36; }
	inline int32_t* get_address_of_maxX_36() { return &___maxX_36; }
	inline void set_maxX_36(int32_t value)
	{
		___maxX_36 = value;
	}

	inline static int32_t get_offset_of_maxY_37() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___maxY_37)); }
	inline int32_t get_maxY_37() const { return ___maxY_37; }
	inline int32_t* get_address_of_maxY_37() { return &___maxY_37; }
	inline void set_maxY_37(int32_t value)
	{
		___maxY_37 = value;
	}

	inline static int32_t get_offset_of_simulateMaxX_38() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___simulateMaxX_38)); }
	inline int32_t get_simulateMaxX_38() const { return ___simulateMaxX_38; }
	inline int32_t* get_address_of_simulateMaxX_38() { return &___simulateMaxX_38; }
	inline void set_simulateMaxX_38(int32_t value)
	{
		___simulateMaxX_38 = value;
	}

	inline static int32_t get_offset_of_simulateMaxY_39() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___simulateMaxY_39)); }
	inline int32_t get_simulateMaxY_39() const { return ___simulateMaxY_39; }
	inline int32_t* get_address_of_simulateMaxY_39() { return &___simulateMaxY_39; }
	inline void set_simulateMaxY_39(int32_t value)
	{
		___simulateMaxY_39 = value;
	}

	inline static int32_t get_offset_of_curGameMode_40() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___curGameMode_40)); }
	inline int32_t get_curGameMode_40() const { return ___curGameMode_40; }
	inline int32_t* get_address_of_curGameMode_40() { return &___curGameMode_40; }
	inline void set_curGameMode_40(int32_t value)
	{
		___curGameMode_40 = value;
	}

	inline static int32_t get_offset_of_challengeMode_41() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___challengeMode_41)); }
	inline int32_t get_challengeMode_41() const { return ___challengeMode_41; }
	inline int32_t* get_address_of_challengeMode_41() { return &___challengeMode_41; }
	inline void set_challengeMode_41(int32_t value)
	{
		___challengeMode_41 = value;
	}

	inline static int32_t get_offset_of_score_42() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___score_42)); }
	inline int32_t get_score_42() const { return ___score_42; }
	inline int32_t* get_address_of_score_42() { return &___score_42; }
	inline void set_score_42(int32_t value)
	{
		___score_42 = value;
	}

	inline static int32_t get_offset_of_challengeLevel_43() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___challengeLevel_43)); }
	inline int32_t get_challengeLevel_43() const { return ___challengeLevel_43; }
	inline int32_t* get_address_of_challengeLevel_43() { return &___challengeLevel_43; }
	inline void set_challengeLevel_43(int32_t value)
	{
		___challengeLevel_43 = value;
	}

	inline static int32_t get_offset_of_LAnswerList_44() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___LAnswerList_44)); }
	inline List_1_t1440998580 * get_LAnswerList_44() const { return ___LAnswerList_44; }
	inline List_1_t1440998580 ** get_address_of_LAnswerList_44() { return &___LAnswerList_44; }
	inline void set_LAnswerList_44(List_1_t1440998580 * value)
	{
		___LAnswerList_44 = value;
		Il2CppCodeGenWriteBarrier(&___LAnswerList_44, value);
	}

	inline static int32_t get_offset_of_JAnswerList_45() { return static_cast<int32_t>(offsetof(GameController_t3607102586, ___JAnswerList_45)); }
	inline List_1_t1440998580 * get_JAnswerList_45() const { return ___JAnswerList_45; }
	inline List_1_t1440998580 ** get_address_of_JAnswerList_45() { return &___JAnswerList_45; }
	inline void set_JAnswerList_45(List_1_t1440998580 * value)
	{
		___JAnswerList_45 = value;
		Il2CppCodeGenWriteBarrier(&___JAnswerList_45, value);
	}
};

struct GameController_t3607102586_StaticFields
{
public:
	// GameController GameController::manager
	GameController_t3607102586 * ___manager_2;

public:
	inline static int32_t get_offset_of_manager_2() { return static_cast<int32_t>(offsetof(GameController_t3607102586_StaticFields, ___manager_2)); }
	inline GameController_t3607102586 * get_manager_2() const { return ___manager_2; }
	inline GameController_t3607102586 ** get_address_of_manager_2() { return &___manager_2; }
	inline void set_manager_2(GameController_t3607102586 * value)
	{
		___manager_2 = value;
		Il2CppCodeGenWriteBarrier(&___manager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
