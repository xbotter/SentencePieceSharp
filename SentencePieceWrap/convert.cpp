#include "convert.h"
#include <string_view>
#include <vector>
using namespace System::Collections::Generic;
using namespace System::Runtime::InteropServices;
using namespace System;

std::string_view string_to_string_view(String^ str) {
	IntPtr ptr = Marshal::StringToHGlobalAnsi(str);
	char* charPointer = static_cast<char*>(ptr.ToPointer());
	std::string_view view(charPointer);
	return view;
}

std::vector<int> list_to_vector(List<int>^ managedList)
{
	std::vector<int> nativeVector;

	for each (int item in managedList)
	{
		nativeVector.push_back(item);
	}

	return nativeVector;
}