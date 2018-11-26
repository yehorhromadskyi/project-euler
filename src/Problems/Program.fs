open System
open System.Diagnostics
open Mathematics


[<EntryPoint>]
let main argv =
    let sw = new Stopwatch()
    sw.Start()
    // let warmUpCall = Problem12.findTriangleNumberWithOver 150
    // printfn "Warm up call took %d milliseconds" sw.ElapsedMilliseconds
    // sw.Restart()
    let result = Problem12.findTriangleNumberWithOver 500
    printfn "Result %i in %d milliseconds" result sw.ElapsedMilliseconds

    // sw.Restart()

    // let result1 = Attributes.getFactors (System.Int32.MaxValue - 1)
    // printfn "Result %i in %d milliseconds" result1.Length sw.ElapsedMilliseconds

    // sw.Restart()

    // let result2 = Attributes.countFactors (System.Int32.MaxValue - 1)
    // printfn "Result2 %i in %d milliseconds" result2 sw.ElapsedMilliseconds

    sw.Stop()

    //BenchmarkDotNet.Running.BenchmarkRunner.Run typeof<Runners.Problem12Runner> |> ignore

    //Console.ReadLine() |> ignore
    
    0 // return an integer exit code

