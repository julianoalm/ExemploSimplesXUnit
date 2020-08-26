dotnet tool install -g dotnet-reportgenerator-globaltool

dotnet test ../PrimeiroTeste.sln /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput="TestResults\\Coverage\\MyClass"

reportgenerator "-reports:TestResults\Coverage\MyClass.cobertura.xml" "-targetdir:TestResults\Coverage" -reporttypes:HTML

start TestResults\Coverage\index.htm
PAUSE