using Elastic.Clients.Elasticsearch;

var settings = new ElasticsearchClientSettings(new Uri("http://localhost:9200")).DefaultIndex("documents");

var client = new ElasticsearchClient(settings);

IndexResponse res = await client.IndexAsync(new
{    
    Title = "Elastic introduction",
    Content = "ElasticSearch is a search engine"
}, Guid.NewGuid().ToString());

Console.WriteLine(res.Result);

// await client.IndexAsync(new
// {
//     Title = "Title 2",
//     Content = "2nd document"
// }, Guid.NewGuid().ToString());


// await client.IndexAsync(new
// {    
//     Title = "Title 3",
//     Content = "3rd document"
// }, Guid.NewGuid().ToString());
