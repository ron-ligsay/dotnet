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
