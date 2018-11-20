open System
open BenchmarkDotNet.Running


[<EntryPoint>]
let main argv =
    BenchmarkRunner.Run typeof<ProblemsRunner.Problem12Runner> |> ignore

    // let triangleNumber = findTriangleNumberWithOver 100
    // printfn "The number is %i" triangleNumber

    Console.ReadLine() |> ignore
    
    0 // return an integer exit code

