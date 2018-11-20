module ProblemsRunner

    open Problem12
    open BenchmarkDotNet.Attributes

    type Problem12Runner () =

        [<Benchmark>]
        member self.Run () = findTriangleNumberWithOver 100     