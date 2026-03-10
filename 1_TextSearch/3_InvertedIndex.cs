using System.Diagnostics;

var fileName = "../.data/The Adventures of Sherlock Holmes.txt";
//var fileName = "../.data/bigtext.txt";

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

// Inverted index
Console.WriteLine();
Console.WriteLine("Inverted index:");
foreach (var kv in index.Take(5))
{
    Console.WriteLine($"\t{kv.Key} -> {string.Join(",", kv.Value.Take(5))}");
}