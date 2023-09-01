cd /d "%~dp0"
del _site\*.* /f /s / q
del api\*.yml /f /s / q
del api\.manifest /f / q
timeout /T 60
