#C sharp Hello World

## C# practice

## Steps to get started:

The following steps will be prompted to you--

1. Within VS code install C#
2. downlaod the .NET SDK for CLI (this took about 20 minutes)

Then I started following the 10 minute guide(https://www.microsoft.com/net/learn/dotnet/hello-world-tutorial)--

3. Install .NET SDK
4. Type this into terminal to create a getting started folder, preloaded with files-- dotnet new console -o myApp
5. If successful, should see this in terminal--

```
Getting ready...
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on myApp/myApp.csproj...
  Restoring packages for /Users/maddys87/Documents/code_projects/myApp/myApp.csproj...
  Generating MSBuild file /Users/maddys87/Documents/code_projects/myApp/obj/myApp.csproj.nuget.g.props.
  Generating MSBuild file /Users/maddys87/Documents/code_projects/myApp/obj/myApp.csproj.nuget.g.targets.
  Restore completed in 221.59 ms for /Users/maddys87/Documents/code_projects/myApp/myApp.csproj.

Restore succeeded.
```

6. cd myApp
7. run the app-- dotnet run
8. Should return Hello World!
9. To save this local repo, after opening the downloaded zip file provided by the .NET docs, I had to use github desktop to import the local folder, create repo(?), then hit the publish button in the upper right hand corner of github desktop.
