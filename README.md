# TypeProviderWithThothRepro
My straggles with custom type provider that uses Thoth.Json.Net

This is just a minimal reproducable solution, not the project I actually work on.
I created it from https://github.com/fsprojects/FSharp.TypeProviders.SDK instructions

The custom type provider is consumed by ConsoleApp (included in this repo) via nuget package.
The original code without any modifications works. 

It contains Math.Numerics nuget package to prove that  I'm using non-standard libraries correctly.
However when I do uncomment code that uses Thoth.Json API  I'm getting following error:

![image](https://user-images.githubusercontent.com/56049414/128770155-d6b042d1-9d8c-4278-996d-d16f6a1d7638.png)


