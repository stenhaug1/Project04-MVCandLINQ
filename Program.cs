string[] line = File.ReadAllLines("DigiDB_digimonlist.csv");
int i2 = 0;

List<Digimon> digimons = new List<Digimon>();

for (int i = 1; i < line.Length; i++)
{
    string[] parts = line[i].Split(',');

    Digimon digimons1 = new Digimon
    {
        Number = int.Parse(parts[0]),
        Name = parts[1],
        Stage = parts[2],
        Type = parts[4]

    };
    digimons.Add(digimons1);
}
Console.WriteLine("Enter Digimon name or leave blank");
string nameinput = Console.ReadLine();

Console.WriteLine("Enter stage(free/training/etc) or leave blank");
string stageinput = Console.ReadLine();

Console.WriteLine("Enter the type of the Digimon(fire/wind/etc) or leave blank");
string typeinput = Console.ReadLine();

var filteredDigimons = digimons.Where(a =>
(string.IsNullOrEmpty(nameinput) || a.Name.Equals(nameinput, StringComparison.OrdinalIgnoreCase)) &&
(string.IsNullOrEmpty(stageinput) || a.Stage.Equals(stageinput, StringComparison.OrdinalIgnoreCase)) &&
(string.IsNullOrEmpty(typeinput) || a.Type.Equals(typeinput, StringComparison.OrdinalIgnoreCase))
).ToList();
foreach (var a in filteredDigimons)
{
    Console.WriteLine($"{a.Number} {a.Name} stage is currently {a.Stage} the type is {a.Type} ");
    i2++;
}
Console.WriteLine($" There were {i2} Digimons matching your criteria in the search");