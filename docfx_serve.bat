cd /d "%~dp0"
docfx docfx.json --serve -p 8080
timeout /T 60
