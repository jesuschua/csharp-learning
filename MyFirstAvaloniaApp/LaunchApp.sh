#!/bin/bash
# Launch the app without showing terminal output
cd "$(dirname "$0")"
exec ./bin/Release/net10.0/osx-arm64/publish/MyFirstAvaloniaApp 2>/dev/null
