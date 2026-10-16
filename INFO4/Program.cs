//string name = "Maria";
//int age = 17;
//double height = 1.64;

//Console.WriteLine($"Mam na imię {name}.");
//Console.WriteLine($"Mam {age} lat.");
//Console.WriteLine($"Mam {height} m wzrostu.");

//Console.WriteLine("Wpisz tu swój wiek: ");
//int wiek = int.Parse(Console.ReadLine());


//Console.WriteLine("Napisz za ile lat chcesz zobaczyć jaki będzie twój wiek: ");

//int zaIle = int.Parse(Console.ReadLine());

//int wynik = wiek + zaIle;
//Console.WriteLine($"Wynik: {wynik}");

//Console.WriteLine("Wpisz tu swoje imię: ");
//string imie = Console.ReadLine();

//if (imie == "maszka" || imie == "tiomka")
//{
//    Console.WriteLine("Ty krutaya/Ty krutoy");
//}
//else
//{
//    Console.WriteLine("Ty nie maszka i nie tiomka :((((((((");
//}


//Console.WriteLine("Podaj swój wynik: ");
//int wynik = int.Parse(Console.ReadLine());

//if (wynik >= 90)
//{
//    Console.WriteLine("Masz ocenę: 6");
//}
//else if (wynik >= 80)
//{
//    Console.WriteLine("Masz ocenę: 5");
//}
//else if (wynik >= 70)
//{
//    Console.WriteLine("Masz ocenę: 4");
//}
//else if (wynik >= 60)
//{
//    Console.WriteLine("Masz ocenę: 3");
//}
//else
//{
//    Console.WriteLine("Ty loszok");
//}

Console.WriteLine("Wpisz swoją frazę: ");
string? fraza = Console.ReadLine();

Console.WriteLine("Ile razy chcesz wyświetlić swoją frazę?");
int ilosc = int.Parse(Console.ReadLine());

for (int i = 1; i <= ilosc; i++)
{
    Console.WriteLine(fraza);
}



