#!/bin/bash


kill -9 $(lsof -t -i:5000)

/usr/bin/dotnet /home/mo/dotnet-updater/dotnet-updater/dotnet-updater-test-api/bin/Release/net5.0/dotnet-updater-test-api.dll