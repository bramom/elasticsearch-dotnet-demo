curl.exe -H "Content-Type: application/x-ndjson" `
  -X POST "http://localhost:9200/shakespeare/_bulk" `
  --data-binary "@../.data/shakespeare.json"