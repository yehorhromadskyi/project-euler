open System
open System.Diagnostics
open Mathematics

[<EntryPoint>]
let main argv =
    let sw = new Stopwatch()
    sw.Start()
    let warmUpCall = Problem13.findLargeSum
    printfn "Warm up call took %d milliseconds" sw.ElapsedMilliseconds
    sw.Restart()
    let result = Problem13.findLargeSum
    printfn "Result %i in %d milliseconds" result sw.ElapsedMilliseconds

    sw.Stop()

    //BenchmarkDotNet.Running.BenchmarkRunner.Run typeof<Runners.Problem12Runner> |> ignore

    //Console.ReadLine() |> ignore
    
    0 // return an integer exit code

