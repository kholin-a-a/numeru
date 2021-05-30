$ErrorActionPreference = "Stop"
$version = "0.0.16"

docker build -t kholinaa/numeru-web:$version .
docker tag kholinaa/numeru-web:$version kholinaa/numeru-web:latest
docker image push kholinaa/numeru-web:$version
docker image push kholinaa/numeru-web:latest
