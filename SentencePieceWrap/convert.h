#pragma once 

#ifndef CONVERT_H
#define CONVERT_H

#include <string_view>
#include <vector>
using namespace System::Collections::Generic;
using namespace System::Runtime::InteropServices;
using namespace System;


std::string_view string_to_string_view(String^ str);

std::vector<int> list_to_vector(List<int>^ managedList);

#endif

