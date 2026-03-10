using Serilog;

var elasticUri = "http://localhost:9200"; // ili tvoj Elastic endpoint

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console() // vidi log odmah u konzoli
    .WriteTo.Elasticsearch(new Serilog.Sinks.Elasticsearch.ElasticsearchSinkOptions(new Uri(elasticUri))
    {
        AutoRegisterTemplate = true, // napravi template automatski
        IndexFormat = "test-logs-{0:yyyy.MM.dd}" // dnevni index
    })
    .Enrich.FromLogContext()
    .CreateLogger();

try
{
    Log.Information("App starting...");

    Log.Warning("Ovo je test warning");
    Log.Error("Ovo je test error");

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}