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

POST _sql?format=txt
{
  "query": """
  SELECT 
    speaker,
    COUNT(*) AS line_count
  FROM shakespeare
  WHERE text_entry LIKE '%love%'
  GROUP BY speaker
  ORDER BY line_count DESC
  LIMIT 10
  """
}

POST /_sql/translate
{
  "query": """
  SELECT 
    speaker,
    COUNT(*) AS line_count
  FROM shakespeare
  WHERE text_entry LIKE '%love%'
  GROUP BY speaker
  ORDER BY line_count DESC
  LIMIT 10
  """
}


POST http://localhost:9200/_sql?format=txt
{
  "query": """
    SELECT 
      speaker,
      COUNT(*) AS line_count
    FROM shakespeare
    WHERE text_entry LIKE '%love%'
    GROUP BY speaker
    ORDER BY line_count DESC
    LIMIT 10
  """
}