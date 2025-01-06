Client c1 = new();
Client c2 = new();

FindFiles ff1 = new(".\\obj","json");
FindFiles ff2 = new(".","json");

ff1.Done += c1.fetchFIle;
ff2.Done += c2.fetchFIle;

ff1.Find();
ff2.Find();

Console.WriteLine("end");

