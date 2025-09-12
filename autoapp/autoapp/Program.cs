using autoapp;

string[] olvas = File.ReadAllLines("autok.csv");
List<Auto> adatok = new List<Auto>();
foreach (string line in olvas.Skip(1))
{
    adatok.Add(new Auto(line));
}

Console.WriteLine("5.feladat: {0} auto volt ", adatok.Count());

int darab = 0;
int eladott = 0;
foreach (Auto e in adatok)
{
    if (e.eladott != 0)
    {
        eladott += e.eladott;
        darab++;
    }
}

double atlag = Math.Round((double)eladott / darab, 1);
Console.WriteLine(atlag);

Console.WriteLine("7.feladat: Az elmúlt 5 évben gyártott autók: ");

int max = 2023;
int kell = max - 5;
foreach (Auto e in adatok)
{
    if (e.gyartev != 0)
    {
        max = e.gyartev;
    }
}

foreach (Auto e in adatok)
{
    if (e.gyartev > kell)
    {
        Console.WriteLine("\t- {0} {1} : {2}", e.marka, e.nev, e.gyartev);
    }
}

Console.WriteLine("8.feladat: Legsikeresebb márkák listája az eladott darabszám alapján:");

Dictionary<string, int> kocsi = new Dictionary<string, int>();

foreach (Auto e in adatok)
{
    if (e.eladott != 0)
    {
        if (kocsi.ContainsKey(e.marka))
        {
            kocsi[e.marka] += e.eladott;
        }
        else
        {
            kocsi.Add(e.marka, e.eladott);
        }
    }
}


List<KeyValuePair<string, int>> rendezettLista = new List<KeyValuePair<string, int>>(kocsi);
rendezettLista.Sort((a, b) => b.Value.CompareTo(a.Value));
foreach (var e in rendezettLista)
{
    Console.WriteLine("\t- {0} : {1} db", e.Key, e.Value);
}

/*
foreach (var e in kocsi.OrderByDescending(x => x.Value))
{
    Console.WriteLine("\t- {0} : {1} db", e.Key, e.Value);
}
 */