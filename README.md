# Elasticsearch Demo

## Data
>cd 0_GenerateData
>.\download-data.ps1
>dotnet run --file .\txtfile.cs

## Challenge

Searching through large volumes of data 

> dotnet run --file .\1_BruteForce.cs
> dotnet run --file .\2_HashTable.cs
> dotnet run --file .\3_InvertedIndex.cs

ElasticSearch uses the same idea, but in a distributed way and with more advanced tokenization.

## ElasticSearch

### Introduction
https://www.elastic.co/blog/a-practical-introduction-to-elasticsearch

http://localhost:9200/

>2_ElasticSearch\docker compose up -d
>2_ElasticSearch\ElasticIndex
>2_ElasticSearch\ElasticSearch\dotnet run -- document

## Logs
3_Logs>dontet run

An index has been created

## Kibana & tools

http://localhost:5601/

https://download.elastic.co/demos/kibana/gettingstarted/8.x/shakespeare.json

Quering

Discover: search, Top Values, Visualize

Visualize library: Lens / Tags cloud / ...

### Plugin
https://marketplace.visualstudio.com/items?itemName=cweijan.vscode-mysql-client2

### .http
