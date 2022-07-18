// See https://aka.ms/new-console-template for more information

using HomeWork7;

Loader Loader = new Loader(@"O:\sharpProekt\HomeWork\HomeWork7\Users.txt");
Loader.Load();
Loader.Save();

Console.WriteLine("Hello, World!");
