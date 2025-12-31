#!/bin/bash
cd "$(dirname "$0")"
# Launch app and redirect all output
./MyFirstAvaloniaApp </dev/null >/dev/null 2>&1 &
