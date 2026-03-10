using System.Text;

var outputFile = "../.data/bigtext.txt";
long targetSize = 100L * 1024 * 1024; // ~100MB

var phrases = new[]
{
    "Welcome To The World of Free Plain Vanilla Electronic Texts",
    "Welcome To The World",
    "Free Plain Vanilla Electronic Texts",
    "Plain Vanilla Electronic Texts"
};

var fillerWords = new[]
{
    "document","search","engine","elastic","index","database","query",
    "information","system","text","analysis","content","processing",
    "library","reader","digital","archive","metadata","storage",
    "software","technology","development","performance","scalable"
};

var random = new Random();
var sb = new StringBuilder(1024 * 8);

using var writer = new StreamWriter(outputFile, false, Encoding.UTF8);

long written = 0;
int sentenceCounter = 0;

while (written < targetSize)
{
    sb.Clear();

    // svaka 50. rečenica ubaci jednu od glavnih fraza
    if (sentenceCounter % 50 == 0)
    {
        sb.Append(phrases[random.Next(phrases.Length)]);
        sb.Append(". ");
    }
    else
    {
        int words = random.Next(8, 20);

        for (int i = 0; i < words; i++)
        {
            var word = fillerWords[random.Next(fillerWords.Length)];
            sb.Append(word);

            if (i < words - 1)
                sb.Append(' ');
        }

        sb.Append(". ");
    }

    var text = sb.ToString();

    writer.Write(text);
    written += Encoding.UTF8.GetByteCount(text);

    sentenceCounter++;
}

writer.Flush();

Console.WriteLine($"Generated file: {outputFile}");
Console.WriteLine($"Size: {new FileInfo(outputFile).Length / (1024 * 1024)} MB");