# Create .data directory if it doesn't exist
New-Item -ItemType Directory -Path ".data" -Force

# Download shakespeare.json
Invoke-WebRequest -Uri "https://download.elastic.co/demos/kibana/gettingstarted/8.x/shakespeare.json" -OutFile ".data\shakespeare.json"

# Download The Adventures of Sherlock Holmes.txt
Invoke-WebRequest -Uri "https://www.kaggle.com/datasets/ukveteran/big-text?resource=download" -OutFile ".data\The Adventures of Sherlock Holmes.txt"