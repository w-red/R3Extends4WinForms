@echo off
setlocal
pushd "%~dp0"

echo ========================================
echo Generating report for .NET Framework 4.7.2...
echo ========================================
dotnet run -f net472

echo.
echo ========================================
echo Generating report for .NET 6.0...
echo ========================================
dotnet run -f net6.0-windows

echo.
echo ========================================
echo Generating report for .NET 8.0...
echo ========================================
dotnet run -f net8.0-windows

echo.
echo ========================================
echo Generating report for .NET 10.0...
echo ========================================
dotnet run -f net10.0-windows

echo.
echo ========================================
echo All reports generated.
echo ========================================
popd
endlocal
pause
