open System
type MyType = MyNamespace.MyType

[<EntryPoint>]
let main argv =
    let mt = new MyType("My inner state")

    printfn $"1. Inner state {mt.InnerState}"
    printfn $"2. StaticMethod {MyType.StaticMethod()}"
    printfn $"3. MathNumericsSampleValue {mt.MathNumericsSampleValue}"
    //printfn $"4. ThothJsonSampleValue {mt.ThothJsonSampleValue}"
    0 // return an integer exit code
