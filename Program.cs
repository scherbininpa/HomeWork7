// See https://aka.ms/new-console-template for more information

using HomeWork7;

Loader Loader = new Loader(@"O:\sharpProekt\HomeWork\HomeWork7\Users.txt");
Loader.Load();
Loader.Print();
Loader.Sort();
Loader.Print();
//Loader.AddUser("Сергеев Сергей Сергеевич", 34,187,Convert.ToDateTime("23.12.2020"),"Волгоград");
//Loader.Save();
Console.ReadKey();
//Console.WriteLine("Hello, World!");
