// See https://aka.ms/new-console-template for more information
using Generator.Generators;

var arg1 = args[0];

switch (arg1)
{
   case "country": 
    Console.WriteLine("Generating Country.cs");
    await CountryGenerator.Generate("../Snippets");
    return;
   case "currency":
    Console.WriteLine("Generating Currency.cs");
    await CurrencyGenerator.Generate("../Snippets");
    return;
   default:
    Console.WriteLine("Argument must be country or currency");
    return;
}
