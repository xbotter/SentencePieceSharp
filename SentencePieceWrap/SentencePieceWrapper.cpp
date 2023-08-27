// SentencePieceWrapper.cpp
#include <iostream>
#include <string>
#include <vector>
#include <string_view>
#include "include/sentencepiece_processor.h"
#include "SentencePieceWrapper.h"
#include "convert.h"
using namespace System::Runtime::InteropServices;
using namespace System::Collections::Generic;
using namespace std;

namespace SentencePieceNative {

	SentencePieceWrapper::SentencePieceWrapper(String^ model_path)
	{
		std::string_view view = string_to_string_view(model_path);
		processor = new sentencepiece::SentencePieceProcessor();
		processor->Load(view);
	}

	SentencePieceWrapper::~SentencePieceWrapper() {
		delete processor;
	}
	List<int>^ SentencePieceWrapper::Encode(String^ input)
	{
		std::vector<int> output;
		processor->Encode(string_to_string_view(input), &output);
		List<int>^ managedOutput = gcnew List<int>(output.size());
		for (int i = 0; i < output.size(); i++) {
			managedOutput->Add(output[i]);
		}
		return managedOutput;
	}

	String^ SentencePieceWrapper::Decode(List<int>^ input) {
		std::vector<int> ids = list_to_vector(input);
		std::string* detokenized = nullptr;

		processor->Decode(ids, detokenized);

		String^ result = gcnew String(detokenized->c_str());
		delete detokenized;
		return result;
	}
	int SentencePieceWrapper::BosId() {
		return processor->bos_id();
	}
	int SentencePieceWrapper::EosId()
	{
		return processor->eos_id();
	}
	int SentencePieceWrapper::PadId() {
		return processor->pad_id();
	}
	int SentencePieceWrapper::VocabSize() {
		return processor->GetPieceSize();
	}


}