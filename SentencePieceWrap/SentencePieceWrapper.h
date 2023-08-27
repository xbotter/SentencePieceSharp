#pragma once

#ifndef SENTENCEPIECE_H
#define SENTENCEPIECE_H
using namespace System;
using namespace System::Collections::Generic;

namespace SentencePieceNative {

	public ref class SentencePieceWrapper :IDisposable {
	public:
		SentencePieceWrapper(String^ model_file);
		~SentencePieceWrapper();
		List<int>^ Encode(String^ input);
		String^ Decode(List<int>^ input);
		int BosId();
		int EosId();
		int PadId();
		int VocabSize();
	private:
		sentencepiece::SentencePieceProcessor* processor;
	};
}
#endif 