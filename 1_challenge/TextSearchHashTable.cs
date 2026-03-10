using System.Diagnostics;

var fileName = "../.data/The Adventures of Sherlock Holmes.txt";
var searchPattern = "world";


var text = File.ReadAllText(fileName);

var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

var sw = Stopwatch.StartNew();

var index = new Dictionary<string, List<int>>();

for (int i = 0; i < words.Length; i++)
{
    var word = words[i].ToLower();

    if (!index.TryGetValue(word, out var list))
    {
        list = new List<int>();
        index[word] = list;
    }

    list.Add(i);
}

sw.Stop();

Console.WriteLine($"Index build time: {sw.ElapsedMilliseconds} ms");

sw.Restart();

var results = index[searchPattern];

sw.Stop();

Console.WriteLine($"Index search time: {sw.ElapsedMilliseconds} ms / {sw.ElapsedTicks} ticks ");
Console.WriteLine($"Found {results.Count} matches");