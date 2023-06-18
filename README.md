# .Net
This is my repository for .Net and C# learning.


## Setting up C# and .Net in VS Code
https://www.youtube.com/watch?v=GVmtPO-UEps

## Creating a console
dotnet new
- to check available templates
dotnet new console
- to create a new console project tempalte

## Building and Running the console
dotnet build
dotnet run

## Creating new solution
dotnet new sln --name ConfSln


## dotnet new list
dotnet new list
this list the available templates

## dotnet new gitignore
dotnet new gitignore

## dotnet new console -f net7.0 --name "TestUI"
dotnet new console -f net7.0 --name "TestUI"

## dotnet new classlib -f net7.0 --name "HelperLib"


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



### Other notes

dotnet new sln --name BlazorSln
dotnet new gitignore
dotnet new blazorserver --name BlazorDemo
dotnet sln BlazorSln.sln add BlazorDemo/BlazorDemo.csproj
f5 - to create launch
run

if the port numner is a 5000 series its a http not secure

stop run

at .vscode launch.json
on line 12 after prelaunch task, add:
"launchSettingsProfile": "https",

then run... will be a https


adding a hotreload
at .vscode launch.json
change prelaunch build to watch

dotnet h
will give you commands
manage and manipulate your dotnet project without editors