// See https://aka.ms/new-console-template for more information
using SerializationGeneratorTest;

Console.WriteLine("Hello, World!");

//TestClass testClass = new();

TestClass4 tmp = new(1, 2, "3", new());

using MemoryStream ms = new();
using BinaryWriter bw = new(ms);

long posPreSerializing = ms.Position;
tmp.Serialize(bw);
bw.Flush();
ms.Position = posPreSerializing;
using BinaryReader br = new(ms);
TestClass4.TryDeserialize(br, out TestClass4 tmp2);

Console.WriteLine(tmp.ToCustomString());
Console.WriteLine(tmp2.ToCustomString());
Console.ReadLine();
