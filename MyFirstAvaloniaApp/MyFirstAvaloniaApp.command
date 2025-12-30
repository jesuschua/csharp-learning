#!/bin/bash
cd "$(dirname "$0")"
./bin/Release/net10.0/osx-arm64/publish/MyFirstAvaloniaApp > /dev/null 2>&1 &

