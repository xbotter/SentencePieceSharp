// See https://aka.ms/new-console-template for more information

using SentencePieceSharp;

var modelFile = Path.Combine(Directory.GetCurrentDirectory(), "../../../../model/tokenizer.model");
if (File.Exists(modelFile))
{
    var processor = new SentencePieceProcessor(modelFile);

    var encoded = processor.Encode("Hello World");

    Console.WriteLine(string.Join(",", encoded));
}
else
{
    Console.WriteLine($"File {modelFile} Not Exists");
}

Console.ReadLine();