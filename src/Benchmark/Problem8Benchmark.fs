module Problem8Benchmark

open BenchmarkDotNet.Attributes
open Problem8

[<MemoryDiagnoser>]
type StringSplitting () =
    
    [<Benchmark>]
    member self.Split() = split 4


