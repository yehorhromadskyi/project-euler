module Runners

    open Problem12
    open BenchmarkDotNet.Attributes
    open BenchmarkDotNet.Engines
    open Mathematics.Attributes

    [<SimpleJob(RunStrategy.Monitoring, targetCount = 2)>]
    type Problem12Runner () =
    //BenchmarkRunner.Run typeof<ProblemsRunner.Problem12Runner> |> ignore

        [<Benchmark>]
        member self.FindTriangleNumberWithOver () = findTriangleNumberWithOver 150


    [<SimpleJob(RunStrategy.Monitoring, targetCount = 3)>]
    type UtilsRunner () =
    //BenchmarkDotNet.Running.BenchmarkRunner.Run typeof<Runners.UtilsRunner> |> ignore

        [<Benchmark>]
        member self.FactorsTest () = getFactors System.Int32.MaxValue
        
