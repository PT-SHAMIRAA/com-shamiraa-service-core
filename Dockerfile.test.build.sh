docker build -f Dockerfile.test.build -t com-Shamiraa-service-core-webapi:test-build .
docker create --name com-Shamiraa-service-core-webapi-test-build com-Shamiraa-service-core-webapi:test-build
mkdir bin
docker cp com-Shamiraa-service-core-webapi-test-build:/out/. ./bin/publish
docker build -f Dockerfile.test -t com-Shamiraa-service-core-webapi:test .
