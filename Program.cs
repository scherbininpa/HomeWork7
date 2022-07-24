// See https://aka.ms/new-console-template for more information

using HomeWork7;
string File = @"O:\sharpProekt\HomeWork\HomeWork7\Users.txt";

Menu menu = new Menu(File);
//menu.PrintMenu();
menu.Work();
Console.ReadKey();
//Loader Loader = new Loader(File);