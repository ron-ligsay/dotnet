# Visual Studio Code for C# Developers | .NET Conf 2022
https://www.youtube.com/watch?v=fuBi4d7k1-M


# Creating new solution
dotnet new sln --name ConfSln


# dotnet new list
dotnet new list
this list the available templates

# dotnet new gitignore
dotnet new gitignore

# dotnet new console -f net7.0 --name "TestUI"
dotnet new console -f net7.0 --name "TestUI"

# dotnet new classlib -f net7.0 --name "HelperLib"


- dotnet sln ConfSln.sln add TestUI/TestUI.csproj

- dotnet sln ConfSln.sln add HelperLib/HelperLib.csproj


## Adding reference
dotnet add TestUI/TestUI.csproj reference HelperLib/HelperLib.csproj

## Adding a package dappper
cd HelperLib
dotnet add package Dapper

## To  run
ctrl + shift + p
.NET Generate Assets for Build and Debug
or dotnet build
