// Learn more about F# at http://fsharp.org

open System
open BenchmarkDotNet.Running
open Problem7Benchmark
open Problem8Benchmark

let primesBenchmarks = BenchmarkRunner.Run typeof<PrimesGenerator>
let stringSplittingBenchmarks = BenchmarkRunner.Run typeof<StringSplitting>

[<EntryPoint>]
let main argv =
    //BenchmarkRunner.Run typeof<PrimesGenerator>
    stringSplittingBenchmarks
    Console.ReadLine()
    0 // return an integer exit code


