//ÖVNING 02
string[] leksaker = {"leksak1", "leksak2", "leksak3", "leksak4", "leksak5"};
// Console.WriteLine(string.Join("\n", leksaker));



foreach (string lek in leksaker)
{
    Console.WriteLine(lek);
}

string[] namn = {"Martin", "Matija", "Imad", "Adam", "Saymmon"};

int[] num = {2, 3, 5, 7, 9};

for (int i = 0; i < namn.Length; i++)
{
    Console.WriteLine(namn[i] + "ger" + leksaker[i] + "betyget" + num[i]);
}


List<string> ListName = [];
Console.WriteLine("Skriv in namn eller skriv exit för att avsluta");
string names;
names = Console.ReadLine();
while (names != "exit")
{
    ListName.Add(names);
    Console.WriteLine("Skriv in namn eller skriv exit för att avsluta");
    names = Console.ReadLine();
}
Console.ReadLine();


