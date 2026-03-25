# Create .data directory if it doesn't exist
New-Item -ItemType Directory -Path "../.data" -Force

# Download shakespeare.json
Invoke-WebRequest -Uri "https://download.elastic.co/demos/kibana/gettingstarted/8.x/shakespeare.json" -OutFile "../.data/shakespeare.json"

# Download The Adventures of Sherlock Holmes.zip
Invoke-WebRequest -Uri "https://www.gutenberg.org/cache/epub/1661/pg1661.txt" -OutFile "../.data/The Adventures of Sherlock Holmes.txt"
