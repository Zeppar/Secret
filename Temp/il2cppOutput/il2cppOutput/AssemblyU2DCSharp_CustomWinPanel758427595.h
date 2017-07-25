#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Text
struct Text_t356221433;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CustomWinPanel
struct  CustomWinPanel_t758427595  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text CustomWinPanel::scoreText
	Text_t356221433 * ___scoreText_2;
	// UnityEngine.UI.Text CustomWinPanel::bestScoreText
	Text_t356221433 * ___bestScoreText_3;
	// UnityEngine.UI.Text CustomWinPanel::timeText
	Text_t356221433 * ___timeText_4;
	// UnityEngine.UI.Text CustomWinPanel::bestTimeText
	Text_t356221433 * ___bestTimeText_5;

public:
	inline static int32_t get_offset_of_scoreText_2() { return static_cast<int32_t>(offsetof(CustomWinPanel_t758427595, ___scoreText_2)); }
	inline Text_t356221433 * get_scoreText_2() const { return ___scoreText_2; }
	inline Text_t356221433 ** get_address_of_scoreText_2() { return &___scoreText_2; }
	inline void set_scoreText_2(Text_t356221433 * value)
	{
		___scoreText_2 = value;
		Il2CppCodeGenWriteBarrier(&___scoreText_2, value);
	}

	inline static int32_t get_offset_of_bestScoreText_3() { return static_cast<int32_t>(offsetof(CustomWinPanel_t758427595, ___bestScoreText_3)); }
	inline Text_t356221433 * get_bestScoreText_3() const { return ___bestScoreText_3; }
	inline Text_t356221433 ** get_address_of_bestScoreText_3() { return &___bestScoreText_3; }
	inline void set_bestScoreText_3(Text_t356221433 * value)
	{
		___bestScoreText_3 = value;
		Il2CppCodeGenWriteBarrier(&___bestScoreText_3, value);
	}

	inline static int32_t get_offset_of_timeText_4() { return static_cast<int32_t>(offsetof(CustomWinPanel_t758427595, ___timeText_4)); }
	inline Text_t356221433 * get_timeText_4() const { return ___timeText_4; }
	inline Text_t356221433 ** get_address_of_timeText_4() { return &___timeText_4; }
	inline void set_timeText_4(Text_t356221433 * value)
	{
		___timeText_4 = value;
		Il2CppCodeGenWriteBarrier(&___timeText_4, value);
	}

	inline static int32_t get_offset_of_bestTimeText_5() { return static_cast<int32_t>(offsetof(CustomWinPanel_t758427595, ___bestTimeText_5)); }
	inline Text_t356221433 * get_bestTimeText_5() const { return ___bestTimeText_5; }
	inline Text_t356221433 ** get_address_of_bestTimeText_5() { return &___bestTimeText_5; }
	inline void set_bestTimeText_5(Text_t356221433 * value)
	{
		___bestTimeText_5 = value;
		Il2CppCodeGenWriteBarrier(&___bestTimeText_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
