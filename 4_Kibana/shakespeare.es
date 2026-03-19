GET http://localhost:9200/shakespeare/_search
{
  "query": {
    "match": {
      "text_entry": {
        "query": "peace war",
        "operator": "and"
      }
    }
  }
}

