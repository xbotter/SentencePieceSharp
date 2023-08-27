// See https://aka.ms/new-console-template for more information

using SentencePieceSharp;
using SentencePieceSharp.Sample;

var modelFile = Path.Combine(Directory.GetCurrentDirectory(), "../../../../model/tokenizer.model");
if (File.Exists(modelFile))
{
    var tokenizer = new Tokenizer(modelFile);

    Console.WriteLine(string.Join(",", tokenizer.Encode("Hello World")));
}
else
{
    Console.WriteLine($"File {modelFile} Not Exists");
}

Console.ReadLine();