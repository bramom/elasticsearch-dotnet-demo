using System.Diagnostics;

var fileName = "../.data/The Adventures of Sherlock Holmes.txt";
//var fileName = "../.data/bigtext.txt";
var searchPattern = "world";

var text = File.ReadAllText(fileName);

var sw = Stopwatch.StartNew();

var count = text.Split(' ')
                .Count(w => w.Equals(searchPattern, StringComparison.OrdinalIgnoreCase));

sw.Stop();

Console.WriteLine($"Found {count} matches");
Console.WriteLine($"Index search time: {sw.ElapsedMilliseconds} ms / {sw.ElapsedTicks} ticks ");