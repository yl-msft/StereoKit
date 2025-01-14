#pragma once

#include "stereokit.h"

namespace sk {

struct device_data_t {
	display_type_     display_type;
	display_blend_   display_blend;
	float            display_refresh_rate;
	int32_t          display_width;
	int32_t          display_height;
	fov_info_t       display_fov;
	device_tracking_ tracking;
	char*            name;
	char*            gpu;
	bool32_t         has_eye_gaze;
	bool32_t         has_hand_tracking;
};

extern device_data_t device_data;

void device_data_init(device_data_t *data);
void device_data_free(device_data_t *data);

}