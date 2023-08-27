// See https://aka.ms/new-console-template for more information

using SentencePieceSharp;

var modelFile = "D:/GitHub/SentencePieceSharp/model/tokenizer.model";
if (File.Exists(modelFile))
{
    var process = new SentencePieceProcess(modelFile);

    var encoding = process.Encode("Hello World");

    Console.WriteLine(string.Join(",",encoding));
}
else
{
    Console.WriteLine("File Not Exists");
}

Console.ReadLine();