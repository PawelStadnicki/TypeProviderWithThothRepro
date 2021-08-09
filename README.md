# TypeProviderWithThothRepro
My straggles with custom type provider that uses Thoth.Json.Net

This is just a minimal reproducable solution, not the project I actually work on.
I created it from https://github.com/fsprojects/FSharp.TypeProviders.SDK instructions (skipped tests adjustments as I'm using 
Console App that is included in this repo for testing purposes)

The original code without any modifications works for me. 
It contains Math.Numerics nuget package to prove that  I'm using non-standard liblaries correctly.

However when I do uncomment code that uses Thoth.Json API (https://github.com/PawelStadnicki/TypeProviderWithThothRepro/blob/9338496f391081f7a6196ccac0a23d9a10421f5d/src/TypeProviderWithThoth.DesignTime/TypeProviderWithThoth.DesignTime.fs#L68)  I'm getting following error:

![image](https://user-images.githubusercontent.com/56049414/128770155-d6b042d1-9d8c-4278-996d-d16f6a1d7638.png)


