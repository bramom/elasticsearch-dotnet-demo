# Create .data directory if it doesn't exist
New-Item -ItemType Directory -Path ".data" -Force

# Download shakespeare.json
Invoke-WebRequest -Uri "https://download.elastic.co/demos/kibana/gettingstarted/8.x/shakespeare.json" -OutFile ".data\shakespeare.json"

# Download The Adventures of Sherlock Holmes.zip
$zipUrl = "https://storage.googleapis.com/kaggle-data-sets/855081/1458304/compressed/big.txt.zip?X-Goog-Algorithm=GOOG4-RSA-SHA256&X-Goog-Credential=gcp-kaggle-com%40kaggle-161607.iam.gserviceaccount.com%2F20260319%2Fauto%2Fstorage%2Fgoog4_request&X-Goog-Date=20260319T113628Z&X-Goog-Expires=259200&X-Goog-SignedHeaders=host&X-Goog-Signature=99c6408c8996e19cd487a843987c7fc55a4d0404226415bab78016b996e3d060890b26b4338137989d243b1357f54643786ad3f50e34486a003e8178b84a8e4d886bcbfba6c5351196d5fcfde13faf7e8f6634443e55b5c5f4e50d5b9bc76231f8eb11332dfa80bc23ff28f1bf060f57f3b3f02b42f6056b64c561697963f8aba019adb02462dcd326bb4011f8bd78a3a0746a0709eed2b5ab1927ada254816ed68b53524ef741c54c23e015e9ecef479dc9982228474ab4b1f5138ea45663811b45c27f52946903e5314ea42bbd156a9e24b3a701ba3ec45eb3e29c3e979d197ca306f72c764150308db98124efb4540c63d01c382e6c95b768ed48f6a77f82"
$zipPath = ".data\big.txt.zip"
Invoke-WebRequest -Uri $zipUrl -OutFile $zipPath

# Extract the zip file
Expand-Archive -Path $zipPath -DestinationPath ".data" -Force

# Rename the extracted file to The Adventures of Sherlock Holmes.txt
Move-Item -Path ".data\big.txt" -Destination ".data\The Adventures of Sherlock Holmes.txt" -Force

# Clean up the zip file
Remove-Item -Path $zipPath