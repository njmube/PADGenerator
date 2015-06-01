@echo Off
REM variables

set solutionName=TAlex.PADGenerator.sln
set config=Release
set buildDir=Build
set packagesDir=%buildDir%\packages

REM process

mkdir %buildDir%
mkdir %packagesDir%

msbuild %solutionName% /p:Configuration="%config%" /p:BuildPackage=true /p:PackageOutputDir="%cd%\%packagesDir%"
