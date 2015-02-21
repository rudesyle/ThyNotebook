@echo off
for /f "tokens=*" %%i in ('dir "%~dp0..\Node.js*" /b /o-n') do (
	"%~dp0..\%%i\node.exe" %*
	goto :eof
)