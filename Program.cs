using System.Xml.Serialization;


// See https://aka.ms/new-console-template for more information=
String[] console = ["GBA", "DS", "3DS", "heartgold", "ryujinx", "switch", "sudachi", "hcr","showdown"];
Random randonConsole = new Random();
int rndConsole = randonConsole.Next(console.Length);
Console.WriteLine(console[rndConsole]);
Console.ReadLine();
