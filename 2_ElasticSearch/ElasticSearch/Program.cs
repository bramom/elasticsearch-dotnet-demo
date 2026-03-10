using Elastic.Clients.Elasticsearch;

if (args is not [var pattern, ..])
{
    Console.WriteLine("Please provide a search pattern as an argument.");
    return;
}

var settings = new ElasticsearchClientSettings(new Uri("http://localhost:9200"));
var client = new ElasticsearchClient(settings);

var response = await client.SearchAsync<dynamic>(s => s
    .Indices("documents")
    .Query(q => q
        .Match(m => m
            .Field("content")
            .Query(pattern)
        )
    )
);

foreach(var hit in response.Hits)
{    
    Console.WriteLine($"{hit.Source} ({hit.Score})");
}