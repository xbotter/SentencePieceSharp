using System;
using System.Collections.Generic;
using System.Text;
using SentencePieceNative;
namespace SentencePieceSharp
{
    public sealed class SentencePieceProcess : IDisposable
    {
        private SentencePieceWrapper _wrapper;

        public SentencePieceProcess(string modelPath)
        {
            this._wrapper = new SentencePieceWrapper(modelPath);
        }

        public void Dispose()
        {
            _wrapper.Dispose();
        }

        public int GetVocabSize()
        {
            return _wrapper.VocabSize();
        }

        public int GetBosId()
        {
            return _wrapper.BosId();
        }

        public int GetEosId()
        {
            return _wrapper.EosId();
        }

        public int GetPadId()
        {
            return _wrapper.PadId();
        }
        public List<int> Encode(string input)
        {
            return _wrapper.Encode(input);
        }

        public string Decode(List<int> ids)
        {
            return _wrapper.Decode(ids);
        }

    }
}
