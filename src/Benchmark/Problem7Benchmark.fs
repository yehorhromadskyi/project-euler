module Problem7Benchmark

open BenchmarkDotNet.Attributes
open Problem7

[<MemoryDiagnoser>]
type PrimesGenerator () =
    
    [<Benchmark>]
    member self.GetPrimes() = primeAt 10001


