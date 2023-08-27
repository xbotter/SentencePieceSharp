using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentencePieceSharp.Sample
{
    public class Tokenizer
    {
        private readonly SentencePieceProcessor _processor;
        public int Words { get; set; }
        public int BosId { get; set; }
        public int EosId { get; set; }
        public int PadId { get; set; }

        public Tokenizer(string modelPath)
        {
            _processor = new SentencePieceProcessor(modelPath);
            Words = _processor.GetVocabSize();
            BosId = _processor.GetBosId();
            EosId = _processor.GetEosId();
            PadId = _processor.GetPadId();

        }

        public List<int> Encode(string str, bool bos = false, bool eos = false)
        {
            var tokens = _processor.Encode(str);
            if (bos)
            {
                tokens.Insert(0, BosId);
            }
            if (eos)
            {
                tokens.Add(EosId);
            }
            return tokens;
        }

        public string Decode(List<int> tokens)
        {
            return _processor.Decode(tokens);
        }

    }
}
